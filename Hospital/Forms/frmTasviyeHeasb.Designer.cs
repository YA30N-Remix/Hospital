namespace Hospital.Forms
{
    partial class frmTasviyeHeasb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlNewEdit = new System.Windows.Forms.Panel();
            this.txtMablagh_ = new System.Windows.Forms.TextBox();
            this.txtBimarName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarikhTasviyeHeasb_ = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSelectBimar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNewEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlGrid.Controls.Add(this.label8);
            this.pnlGrid.Controls.Add(this.txtSearch);
            this.pnlGrid.Controls.Add(this.dgv);
            this.pnlGrid.Location = new System.Drawing.Point(2, 121);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(857, 264);
            this.pnlGrid.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "جستجوی سریع";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(567, 6);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(191, 29);
            this.txtSearch.TabIndex = 31;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv.Location = new System.Drawing.Point(3, 42);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv.Size = new System.Drawing.Size(851, 217);
            this.dgv.TabIndex = 41;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(2, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 45);
            this.panel1.TabIndex = 22;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Hospital.Properties.Resources.plus;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(474, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 35);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "جدید";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::Hospital.Properties.Resources.memorycard;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(380, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 35);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "ذخیره";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Hospital.Properties.Resources.Delete1;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(286, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(141, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 22);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // pnlNewEdit
            // 
            this.pnlNewEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlNewEdit.Controls.Add(this.txtMablagh_);
            this.pnlNewEdit.Controls.Add(this.txtBimarName);
            this.pnlNewEdit.Controls.Add(this.label18);
            this.pnlNewEdit.Controls.Add(this.label5);
            this.pnlNewEdit.Controls.Add(this.label3);
            this.pnlNewEdit.Controls.Add(this.txtTarikhTasviyeHeasb_);
            this.pnlNewEdit.Controls.Add(this.label12);
            this.pnlNewEdit.Controls.Add(this.btnSelectBimar);
            this.pnlNewEdit.Controls.Add(this.label7);
            this.pnlNewEdit.Controls.Add(this.label10);
            this.pnlNewEdit.Controls.Add(this.label2);
            this.pnlNewEdit.Location = new System.Drawing.Point(2, 2);
            this.pnlNewEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNewEdit.Name = "pnlNewEdit";
            this.pnlNewEdit.Size = new System.Drawing.Size(857, 69);
            this.pnlNewEdit.TabIndex = 0;
            // 
            // txtMablagh_
            // 
            this.txtMablagh_.Location = new System.Drawing.Point(223, 33);
            this.txtMablagh_.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMablagh_.MaxLength = 50;
            this.txtMablagh_.Name = "txtMablagh_";
            this.txtMablagh_.Size = new System.Drawing.Size(191, 29);
            this.txtMablagh_.TabIndex = 2;
            this.txtMablagh_.TextChanged += new System.EventHandler(this.txtPrice__TextChanged);
            // 
            // txtBimarName
            // 
            this.txtBimarName.Location = new System.Drawing.Point(440, 32);
            this.txtBimarName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBimarName.MaxLength = 50;
            this.txtBimarName.Name = "txtBimarName";
            this.txtBimarName.ReadOnly = true;
            this.txtBimarName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBimarName.Size = new System.Drawing.Size(191, 29);
            this.txtBimarName.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(578, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 22);
            this.label18.TabIndex = 97;
            this.label18.Text = "نام بیمار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(358, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 89;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "مبلغ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTarikhTasviyeHeasb_
            // 
            this.txtTarikhTasviyeHeasb_.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.txtTarikhTasviyeHeasb_.Location = new System.Drawing.Point(10, 32);
            this.txtTarikhTasviyeHeasb_.Mask = "0000/00/00";
            this.txtTarikhTasviyeHeasb_.Name = "txtTarikhTasviyeHeasb_";
            this.txtTarikhTasviyeHeasb_.Size = new System.Drawing.Size(191, 29);
            this.txtTarikhTasviyeHeasb_.TabIndex = 3;
            this.txtTarikhTasviyeHeasb_.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtTarikhTasviyeHeasb_.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(752, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 22);
            this.label12.TabIndex = 63;
            this.label12.Text = "*";
            // 
            // btnSelectBimar
            // 
            this.btnSelectBimar.Location = new System.Drawing.Point(657, 32);
            this.btnSelectBimar.Name = "btnSelectBimar";
            this.btnSelectBimar.Size = new System.Drawing.Size(191, 29);
            this.btnSelectBimar.TabIndex = 0;
            this.btnSelectBimar.Text = "انتخاب بیمار";
            this.btnSelectBimar.UseVisualStyleBackColor = true;
            this.btnSelectBimar.Click += new System.EventHandler(this.btnSelectCustomers_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "انتخاب بیمار";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "تاریخ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "ویرایش";
            this.dataGridViewImageColumn1.Image = global::Hospital.Properties.Resources.compose1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "حذف";
            this.dataGridViewImageColumn2.Image = global::Hospital.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmTasviyeHeasb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlNewEdit);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frmTasviyeHeasb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسویه حساب";
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlNewEdit.ResumeLayout(false);
            this.pnlNewEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlNewEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectBimar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBimarName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMablagh_;
        private System.Windows.Forms.MaskedTextBox txtTarikhTasviyeHeasb_;
        private System.Windows.Forms.Label label2;
    }
}