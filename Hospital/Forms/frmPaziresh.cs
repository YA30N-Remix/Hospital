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
    public partial class frmPaziresh : Form
    {
        int SaveType = 1;
        public static int LoadTypeID = 0;
        public static tblPaziresh tblPaziresh = new tblPaziresh();
        public frmPaziresh()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblPazireshes
                            join b in db.tblPezeshks
                            on a.PezeshkID equals b.PezeshkID
                            join c in db.tblOtaghs
                            on a.OtaghID equals c.OtaghID
                            join d in db.tblBakhshes
                            on c.OtaghID equals d.BakshID
                            select new { a.PazireshID, NameBimar = a.NameBimar + " " + a.LastNameBimar, a.CodeMelliBimar, a.TarikhPaziresh, CodeOtagh = d.BakhshName + " - " + c.CodeOtagh, DoctorName = b.Name + " " + b.LastName };

                if (txtSearch.Text.Trim().Length != 0)
                {
                    Query = Query.Where(a => a.PazireshID.ToString().Contains(txtSearch.Text) ||
                    a.NameBimar.ToString().Contains(txtSearch.Text) ||
                    a.CodeMelliBimar.ToString().Contains(txtSearch.Text) ||
                    a.TarikhPaziresh.ToString().Contains(txtSearch.Text) ||
                    a.CodeOtagh.ToString().Contains(txtSearch.Text) ||
                    a.DoctorName.ToString().Contains(txtSearch.Text));
                }

                if (chkArshive.Checked != false || LoadTypeID == 1)
                {
                    Query = Query.Where(a => !(from aa in db.tblTasviyeHeasbs select ((int?)aa.PazireshID) ?? 0).Contains(a.PazireshID));
                }
                
                dgv.DataSource = Query.ToList();

                dgv.Columns[0].HeaderText = "کد پذیرش";
                dgv.Columns[0].Width = 120;
                dgv.Columns[1].HeaderText = "نام بیمار";
                dgv.Columns[1].Width = 140;
                dgv.Columns[2].HeaderText = "کد ملی بیمار";
                dgv.Columns[2].Width = 140;
                dgv.Columns[3].HeaderText = "تاریخ پذیرش";
                dgv.Columns[3].Width = 120;
                dgv.Columns[4].HeaderText = "اتاق";
                dgv.Columns[4].Width = 120;
                dgv.Columns[5].HeaderText = "نام پزشک";
                dgv.Columns[5].Width = 120;
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
                cmbBakhsh_.DataSource = null;
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblBakhshes
                            select new { a.BakshID, a.BakhshName };
                             
                cmbBakhsh_.DataSource = Query.ToList();

                cmbBakhsh_.ValueMember = "BakshID";
                cmbBakhsh_.DisplayMember = "BakhshName";
            }
            catch (Exception ex)
            {
                
            }
        }

        void BindCmbOtagh()
        {
            try
            {
                cmbOtagh_.DataSource = null;
                HospitalEntities db = new HospitalEntities();
                int BakshID = (int)cmbBakhsh_.SelectedValue;
                var Query = from a in db.tblOtaghs
                            where a.BakshID == BakshID
                            select new { a.OtaghID, a.CodeOtagh };
                                 
                cmbOtagh_.DataSource = Query.ToList();
                cmbOtagh_.DisplayMember = "CodeOtagh";
                cmbOtagh_.ValueMember = "OtaghID";

            }
            catch (Exception ex)
            {
                
            }
        }

        void BindCmbPezeshk()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblPezeshks
                            select new { a.PezeshkID, PezeshkName = a.Name + " " + a.LastName };
                         
                cmbPezeshk_.DataSource = Query.ToList();
                cmbPezeshk_.DisplayMember = "PezeshkName";
                cmbPezeshk_.ValueMember = "PezeshkID";

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

                var Query = from a in db.tblPazireshes
                            join b in db.tblOtaghs
                            on a.OtaghID equals b.OtaghID
                            where a.PazireshID == tblPaziresh.PazireshID
                            select new { a, b.BakshID };

                if (Query == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }
                tblPaziresh.NameBimar = Query.ToList().ElementAt(0).a.NameBimar;
                tblPaziresh.LastNameBimar = Query.ToList().ElementAt(0).a.LastNameBimar;
                tblPaziresh.CodeMelliBimar = Query.ToList().ElementAt(0).a.CodeMelliBimar;
                tblPaziresh.CodeBimeBimar = Query.ToList().ElementAt(0).a.CodeBimeBimar;
                tblPaziresh.PezeshkID = Query.ToList().ElementAt(0).a.PezeshkID;
                tblPaziresh.OtaghID = Query.ToList().ElementAt(0).a.OtaghID;

                txtName_.Text = tblPaziresh.NameBimar;
                txtLastName_.Text = tblPaziresh.LastNameBimar;
                txtCodeMelli_.Text = tblPaziresh.CodeMelliBimar.ToString();
                txtCodeBime.Text = tblPaziresh.CodeBimeBimar;
                cmbPezeshk_.SelectedValue = tblPaziresh.PezeshkID;
                cmbBakhsh_.SelectedValue = Query.ToList().ElementAt(0).BakshID;

                cmbOtagh_.SelectedValue = tblPaziresh.OtaghID;
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
                tblPaziresh tblPaziresh = new tblPaziresh();


                tblPaziresh.NameBimar = txtName_.Text;
                tblPaziresh.LastNameBimar = txtLastName_.Text;
                tblPaziresh.CodeMelliBimar = txtCodeMelli_.Text;
                tblPaziresh.CodeBimeBimar = txtCodeBime.Text;
                tblPaziresh.PezeshkID = (int)cmbPezeshk_.SelectedValue;
                tblPaziresh.OtaghID = (int)cmbOtagh_.SelectedValue;

                tblPaziresh.TarikhPaziresh = ClsTools.ShamsiDate();

                db.tblPazireshes.Add(tblPaziresh);
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
                tblPaziresh = db.tblPazireshes.Find(tblPaziresh.PazireshID);

                if (tblPaziresh == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                tblPaziresh.NameBimar = txtName_.Text;
                tblPaziresh.LastNameBimar = txtLastName_.Text;
                tblPaziresh.CodeMelliBimar = txtCodeMelli_.Text;
                tblPaziresh.CodeBimeBimar = txtCodeBime.Text;
                tblPaziresh.PezeshkID = (int)cmbPezeshk_.SelectedValue;
                tblPaziresh.OtaghID = (int)cmbOtagh_.SelectedValue;

                db.Entry(tblPaziresh).State = EntityState.Modified;
                //db.Entry(tblPersonnel).Property(x => x).IsModified = true;        
                db.Entry(tblPaziresh).Property(x => x.TarikhPaziresh).IsModified = false;

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
                tblPaziresh = db.tblPazireshes.Find(tblPaziresh.PazireshID);

                db.tblPazireshes.Remove(tblPaziresh);
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
            tblPaziresh = new tblPaziresh();
            SaveType = 1;
            BindGrid();
            ClsTools.ClearContent(pnlNewEdit);
            btnDelete.Enabled = false;
        }

        private void frmPaziresh_Load(object sender, EventArgs e)
        {
            try
            {
                New();
                if (LoadTypeID == 1)
                {
                    btnSelect.Visible = true;
                    chkArshive.Enabled = false;
                }
                else
                {
                    chkArshive.Enabled = true;
                }
            
                BindCmbPezeshk();
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
                tblPaziresh.PazireshID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
                BindRow();
                SaveType = 2;
                btnDelete.Enabled = true;
                if (LoadTypeID == 1) btnSelect.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (tblPaziresh.PazireshID == 0)
                {
                    FarsiMessagbox.Show(ClsMessage.Error + "\n" + "رکوردی انتخاب نشده است", "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }
                SaveType = 1;
                LoadTypeID = 0;
                this.Close();
            }
            catch (Exception)
            {

                
            }
        }

        private void chkArshive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception)
            {

                
            }
        }

        private void cmbBakhsh__SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCmbOtagh();
        }
    }
}
