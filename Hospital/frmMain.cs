using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Hospital.Class;
using Hospital.Model;
using mgh;
using System.Linq;
using System.IO;

namespace Hospital
{
    public partial class frmMain : Form
    {
        int timeNotif = 0;
        public frmMain()
        {
            InitializeComponent();
        }
     
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                timeNotif = 0;
                //lblday.Text = WepApi.ClsTools.AyamHafte();
                lblUserName.Text = " خوش آمدید " + Program.tblUserLogin.Name + " " + Program.tblUserLogin.LastName;
               
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ex.Message, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }


        }
    
        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                Forms.frmUsers frmUsers = new Forms.frmUsers();       
                frmUsers.Show();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnOtagh_Click(object sender, EventArgs e)
        {
            Forms.frmOtagh frmCustomers = new Forms.frmOtagh();    
            frmCustomers.Show();
        }
                     

        private void btnPaziresh_Click(object sender, EventArgs e)
        {
            Forms.frmPaziresh frmPaziresh = new Forms.frmPaziresh();
            Forms.frmPaziresh.LoadTypeID = 0;
            frmPaziresh.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Program.tblUserLogin = new Model.tblUser();

            Application.Exit();

        }
                   
        private void btnTasviyeHeasb_Click(object sender, EventArgs e)
        {
            Forms.frmTasviyeHeasb frmCarpetPrice = new Forms.frmTasviyeHeasb();
            frmCarpetPrice.Show();
        }
            
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.tblUserLogin = new Model.tblUser();
            Application.Exit();
        }
        
    }
}
