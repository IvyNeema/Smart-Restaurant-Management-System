using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public partial class ManageMenuForm : Form
    {

        
        private DataTable menuItemsTable;
        private SqlDataAdapter menuItemsAdapter;

        public ManageMenuForm()
        {
            InitializeComponent();

            btnAddNewItem.MouseEnter += (s, e) => btnAddNewItem.BackColor = Color.LightGray;
            btnAddNewItem.MouseLeave += (s, e) => btnAddNewItem.BackColor = Color.White;

            btnDeleteSelectedItem.MouseEnter += (s, e) => btnDeleteSelectedItem.BackColor = Color.LightGray;
            btnDeleteSelectedItem.MouseLeave += (s, e) => btnDeleteSelectedItem.BackColor = Color.White;

            txtSearch.Text = "🔍 Search";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            txtSearch.TextChanged += txtSearch_TextChanged;

            SetupForm();
            this.Load += ManageMenuForm_Load;
        }

        private void ManageMenuForm_Load(object sender, EventArgs e)
        {
            LoadMenuItems();

            dgvMenuItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.AllowUserToAddRows = false;
        }

        private void LoadMenuItems()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    menuItemsAdapter = new SqlDataAdapter(
                        @"SELECT m.ItemID, m.Name, c.Name AS Category, m.Price, m.IsAvailable
                  FROM MenuItems m
                  JOIN MenuCategory c ON m.CategoryID = c.CategoryID", conn);

                   
                    menuItemsAdapter.UpdateCommand = new SqlCommand(
                        "UPDATE MenuItems SET Name = @Name, Price = @Price, IsAvailable = @IsAvailable WHERE ItemID = @ItemID", conn);
                    menuItemsAdapter.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
                    menuItemsAdapter.UpdateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 0, "Price");
                    menuItemsAdapter.UpdateCommand.Parameters.Add("@IsAvailable", SqlDbType.Bit, 0, "IsAvailable");
                    menuItemsAdapter.UpdateCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID").SourceVersion = DataRowVersion.Original;

                    menuItemsAdapter.InsertCommand = new SqlCommand(
                        "INSERT INTO MenuItems (Name, CategoryID, Price, IsAvailable) VALUES (@Name, (SELECT CategoryID FROM MenuCategory WHERE Name = @Category), @Price, @IsAvailable)", conn);
                    menuItemsAdapter.InsertCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, "Name");
                    menuItemsAdapter.InsertCommand.Parameters.Add("@Category", SqlDbType.NVarChar, 100, "Category");
                    menuItemsAdapter.InsertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 0, "Price");
                    menuItemsAdapter.InsertCommand.Parameters.Add("@IsAvailable", SqlDbType.Bit, 0, "IsAvailable");

                    menuItemsAdapter.DeleteCommand = new SqlCommand(
                        "DELETE FROM MenuItems WHERE ItemID = @ItemID", conn);
                    menuItemsAdapter.DeleteCommand.Parameters.Add("@ItemID", SqlDbType.Int, 0, "ItemID").SourceVersion = DataRowVersion.Original;

                    menuItemsTable = new DataTable();
                    conn.Open();
                    menuItemsAdapter.Fill(menuItemsTable);

                    menuItemsTable.PrimaryKey = new DataColumn[] { menuItemsTable.Columns["ItemID"] };

                    dgvMenuItems.DataSource = menuItemsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu items: " + ex.Message);
            }
        }


        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            var addForm = new AddMenuItemForm();
            addForm.ShowDialog();
            LoadMenuItems();
        }

        private void btnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvMenuItems.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvMenuItems.Rows.Remove(row); 
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteMenuItem(int itemId)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand("DELETE FROM MenuItems WHERE ItemID = @ItemID", conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting menu item: " + ex.Message);
            }
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMenuItems.EndEdit();
                this.BindingContext[menuItemsTable].EndCurrentEdit();

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    menuItemsAdapter.UpdateCommand.Connection = conn;
                    menuItemsAdapter.InsertCommand.Connection = conn;
                    menuItemsAdapter.DeleteCommand.Connection = conn;
                    menuItemsAdapter.Update(menuItemsTable);
                }

                MessageBox.Show("Changes saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMenuItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (menuItemsTable != null)
            {
                menuItemsTable.RejectChanges();
            }
            LoadMenuItems();
            MessageBox.Show("Changes canceled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetupForm()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All"); 
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

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "All", "Available", "Unavailable" });
            cmbCategory.SelectedIndex = 0; // Default to "All"
            cmbStatus.SelectedIndex = 0;   // Default to "All"
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            dgvMenuItems.ClearSelection();

            if (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "All")
                return;

            foreach (DataGridViewRow row in dgvMenuItems.Rows)
            {
                row.Selected = false;
                if (row.Cells["Category"].Value?.ToString().Equals(selectedCategory, StringComparison.OrdinalIgnoreCase) == true)
                {
                    row.Selected = true;
                    dgvMenuItems.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.SelectedItem?.ToString();
            dgvMenuItems.ClearSelection();

            if (string.IsNullOrEmpty(selectedStatus) || selectedStatus == "All")
                return;

            bool isAvailable = selectedStatus == "Available";
            foreach (DataGridViewRow row in dgvMenuItems.Rows)
            {
                var cellValue = row.Cells["IsAvailable"].Value;
                if (cellValue != null && Convert.ToBoolean(cellValue) == isAvailable)
                {
                    row.Selected = true;
                    dgvMenuItems.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText) || searchText == "🔍 Search")
            {
                dgvMenuItems.ClearSelection();
                return;
            }

            foreach (DataGridViewRow row in dgvMenuItems.Rows)
            {
                row.Selected = false;
                if (row.Cells["Name"].Value?.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    row.Selected = true;
                    dgvMenuItems.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "🔍 Search")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "🔍 Search";
                txtSearch.ForeColor = Color.Gray;
            }
        }



        private void btnDashboard_Click(object sender, EventArgs e)
        {
            new ChefDashboardForm(User.CurrentUser).Show();
            this.Close();
        }

        private void btnViewOrders_Click_1(object sender, EventArgs e)
        {
            new viewOrdersForm().Show();
            this.Close();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            new updateProfileForm().Show();
            this.Close();
        }

        private void dgvMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMenuItems.BackgroundColor = Color.White;
            dgvMenuItems.DefaultCellStyle.BackColor = Color.White;
            dgvMenuItems.DefaultCellStyle.ForeColor = Color.Black;
            dgvMenuItems.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvMenuItems.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvMenuItems.ColumnHeadersDefaultCellStyle.BackColor = Color.SaddleBrown;
            dgvMenuItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMenuItems.EnableHeadersVisualStyles = false;
        }
        private SqlCommandBuilder commandBuilder;

    }
}
