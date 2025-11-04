using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public partial class AddMenuItemForm : Form
    {
        User user = AppContext.CurrentUser;
        private bool isEditMode = false;
        private int editingItemId = -1;
        private string imagePath = null; 

        public AddMenuItemForm()
        {
            InitializeComponent();
            LoadCategories();
            SetupForm();

            // Enable drag-and-drop and click-to-upload for the picture box
            pictureBoxPreview.AllowDrop = true;
            pictureBoxPreview.Click += pictureBoxProfile_Click;
            pictureBoxPreview.DragEnter += pictureBoxProfile_DragEnter;
            pictureBoxPreview.DragDrop += pictureBoxProfile_DragDrop;
        }

        public AddMenuItemForm(int itemId, string name, string category, decimal price, string ingredients, int popularity, string preparationTime, bool isAvailable)
        {
            InitializeComponent();
            isEditMode = true;
            editingItemId = itemId;

            LoadCategories();
            SetupForm();

            txtItemName.Text = name;
            cmbCategory.SelectedItem = category;
            txtPrice.Text = price.ToString("F2");
            chkAvailable.Checked = isAvailable;

            // Enable drag-and-drop and click-to-upload for the picture box
            pictureBoxPreview.AllowDrop = true;
            pictureBoxPreview.Click += pictureBoxProfile_Click;
            pictureBoxPreview.DragEnter += pictureBoxProfile_DragEnter;
            pictureBoxPreview.DragDrop += pictureBoxProfile_DragDrop;
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    pictureBoxPreview.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void pictureBoxProfile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private void pictureBoxProfile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                imagePath = files[0];
                pictureBoxPreview.Image = Image.FromFile(imagePath);
            }
        }

        private bool IsImageFile(string filePath)
        {
            string ext = System.IO.Path.GetExtension(filePath).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("SELECT Name FROM MenuCategory", conn))
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void SetupForm()
        {
            cmbCategory.SelectedIndex = cmbCategory.Items.Count > 0 ? 0 : -1;
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtItemName.Text.Trim();
                string category = cmbCategory.SelectedItem?.ToString();
                string rawPrice = txtPrice.Text.Trim().ToUpper().Replace("RM", "").Trim();
                string cleanedPrice = rawPrice.Replace(',', '.');
                decimal price;

                if (!decimal.TryParse(cleanedPrice, NumberStyles.Number, CultureInfo.InvariantCulture, out price))
                {
                    MessageBox.Show("Invalid price format. Please enter a valid number (e.g., 100.00).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isAvailable = chkAvailable.Checked;
                int categoryId = GetCategoryIdByName(category);
                int chefUserId = UserSession.UserID;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter the item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                

                if (isEditMode)
                {
                    UpdateMenuItem(editingItemId, name, categoryId, chefUserId, price, isAvailable);
                    MessageBox.Show("Item updated successfully.");
                }
                else
                {
                    AddMenuItem(name, categoryId, chefUserId, price, isAvailable);
                    MessageBox.Show("Item added successfully.");
                }

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid price format. Please enter a numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCategoryIdByName(string categoryName)
        {
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand("SELECT CategoryID FROM MenuCategory WHERE Name = @Name", conn))
            {
                cmd.Parameters.AddWithValue("@Name", categoryName);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result == null)
                    throw new Exception("Category not found in database.");
                return (int)result;
            }
        }

        private void AddMenuItem(string name, int categoryId, int chefUserId, decimal price, bool isAvailable)
        {
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(
                @"INSERT INTO MenuItems (Name, CategoryID, UserID, Price, IsAvailable)
                  VALUES (@Name, @CategoryID, @UserID, @Price, @IsAvailable)", conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                cmd.Parameters.AddWithValue("@UserID", chefUserId);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable ? 1 : 0);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateMenuItem(int itemId, string name, int categoryId, int chefUserId, decimal price, bool isAvailable)
        {
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(
                @"UPDATE MenuItems SET Name=@Name, CategoryID=@CategoryID, UserID=@UserID, Price=@Price, IsAvailable=@IsAvailable
                  WHERE ItemID=@ItemID", conn))
            {
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                cmd.Parameters.AddWithValue("@UserID", chefUserId);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@IsAvailable", isAvailable ? 1 : 0);
                cmd.Parameters.AddWithValue("@ItemID", itemId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChefDashboardForm firstPage = new ChefDashboardForm(User.CurrentUser);
            firstPage.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm secondPage = new ManageMenuForm();
            secondPage.Show();
            this.Close();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            viewOrdersForm thirdPage = new viewOrdersForm();
            thirdPage.Show();
            this.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void AddMenuItemForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

    }
    }
}