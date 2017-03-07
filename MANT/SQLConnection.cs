using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANT
{
    class SQLConnection
    {

        private MySqlConnection con;
        private MySqlCommand cmd;
        private DataTable dataTable = new DataTable();
        private MAIN myMain = new MAIN();

        public SQLConnection()
        {
            con = new MySqlConnection("server=localhost; user id=root; database=mant_db; password=1234;");

        }

        public void createNewPermit(string permitNo, string permitType, string clubName, string applicantName, 
            string trackName, DateTime startDate, DateTime endDate)
            
            

        {
            string command = "INSERT INTO mant_db.permit_licence " 
                + "(permit_type, club_name, applicant_name, track_name, permit_start_date, permit_end_date)"
                + "VALUES ('" + permitType + "', '" + clubName + "', '" + applicantName + "','" 
                + trackName + "', '" + formattDT(startDate) + "', '" + formattDT(endDate) + "')";

            try
            {
                con.Open();
                cmd = new MySqlCommand(command, con);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable retrieveContactList(MANT.MAIN main)
        {
            string contact_command = "SELECT * FROM mant_db.permit_licence";
            List<Permit> contact_list = new List<Permit>();
            con.Open();
            DataTable dt = new DataTable();

            cmd = new MySqlCommand(contact_command, con);
            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                
                da.Fill(dt);
            }
            Console.WriteLine("DTTTTTTTTTTTTTTTTTT = " + dt.Rows.Count);
            con.Close();

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
            //return contact_list;
            return dt;

        }

        private string formattDT(DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
