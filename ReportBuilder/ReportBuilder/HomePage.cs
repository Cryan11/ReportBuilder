using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ReportBuilder.QueryBuilder;
using static ReportBuilder.SavedReports;
using static ReportBuilder.NewCustomers;
using static ReportBuilder.DriveInModifier;
using static ReportBuilder.ArchiveCustomers;
using static ReportBuilder.Settings;


namespace ReportBuilder
{
    public partial class HomePage : Form
    {
        private string mycommand;

        public HomePage()
        {
            InitializeComponent();
            gbDriveInModifier.Hide();
            gbQueryBuilder.Hide();
            gbNewCustomers.Hide();
           lblPage.Text = "Welcome";
        }

        #region Unavailable functions

        private void buttonQueryBuilder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function is not yet available. Please check back soon!");
            lblPage.Text = "Query Builder";
            // gbQueryBuilder.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1click();
        }
        private void cbParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateParams();
        }
        private void btnSavedReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function is not yet available. Please check back soon!");

            lblPage.Text = "Saved Reports";
        }
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function is not yet available. Please check back soon!");
            lblPage.Text = "Settings";
        }
        private void btn_DriveInModifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function is not yet available. Please check back soon!");
            lblPage.Text = "Drive In Modifier";
            //gbDriveInModifier.Show();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {

        }
        private void btn_ArchiveCustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Function is not yet available. Please check back soon!");
            lblPage.Text = "Archive Customers";
        }

        #endregion

        #region Available Functions

        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            gbNewCustomers.Show();
            lblPage.Text = "New Customer Import";

        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            getCustomers();
        }



        #endregion

        private void btnExportCustomerList_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}