using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public partial class updateProfileForm : Form
    {
        
        private string originalFirstName;
        private string originalLastName;
        private string originalEmail;
        private string originalPhone;
        private string originalUsername;
        
        public updateProfileForm()
        {
            InitializeComponent();

           
            txtChangeUsername.UseSystemPasswordChar = false;
            txtLastName.UseSystemPasswordChar = false;
            txtPhone.UseSystemPasswordChar = false;
            txtChangePassword.UseSystemPasswordChar = true;

            this.Load += updateProfileForm_Load;
            
        }

        private void updateProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand(
                    "SELECT FirstName, LastName, EmailAddress, ContactNo, Username FROM Users WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);
                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            originalFirstName = txtFirstName.Text = reader["FirstName"]?.ToString() ?? "";
                            originalLastName = txtLastName.Text = reader["LastName"]?.ToString() ?? "";
                            originalEmail = txtEmail.Text = reader["EmailAddress"]?.ToString() ?? "";
                            originalPhone = txtPhone.Text = reader["ContactNo"]?.ToString() ?? "";
                            originalUsername = txtChangeUsername.Text = reader["Username"]?.ToString() ?? "";
                        }
                    }
                }
                txtFirstName.Focus(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnSaveItem_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string username = txtChangeUsername.Text.Trim();
            string newPassword = txtChangePassword.Text.Trim();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string updateQuery = string.IsNullOrEmpty(newPassword) ?
                        "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @Email, ContactNo = @Phone, Username = @Username WHERE UserID = @UserID" :
                        "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, EmailAddress = @Email, ContactNo = @Phone, Username = @Username, Passwords = @NewPassword WHERE UserID = @UserID";

                    using (var cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@UserID", UserSession.UserID);

                        if (!string.IsNullOrEmpty(newPassword))
                            cmd.Parameters.AddWithValue("@NewPassword", newPassword);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                            MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                LoadUserProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Restore original values
            txtFirstName.Text = originalFirstName;
            txtLastName.Text = originalLastName;
            txtEmail.Text = originalEmail;
            txtPhone.Text = originalPhone;
            txtChangeUsername.Text = originalUsername;
            txtChangePassword.Text = ""; 
            txtFirstName.Focus(); 
        }

        private void btnBackHome_Click(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChefDashboardForm firstPage = new ChefDashboardForm(User.CurrentUser);
            firstPage.Show();
            this.Close();
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtChangePassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }
}