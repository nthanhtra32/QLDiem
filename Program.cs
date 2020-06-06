using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace QuanLyDiem
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

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-NI42UA8\\SQLEXPRESS;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True";
            if (con.State == System.Data.ConnectionState.Closed)
                try
                {
                    con.Open();
                    MessageBox.Show("mo ket noi thanh cong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            Application.Run(new FrmQue());
        }
    }
}
