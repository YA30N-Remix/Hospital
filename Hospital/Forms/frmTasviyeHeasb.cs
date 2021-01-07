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
    public partial class frmTasviyeHeasb : Form
    {
     
        int SaveType = 1;      
        public static tblTasviyeHeasb tblTasviyeHeasb = new tblTasviyeHeasb();
                       
        public frmTasviyeHeasb()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            try
            {
                HospitalEntities db = new HospitalEntities();
                var Query = from a in db.tblTasviyeHeasbs
                            join b in db.tblPazireshes on a.PazireshID equals b.PazireshID      
                            select new
                            {
                                a.TasviyeHeasbID,
                                NameBimar = b.NameBimar + " " + b.LastNameBimar,   
                                a.Mablagh,
                                a.TarikhTasviyeHeasb  
                            };

                if (txtSearch.Text.Trim().Length != 0)
                {
                    Query = Query.Where(a => a.TasviyeHeasbID.ToString().Contains(txtSearch.Text) || a.NameBimar.ToString().Contains(txtSearch.Text) ||
                    a.Mablagh.ToString().Contains(txtSearch.Text) || a.TarikhTasviyeHeasb.ToString().Contains(txtSearch.Text));
                }

                dgv.DataSource = Query.ToList();

                dgv.Columns[0].HeaderText = "کد تسویه حساب";
                dgv.Columns[0].Width = 120;
                dgv.Columns[1].HeaderText = "نام بیمار";
                dgv.Columns[1].Width = 120;
                dgv.Columns[2].HeaderText = "مبلغ";
                dgv.Columns[2].Width = 120;
                dgv.Columns[3].HeaderText = "تاریخ تسویه حساب";
                dgv.Columns[3].Width = 140;      

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
                 tblTasviyeHeasb = db.tblTasviyeHeasbs.Find(tblTasviyeHeasb.TasviyeHeasbID);
                if (tblTasviyeHeasb == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                frmPaziresh.tblPaziresh.PazireshID = tblTasviyeHeasb.PazireshID;
                      
                var QueryBimar = (from a in db.tblPazireshes
                                     where a.PazireshID == frmPaziresh.tblPaziresh.PazireshID
                                     select new { name = a.NameBimar + " " + a.LastNameBimar }).ToList();

                txtBimarName.Text = QueryBimar.ElementAt(0).name;       
                txtTarikhTasviyeHeasb_.Text = tblTasviyeHeasb.TarikhTasviyeHeasb;
                txtMablagh_.Text = tblTasviyeHeasb.Mablagh.ToString();     
                        
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
                tblTasviyeHeasb tblTasviyeHeasb = new tblTasviyeHeasb();
                                                
                tblTasviyeHeasb.PazireshID = frmPaziresh.tblPaziresh.PazireshID;
                 
                tblTasviyeHeasb.TarikhTasviyeHeasb = txtTarikhTasviyeHeasb_.MaskedTextProvider.ToDisplayString();
                    
                tblTasviyeHeasb.Mablagh = Convert.ToInt64(txtMablagh_.Text.Replace(",", "")) ;
      
                db.tblTasviyeHeasbs.Add(tblTasviyeHeasb);

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
                tblTasviyeHeasb = db.tblTasviyeHeasbs.Find(tblTasviyeHeasb.TasviyeHeasbID);

                if (tblTasviyeHeasb == null)
                {
                    FarsiMessagbox.Show(ClsMessage.ErrNotFound, "خطا", FMessageBoxButtons.Ok, FMessageBoxIcon.Error);
                    return;
                }

                tblTasviyeHeasb.PazireshID = frmPaziresh.tblPaziresh.PazireshID;
                tblTasviyeHeasb.TarikhTasviyeHeasb = txtTarikhTasviyeHeasb_.MaskedTextProvider.ToDisplayString();

                tblTasviyeHeasb.Mablagh = Convert.ToInt64(txtMablagh_.Text.Replace(",",""));
                                                                
                db.Entry(tblTasviyeHeasb).State = EntityState.Modified;
                //db.Entry(tblPersonnel).Property(x => x).IsModified = true;            

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
                 tblTasviyeHeasb = db.tblTasviyeHeasbs.Find(tblTasviyeHeasb.TasviyeHeasbID);
                 
                db.tblTasviyeHeasbs.Remove(tblTasviyeHeasb);
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
            SaveType = 1;
            BindGrid();

            frmPaziresh.tblPaziresh = new tblPaziresh();            
            ClsTools.ClearContent(pnlNewEdit);
            btnDelete.Enabled = false;
            txtTarikhTasviyeHeasb_.Text = ClsTools.ShamsiDate();
        }
        private void frmDocuments_Load(object sender, EventArgs e)
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
                if (ClsTools.CheckValidation(pnlNewEdit) == false || frmPaziresh.tblPaziresh.PazireshID == 0 )
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
                tblTasviyeHeasb.TasviyeHeasbID = (int) dgv.Rows[e.RowIndex].Cells[0].Value ;
                BindRow();
                SaveType = 2;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnSelectCustomers_Click(object sender, EventArgs e)
        {          
            frmPaziresh frmPaziresh = new frmPaziresh();
            frmPaziresh.LoadTypeID = 1;
            frmPaziresh.FormClosed += frmPaziresh_Closed;
            frmPaziresh.ShowDialog();
        }

        private void frmPaziresh_Closed(object sender, FormClosedEventArgs e)
        {
            try
            {
                txtBimarName.Text = frmPaziresh.tblPaziresh.NameBimar + " " + frmPaziresh.tblPaziresh.LastNameBimar;
                frmPaziresh.LoadTypeID = 0;
            }
            catch (Exception)
            {
            }
        }
                
 
        private void txtPrice__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (((TextBox)sender).Text != String.Empty)
                {
                    ((TextBox)sender).Text = String.Format("{0:N0}", double.Parse(((TextBox)sender).Text.Replace(",", "")));
                    ((TextBox)sender).Select(((TextBox)sender).TextLength, 0);
                }
            }
            catch (Exception)
            {
            }
        }
           
         
    }
}
