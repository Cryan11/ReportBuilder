using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReportBuilder
{
    public static class NewCustomers
    {
        public static void getCustomers()
        {

            var hp = new HomePage
            {
                dtpBeginDate = {Format = DateTimePickerFormat.Custom, CustomFormat = @"yyyy-MM-dd"},
                dtpEndDate = {Format = DateTimePickerFormat.Custom, CustomFormat = @"yyyy-MM-dd"}
            };
            var cs = new Connstr();
            cs.Open("auctiondb");
            MySqlCommand cmd = new MySqlCommand("SELECT " + "Lname AS 'Last Name', " + "Fname AS 'First Name', " +
                                                "CONCAT(Fname, ' ', Lname) as 'First and Last Name', " +
                                                "Addr1 AS 'Address 1', " + "Addr2 AS 'Address 2', " + "city AS City, " +
                                                "state AS State, " + "zip AS Zip ," + "Rep_code AS 'Field Rep', " +
                                                "rep_code2 AS 'Field Rep 2', " + "createdate AS 'Date Added' " +
                                                "FROM auctiondb.customer c " +
                                                $"where createdate between '{hp.dtpBeginDate.Value}' and '{hp.dtpEndDate.Value}' " +
                                                "and addr1 != '' " + "and lname <> '%#%' " + "group by idnbr " +
                                                "order by Lname, fname, addr1;"
            );
            MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd.CommandText, cs.DB);
            var cusTable = new DataTable();
            sqlDA.Fill(cusTable);
            hp.dgCustomers.DataSource = cusTable;



        }

        public static void Export()
        {
        }
    }
}
