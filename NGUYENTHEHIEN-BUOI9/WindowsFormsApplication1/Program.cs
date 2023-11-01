using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Ketnoi
    {
        public SqlConnection connect;
        public Ketnoi()
        {
                connect = new SqlConnection("Data Source=A209PC12;Initial Catalog=QLKHOA;Integrated Security = True");
        }
        public Ketnoi(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
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
            Application.Run(new Form1());
        }
    }
}
