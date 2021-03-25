using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace ReportBuilder
{
    class QueryBuilder
    {

        private static string mycommand;

        public static void CreateParams()
        {
            HomePage hp = new HomePage();

            if (hp.cbParams.Text == "SPECIFIC")
            {
                if (hp.lblColumns != null) hp.lblColumns.Visible = true;
                hp.checkedlistbox.Visible = true;

                if (hp.cbHistory.Text == "No")
                {
                    mycommand =
                        $"Select column_name from information_schema.columns where table_name = N'{hp.cbTable.Text}';";
                    var CS = new Connstr();
                    CS.Open("auctiondb");
                    var cmd = new MySqlCommand(mycommand, CS.DB);
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                        while (dr.Read())
                            hp.checkedlistbox.Items.Add(dr[0].ToString());
                    dr.Close();
                }
            }
            else if (hp.cbParams.Text == "ALL")
            {
                hp.lblColumns.Visible = false;
                hp.checkedlistbox.Visible = false;
            }


        }
        public static void button1click()
        {
            HomePage hp = new HomePage();
            var CS = new Connstr();
            CS.Open("auctiondb");

            if (hp.cbParams.Text == "ALL")
                if (hp.cbHistory.Text == "No")
                {
                    mycommand = $"Select * from auctiondb.{hp.cbTable.Text};";
                    var sqlDataAdapter = new MySqlDataAdapter(mycommand, CS.DB);
                    var Reports = new DataTable();
                    sqlDataAdapter.Fill(Reports);
                    hp.dgReport.DataSource = Reports;
                }
        }
    }

}
