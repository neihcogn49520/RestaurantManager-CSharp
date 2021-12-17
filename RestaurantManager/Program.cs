using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin(new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-P3RMIME\SQLEXPRESS;Initial Catalog=QL_NhaHang1;User ID=sa; Password=ngochien0409")));
        }
    }
}
