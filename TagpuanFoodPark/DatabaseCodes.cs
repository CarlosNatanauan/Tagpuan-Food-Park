using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagpuanFoodPark
{
    internal class DatabaseCodes
    {
        private static string connectionString = "Data Source=NATANAUAN\\SQLEXPRESS;Initial Catalog=TagpuanFoodPark;Integrated Security=True";


        public static DataTable GetStallList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT stallNo, price FROM stallAvailablle", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//display datagrid


        public static int GetNextStallNo()
        {
            int nextStallNo = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(stallNo) FROM stallAvailablle", connection);
                nextStallNo = (int)command.ExecuteScalar() + 1;
            }
            return nextStallNo;
        }//gets the stall count

        public static void AddStall(int price)
        {
            int stallNo = GetNextStallNo();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO stallAvailablle (stallNo, price) VALUES (@stallNo, @price)", connection);
                command.Parameters.AddWithValue("@stallNo", stallNo);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();
            }
        }//add stall





        public static void MoveStallToAvailable(int stallNo, int price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Insert the stall into the stallAvailablle table
                SqlCommand command = new SqlCommand("INSERT INTO stallAvailablle (stallNo, price) VALUES (@stallNo, @price)", connection);
                command.Parameters.AddWithValue("@stallNo", stallNo);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();

                // Delete the stall from the stallOccupied table
                command = new SqlCommand("DELETE FROM stallOccupied WHERE stallNo = @stallNo", connection);
                command.Parameters.AddWithValue("@stallNo", stallNo);
                command.ExecuteNonQuery();
            }
        }


        public static DataTable GetStallListOccupied()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT stallNo, price FROM stallOccupied", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//display datagrid Occupied





        public static void MoveStallToOccupied(int stallNo, int price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Insert the stall into the stallOccupied table
                SqlCommand command = new SqlCommand("INSERT INTO stallOccupied (stallNo, price) VALUES (@stallNo, @price)", connection);
                command.Parameters.AddWithValue("@stallNo", stallNo);
                command.Parameters.AddWithValue("@price", price);
                command.ExecuteNonQuery();

                // Delete the stall from the stallAvailablle table
                command = new SqlCommand("DELETE FROM stallAvailablle WHERE stallNo = @stallNo", connection);
                command.Parameters.AddWithValue("@stallNo", stallNo);
                command.ExecuteNonQuery();
            }
        }

        public static void InsertTenantInfo(int stallNo, string stallName, string tenantName, string contact, DateTime dateOccupied, int rent, int noMonthsPaid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Calculate the balance based on the number of months paid and the rent
                int balance = rent * (noMonthsPaid - 1);

                string query = "INSERT INTO tenantInfo (stallNo, stallName, tenantName, contact, dateOccupied, rent, balance) VALUES (@stallNo, @stallName, @tenantName, @contact, @dateOccupied, @rent, @balance)";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Calculate the balance based on the number of months paid and the rent
                    //int balance = rent * (noMonthsPaid - 1);

                    cmd.Parameters.AddWithValue("@stallNo", stallNo);
                    cmd.Parameters.AddWithValue("@stallName", stallName);
                    cmd.Parameters.AddWithValue("@tenantName", tenantName);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@dateOccupied", dateOccupied);
                    cmd.Parameters.AddWithValue("@rent", rent);
                    cmd.Parameters.AddWithValue("@balance", balance);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DateTime dueDate = dateOccupied.AddMonths(noMonthsPaid);
                    int debt = 0; // Initialize the debt to 0

                    // Insert payment info into the paymentsInfo table
                    InsertPaymentInfo(stallNo, stallName, tenantName, rent, dueDate, debt);
                }
            }
        }






        public static DataTable GetStallTenantInfo()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT stallNo, stallName, tenantName, contact, dateOccupied, rent, balance FROM tenantInfo", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//display datagrid tenantInfo


        public static void InsertPaymentInfo(int stallNo, string stallName, string tenantName, int rent, DateTime dueDate, int debt)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO paymentsInfo (stallNumber, stallName, tenantName, rent, dueDate, debt) VALUES (@stallNumber, @stallName, @tenantName, @rent, @dueDate, @debt)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stallNumber", stallNo);
                    cmd.Parameters.AddWithValue("@stallName", stallName);
                    cmd.Parameters.AddWithValue("@tenantName", tenantName);
                    cmd.Parameters.AddWithValue("@rent", rent);
                    cmd.Parameters.AddWithValue("@dueDate", dueDate);
                    cmd.Parameters.AddWithValue("@debt", debt);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }//display payments


        public static DataTable GetListPayment()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT stallNumber, stallName, tenantName, rent, dueDate, debt FROM paymentsInfo", connection);
                adapter.Fill(dt);
            }
            return dt;
        }//display datagrid payment


        public static void UpdateDueDate(int stallNo, DateTime newDueDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Update the due date in the paymentsInfo table
                string query = "UPDATE paymentsInfo SET dueDate = @newDueDate WHERE stallNumber = @stallNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stallNo", stallNo);
                    cmd.Parameters.AddWithValue("@newDueDate", newDueDate);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        public static void UpdateDebt(int stallNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                DateTime dueDate;
                int rent;

                // Retrieve due date and rent from the paymentsInfo table for the given stallNo
                string query = "SELECT dueDate, rent FROM paymentsInfo WHERE stallNumber = @stallNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@stallNo", stallNo);

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dueDate = reader.GetDateTime(0);
                            rent = reader.GetInt32(1);
                        }
                        else
                        {
                            throw new Exception("Stall number not found in the paymentsInfo table.");
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Calculate the number of months in debt
                int monthsInDebt = (DateTime.Now.Year - dueDate.Year) * 12 + DateTime.Now.Month - dueDate.Month;

                // Update the debt in the paymentsInfo table
                query = "UPDATE paymentsInfo SET debt = @debt WHERE stallNumber = @stallNo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    int debt = rent * Math.Max(0, monthsInDebt);

                    cmd.Parameters.AddWithValue("@stallNo", stallNo);
                    cmd.Parameters.AddWithValue("@debt", debt);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public static List<int> GetAllStallNumbers()
        {
            List<int> stallNumbers = new List<int>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT stallNumber FROM paymentsInfo", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stallNumbers.Add(reader.GetInt32(0));
                    }
                }
            }
            return stallNumbers;
        }



    }
}
