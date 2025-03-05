using Microsoft.Data.SqlClient;
class ADO
{

    static void Main()
    {
        string cS = ("Server=MAINFRAME; Database=IOST; Integrated Security=True; TrustServerCertificate=true;");

        using (SqlConnection conn = new SqlConnection(cS))
        {
            conn.Open();

            //Insert Data
            string query = "INSERT INTO FACULTY (Course_Name, CourseID, No_of_Semester, fee) values ('BIT', 102, 8, 42000)";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data Inserted Successfully");
            }


            //Read Data
            string readQuery = "SELECT FEE FROM  FACULTY WHERE Course_Name = 'BIT'";
            SqlCommand readCmd = new SqlCommand(readQuery, conn);

            using (SqlDataReader reader = readCmd.ExecuteReader())
                while (reader.Read())
                {
                    Console.WriteLine(reader["fee"]);
                }

        }
    }

}

