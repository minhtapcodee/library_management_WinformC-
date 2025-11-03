using System;
using System.Windows.Forms;
using QUANLYTHUVIENC3.GUI;


namespace QUANLYTHUVIENC3
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
