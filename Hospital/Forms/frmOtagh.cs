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
    public partial class frmOtagh : Form
    {
    
        int SaveType = 1;
        public static tblOtagh tblOtagh = new tblOtagh();
        public frmOtagh()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblOtaghs
                            join b in db.tblBakhshes
                            on a.BakshID equals b.BakshID
                            select new { a.OtaghID, a.CodeOtagh, b.BakhshName};
                    

                if (txtSearch.Text.Trim().Length != 0)
                {
                    Query = Query.Where(a => a.OtaghID.ToString().Contains(txtSearch.Text) || a.CodeOtagh.Contains(txtSearch.Text) || a.BakhshName.Contains(txtSearch.Text));
                }

                dgv.DataSource = Query.ToList();
                      
                dgv.Columns[0].HeaderText = "کد اتاق";
                dgv.Columns[0].Width = 100;    
                dgv.Columns[1].HeaderText = "شماره اتاق";
                dgv.Columns[1].Width = 100;
                dgv.Columns[2].HeaderText = "بخش";
                dgv.Columns[2].Width = 100;       

            }
            catch (Exception ex)
            {
                FarsiMessagbox.Show(ClsMessage.Error + "\n" + ex.Message.ToString(), "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
            }
        }

        void BindCmbBakhsh()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblBakhshes
                            select new { a.BakshID,  a.BakhshName};

               
              cmbBakhsh_.DataSource = Query.ToList();

                cmbBakhsh_.DisplayMember = "BakhshName";
                cmbBakhsh_.ValueMember = "BakshID";
            }
            catch (Exception ex)
            {                  
            }
        }

        void BindRow()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                tblOtagh = db.tblOtaghs.Find(tblOtagh.OtaghID);
                if (tblOtagh == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                txtCodeOtagh_.Text = tblOtagh.CodeOtagh;
                cmbBakhsh_.SelectedValue = tblOtagh.BakshID;
                 

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
                  tblOtagh = new tblOtagh();
                                       
                tblOtagh.CodeOtagh = txtCodeOtagh_.Text;
                tblOtagh.BakshID = (int)cmbBakhsh_.SelectedValue;
                                 
                db.tblOtaghs.Add(tblOtagh);
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
                  tblOtagh = db.tblOtaghs.Find(tblOtagh.OtaghID);

                if (tblOtagh == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                tblOtagh.CodeOtagh = txtCodeOtagh_.Text;
                tblOtagh.BakshID = (int)cmbBakhsh_.SelectedValue;

                db.tblOtaghs.Attach(tblOtagh);
                db.Entry(tblOtagh).State = EntityState.Modified;
         
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
                  tblOtagh = db.tblOtaghs.Find(tblOtagh.OtaghID);
                      
                db.tblOtaghs.Remove(tblOtagh);
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
            tblOtagh = new tblOtagh();
            SaveType = 1;
            BindGrid();
            ClsTools.ClearContent(pnlNewEdit);
            btnDelete.Enabled = false;      
        }

        private void frmOtagh_Load(object sender, EventArgs e)
        {
            try
            {
                New();
                BindCmbBakhsh();
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
                tblOtagh.OtaghID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                BindRow();
                SaveType = 2;
                btnDelete.Enabled = true;                        
            }
            catch (Exception ex)
            {
            }
        }
      
                 
    }
}
