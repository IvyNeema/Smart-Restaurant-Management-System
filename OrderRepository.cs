using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssignmentIOOP
{
    public static class OrderRepository
    {
        public static List<Order> GetOrdersFromDatabase()
        {
            var orders = new List<Order>();

            string query = @"
                SELECT 
                    o.OrderID,
                    u.FullName AS CustomerName,
                    mi.Name AS Item,
                    od.Quantity,
                    o.Status
                FROM Orders o
                JOIN Users u ON o.CustomerID = u.UserID
                JOIN OrderDetails od ON o.OrderID = od.OrderID
                JOIN MenuItems mi ON od.ItemID = mi.ItemID";

            using (var conn = DatabaseHelper.GetConnection()) using (var cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderID = reader["OrderID"] != DBNull.Value ? Convert.ToInt32(reader["OrderID"]) : 0,
                            CustomerName = reader["CustomerName"]?.ToString() ?? "",
                            Item = reader["Item"]?.ToString() ?? "",
                            Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0,
                            Status = reader["Status"]?.ToString() ?? ""
                        });
                    }
                }
            }

            return orders;
        }

        public static void UpdateOrderStatus(int ItemId, string newStatus)
        {
            using (var conn = DatabaseHelper.GetConnection())
            using (var cmd = new SqlCommand(
                @"UPDATE Orders 
          SET OrderStatus = @Status 
          WHERE OrderID IN (SELECT OrderID FROM OrderItems WHERE ItemID = @ItemID)", conn))
            {
                cmd.Parameters.AddWithValue("@Status", newStatus);
                cmd.Parameters.AddWithValue("@ItemID", ItemId);
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    MessageBox.Show("No rows were updated. Please check if the item/order exists.", "Update Failed");
                }
            }
        }


        public class Order
        {
            public int OrderID { get; set; }
            public string CustomerName { get; set; }
            public string Item { get; set; }
            public int Quantity { get; set; }
            public string Status { get; set; }
        }
    }



}
