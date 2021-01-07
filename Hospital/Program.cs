using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {    
        public static tblUser tblUserLogin=null;
        /// <summary>
        /// The main entry point for the application..
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
           
        }
    }
}
