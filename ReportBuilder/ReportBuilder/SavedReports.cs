using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public static class SavedReports
    {
        public static void Settings()
        {
            HomePage hp = new HomePage();
            hp.lblPage.Text = "Query Builder";
            hp.gbQueryBuilder.Show();
        }

    }
}
