using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public partial class viewOrdersForm : Form
    {
        
        public viewOrdersForm()
        {
            InitializeComponent();
            this.Load += viewOrdersForm_Load;
            
        }

        private void viewOrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.MultiSelect = false;

        }

        private void LoadOrders()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand(
                    @"SELECT 
                oi.ItemID,
                o.OrderID, 
                mi.Name AS Item, 
                oi.Quantity, 
                o.OrderStatus AS Status
            FROM Orders o
            JOIN Users u ON o.UserID = u.UserID
            JOIN OrderItems oi ON o.OrderID = oi.OrderID
            JOIN MenuItems mi ON oi.ItemID = mi.ItemID
            ORDER BY o.OrderID DESC, oi.OrderItemID", conn))
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    conn.Open();
                    da.Fill(dt);

                    dgvOrders.AutoGenerateColumns = true;
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message);
            }
        }



        private void btnInProgress_Click(object sender, EventArgs e)
        {
            UpdateSelectedOrderStatus("In Progress");
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            UpdateSelectedOrderStatus("Completed");
        }

        private void UpdateSelectedOrderStatus(string newStatus)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                // Supposed to use both OrderID and ItemID to uniquely identify the row
                var orderIdValue = dgvOrders.SelectedRows[0].Cells["OrderID"].Value;
                if (orderIdValue != null && int.TryParse(orderIdValue.ToString(), out int orderId))
                {
                    UpdateOrderStatus(orderId, newStatus);
                    LoadOrders();
                }
                else
                {
                    MessageBox.Show("Invalid order selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(
                @"UPDATE Orders 
          SET OrderStatus = @Status 
          WHERE OrderID = @OrderID", conn))
            {
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
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

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            updateProfileForm fourthPage = new updateProfileForm();
            fourthPage.Show();
            this.Close();
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}