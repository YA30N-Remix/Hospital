using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Class;
using Hospital.Model;
using mgh;

namespace Hospital.Forms
{
    public partial class frmUsers : Form
    {
  
        int SaveType = 1;
        public static tblUser tblUser = new tblUser();     
       
        public frmUsers()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            try
            {
                
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblUsers
                            select new { a.UserID, a.Name, a.LastName, a.UserName,  ActiveName = a.Active == 0 ? "غیرفعال" : "فعال" };
                 
                if (txtSearch.Text.Trim().Length != 0)
                {
                    Query = Query.Where(a => a.UserID.ToString().Contains(txtSearch.Text) || a.Name.Contains(txtSearch.Text) || a.LastName.Contains(txtSearch.Text) || a.UserName.Contains(txtSearch.Text) || a.ActiveName.Contains(txtSearch.Text));
                }
                
                dgv.DataSource = Query.ToList();
                                   
                dgv.Columns[0].HeaderText = "کد کاربری";
                dgv.Columns[0].Width = 100;
                dgv.Columns[1].HeaderText = "نام";
                dgv.Columns[1].Width = 100;
                dgv.Columns[2].HeaderText = "نام خانوادگی";
                dgv.Columns[2].Width = 100;
                dgv.Columns[3].HeaderText = "نام کاربری";
                dgv.Columns[3].Width = 120;   
                dgv.Columns[4].HeaderText = "وضعیت";
                dgv.Columns[4].Width = 100;

            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        void BindRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                 tblUser = db.tblUsers.Find(tblUser.UserID);
                if (tblUser == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }
                txtName_.Text = tblUser.Name;
                txtLastName_.Text = tblUser.LastName;
                txtUserName_.Text = tblUser.UserName;
                txtPassWord_.Text =  tblUser.PassWord;
                txtRePassWord_.Text =  tblUser.PassWord;   
                 
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.ErrNotFound + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        void InsertRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                tblUser tblUser = new tblUser();
                var Query = from a in db.tblUsers
                            where a.UserName == txtUserName_.Text
                            select a.UserName;
                if (Query.Count()>0)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrRepeat, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                tblUser.Name = txtName_.Text;
                tblUser.LastName = txtLastName_.Text;
            
                tblUser.UserName = txtUserName_.Text;
                tblUser.PassWord = txtPassWord_.Text;       
                tblUser.Active = 1;                               
                db.tblUsers.Add(tblUser);
                db.SaveChanges();

        
                New();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var fullErrorMessage = string.Join("\n", errorMessages);
                var exceptionMessage = string.Concat(ClsMessage.Error, ex.Message, " The validation errors are: ", fullErrorMessage);
                FarsiMessagbox.Show(exceptionMessage, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }

        }

        void UpdateRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                 tblUser = db.tblUsers.Find(tblUser.UserID);

                if (tblUser == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                var Query = from a in db.tblUsers
                            where a.UserName == txtUserName_.Text && a.UserID != tblUser.UserID
                            select a;

                if (Query.Count() != 0)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrRepeat + "\n" + "نام کاربری تکراری می باشد", "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }
                                      
                tblUser.Name = txtName_.Text;
                tblUser.LastName = txtLastName_.Text;      
                tblUser.UserName = txtUserName_.Text;
                tblUser.PassWord = txtPassWord_.Text;  

                db.Entry(tblUser).State = EntityState.Modified;
                //db.Entry(tblPersonnel).Property(x => x).IsModified = true;
                db.Entry(tblUser).Property(x => x.Active).IsModified = false;        

                db.SaveChanges();

               
                New();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var fullErrorMessage = string.Join("\n", errorMessages);
                var exceptionMessage = string.Concat(ClsMessage.Error, ex.Message, " The validation errors are: ", fullErrorMessage);
                FarsiMessagbox.Show(exceptionMessage, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        void ChangeStatusRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                 tblUser = db.tblUsers.Find(tblUser.UserID);

                if (tblUser == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                if (tblUser.Active == 1) tblUser.Active = 0;
                else tblUser.Active = 1;


                db.tblUsers.Attach(tblUser);

                db.Entry(tblUser).Property(x => x.Active).IsModified = true; // $('#txtGoodsCode').val(),

                db.SaveChanges();
               
                New();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                var fullErrorMessage = string.Join("\n", errorMessages);
                var exceptionMessage = string.Concat(ClsMessage.Error, ex.Message, " The validation errors are: ", fullErrorMessage);
                FarsiMessagbox.Show(exceptionMessage, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (DbUpdateException ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }                                                                                         
        }

        void DeleteRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                 tblUser = db.tblUsers.Find(tblUser.UserID);
                      
                db.tblUsers.Remove(tblUser);
                db.SaveChanges();
                     
                New();
            }
            catch (DbUpdateException ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        void New()
        {
            tblUser.UserID = 0;
            SaveType = 1;
            BindGrid();
            ClsTools.ClearContent(pnlNewEdit);
            btnDelete.Enabled = false;
            btnChangeStatus.Enabled = false;                 
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            try
            {
                New();                                       
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClsTools.CheckValidation(pnlNewEdit) == false)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotRegEmptyValue, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                if (txtPassWord_.Text != txtRePassWord_.Text)
                {
                    FarsiMessagbox.Show("تکرار کلمه عبور با کلمه عبور  یکسان نمی باشد", "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }
                if (SaveType == 1)
                {
                    InsertRow();
                }
                else
                {
                    UpdateRow();
                }          
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
         
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (FarsiMessagbox.Show("آیا از حذف اطلاعات مورد نظر مطمئن هستید؟", "حذف", FMessageBoxButtons.YesNo, FMessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteRow();           
                }
            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tblUser.UserID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                BindRow();
                SaveType = 2;
                btnDelete.Enabled = true;
                btnChangeStatus.Enabled = true;                     
            }
            catch (Exception ex)
            {
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            ChangeStatusRow();
        }
       
        private void txtUserName__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9\b]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }
    
        private void txtPassWord__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9\b]"))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }
     
    }
}
