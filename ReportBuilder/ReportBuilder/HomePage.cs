using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReportBuilder
{
    public partial class HomePage : Form
    {
        private string mycommand;

        public HomePage()
        {
            InitializeComponent();
        }

        private void buttonQueryBuilder_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Query Builder";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CS = new Connstr();
            CS.Open("auctiondb");

            if (cbParams.Text == "ALL")
                if (cbHistory.Text == "No")
                {
                    mycommand = $"Select * from auctiondb.{cbTable.Text};";
                    var sqlDataAdapter = new MySqlDataAdapter(mycommand, CS.DB);
                    var Reports = new DataTable();
                    sqlDataAdapter.Fill(Reports);
                    dgReport.DataSource = Reports;
                }
        }

        private void buttonSavedReports_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Saved Reports";
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Import";
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Settings";
        }

        private void cbParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbParams.Text == "SPECIFIC")
            {
                lblColumns.Visible = true;
                checkedlistbox.Visible = true;

                if (cbHistory.Text == "No")
                {
                    mycommand =
                        $"Select column_name from information_schema.columns where table_name = N'{cbTable.Text}';";
                    var CS = new Connstr();
                    CS.Open("auctiondb");
                    var cmd = new MySqlCommand(mycommand, CS.DB);
                    MySqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                        while (dr.Read())
                            checkedlistbox.Items.Add(dr[0].ToString());
                    dr.Close();
                }
            }
            else if (cbParams.Text == "ALL") 
            {
                    lblColumns.Visible = false;
                    checkedlistbox.Visible = false;
            }
            
        }
    }
}