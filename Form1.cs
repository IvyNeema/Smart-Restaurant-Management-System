using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public partial class ChefDashboardForm : Form
    {
        User loggedInUser;
        public ChefDashboardForm(User user)
        {
            InitializeComponent();
            StyleButtons();
            SetupLowStockTable();
            loggedInUser = user;
        }

        private void ChefDashboardForm_Load(object sender, EventArgs e)
        {
            UpdateOrderCounters();
            LoadLowStockItems();
        }

        private void StyleButtons()
        {
            btnManageMenu.MouseEnter += (s, e) => btnManageMenu.BackColor = Color.LightGray;
            btnManageMenu.MouseLeave += (s, e) => btnManageMenu.BackColor = Color.FromArgb(200, 255, 255, 255);

            btnViewOrders.MouseEnter += (s, e) => btnViewOrders.BackColor = Color.LightGray;
            btnViewOrders.MouseLeave += (s, e) => btnViewOrders.BackColor = Color.FromArgb(200, 255, 255, 255);

            btnUpdateProfile.MouseEnter += (s, e) => btnUpdateProfile.BackColor = Color.LightGray;
            btnUpdateProfile.MouseLeave += (s, e) => btnUpdateProfile.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void SetupLowStockTable()
        {
            // Clear and define columns explicitly to avoid mismatch
            dgvLowStock.Columns.Clear();
            dgvLowStock.Columns.Add("Name", "Name");
            dgvLowStock.Columns.Add("Category", "Category");
            dgvLowStock.Columns.Add("Status", "Status");
            dgvLowStock.Columns.Add("Action", "Action");

            dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLowStock.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgvLowStock.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLowStock.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvLowStock.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvLowStock.EnableHeadersVisualStyles = false;

            dgvLowStock.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvLowStock.Columns)
            {
                col.ReadOnly = false;
            }
        }

        private void LoadLowStockItems()
        {
            dgvLowStock.Rows.Clear();

            string query = @"
                SELECT Name, Category
                FROM (
                    SELECT mi.Name, mc.Name AS Category,
                           ROW_NUMBER() OVER (PARTITION BY mi.CategoryID ORDER BY mi.ItemID) AS rn
                    FROM MenuItems mi
                    INNER JOIN MenuCategory mc ON mi.CategoryID = mc.CategoryID
                    WHERE mi.IsAvailable = 1
                ) t
                WHERE rn = 1
                ORDER BY Category
                OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY
            ";

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string category = reader["Category"].ToString();
                        dgvLowStock.Rows.Add(name, category, "LOW", "Check");
                    }
                }
            }
        }

        private void lblPendingCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pending orders count clicked!");
        }

        private void UpdateOrderCounters()
        {
            int pending = 0, inProgress = 0, completed = 0;

            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(
                "SELECT OrderStatus, COUNT(*) AS Cnt FROM Orders GROUP BY OrderStatus", conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string status = reader["OrderStatus"].ToString();
                        int count = Convert.ToInt32(reader["Cnt"]);

                        switch (status)
                        {
                            case "Pending":
                                pending = count;
                                break;
                            case "In Progress":
                                inProgress = count;
                                break;
                            case "Completed":
                                completed = count;
                                break;
                        }
                    }
                }
            }

            lblPendingCount.Text = pending.ToString();
            lbl_InProgressCount.Text = inProgress.ToString();
            lblCompletedTodayCount.Text = completed.ToString();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenuForm secondPage = new ManageMenuForm();
            secondPage.Show();
            this.Hide();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            viewOrdersForm thirdPage = new viewOrdersForm();
            thirdPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateProfileForm fourthPage = new updateProfileForm();
            fourthPage.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle actions when clicking on a low stock item
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Login_Page loginForm = new Customer_Login_Page();
            loginForm.Show();
            this.Hide();
        }
    }
}