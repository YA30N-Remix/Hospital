namespace Hospital.Forms
{
    partial class frmPaziresh
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
            this.chkArshive = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlNewEdit = new System.Windows.Forms.Panel();
            this.txtCodeMelli_ = new System.Windows.Forms.NumericUpDown();
            this.cmbOtagh_ = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbBakhsh_ = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodeBime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName_ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName_ = new System.Windows.Forms.TextBox();
            this.cmbPezeshk_ = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlNewEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeMelli_)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlGrid.Controls.Add(this.chkArshive);
            this.pnlGrid.Controls.Add(this.label8);
            this.pnlGrid.Controls.Add(this.txtSearch);
            this.pnlGrid.Controls.Add(this.dgv);
            this.pnlGrid.Location = new System.Drawing.Point(2, 187);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(857, 264);
            this.pnlGrid.TabIndex = 2;
            // 
            // chkArshive
            // 
            this.chkArshive.AutoSize = true;
            this.chkArshive.Checked = true;
            this.chkArshive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkArshive.Location = new System.Drawing.Point(421, 9);
            this.chkArshive.Name = "chkArshive";
            this.chkArshive.Size = new System.Drawing.Size(57, 26);
            this.chkArshive.TabIndex = 42;
            this.chkArshive.Text = "آرشیو";
            this.chkArshive.UseVisualStyleBackColor = true;
            this.chkArshive.CheckedChanged += new System.EventHandler(this.chkArshive_CheckedChanged);
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
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(2, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 45);
            this.panel1.TabIndex = 22;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Image = global::Hospital.Properties.Resources.check1;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(197, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 35);
            this.btnSelect.TabIndex = 29;
            this.btnSelect.Text = "انتخاب";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Visible = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Hospital.Properties.Resources.plus;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(479, 5);
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
            this.btnSave.Location = new System.Drawing.Point(385, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(291, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 35);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "پزشک";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(784, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "*";
            // 
            // pnlNewEdit
            // 
            this.pnlNewEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlNewEdit.Controls.Add(this.txtCodeMelli_);
            this.pnlNewEdit.Controls.Add(this.cmbOtagh_);
            this.pnlNewEdit.Controls.Add(this.label14);
            this.pnlNewEdit.Controls.Add(this.label15);
            this.pnlNewEdit.Controls.Add(this.cmbBakhsh_);
            this.pnlNewEdit.Controls.Add(this.label12);
            this.pnlNewEdit.Controls.Add(this.label13);
            this.pnlNewEdit.Controls.Add(this.label7);
            this.pnlNewEdit.Controls.Add(this.label11);
            this.pnlNewEdit.Controls.Add(this.txtCodeBime);
            this.pnlNewEdit.Controls.Add(this.label5);
            this.pnlNewEdit.Controls.Add(this.label6);
            this.pnlNewEdit.Controls.Add(this.label10);
            this.pnlNewEdit.Controls.Add(this.label2);
            this.pnlNewEdit.Controls.Add(this.label3);
            this.pnlNewEdit.Controls.Add(this.txtLastName_);
            this.pnlNewEdit.Controls.Add(this.label4);
            this.pnlNewEdit.Controls.Add(this.txtName_);
            this.pnlNewEdit.Controls.Add(this.cmbPezeshk_);
            this.pnlNewEdit.Controls.Add(this.label9);
            this.pnlNewEdit.Controls.Add(this.label1);
            this.pnlNewEdit.Location = new System.Drawing.Point(2, 2);
            this.pnlNewEdit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlNewEdit.Name = "pnlNewEdit";
            this.pnlNewEdit.Size = new System.Drawing.Size(857, 135);
            this.pnlNewEdit.TabIndex = 0;
            // 
            // txtCodeMelli_
            // 
            this.txtCodeMelli_.Location = new System.Drawing.Point(223, 35);
            this.txtCodeMelli_.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCodeMelli_.Name = "txtCodeMelli_";
            this.txtCodeMelli_.Size = new System.Drawing.Size(191, 29);
            this.txtCodeMelli_.TabIndex = 3;
            // 
            // cmbOtagh_
            // 
            this.cmbOtagh_.FormattingEnabled = true;
            this.cmbOtagh_.Location = new System.Drawing.Point(223, 97);
            this.cmbOtagh_.Name = "cmbOtagh_";
            this.cmbOtagh_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbOtagh_.Size = new System.Drawing.Size(191, 30);
            this.cmbOtagh_.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(361, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 22);
            this.label14.TabIndex = 89;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(383, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 22);
            this.label15.TabIndex = 88;
            this.label15.Text = "اتاق";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBakhsh_
            // 
            this.cmbBakhsh_.FormattingEnabled = true;
            this.cmbBakhsh_.Location = new System.Drawing.Point(440, 97);
            this.cmbBakhsh_.Name = "cmbBakhsh_";
            this.cmbBakhsh_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbBakhsh_.Size = new System.Drawing.Size(191, 30);
            this.cmbBakhsh_.TabIndex = 6;
            this.cmbBakhsh_.SelectedIndexChanged += new System.EventHandler(this.cmbBakhsh__SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(570, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 22);
            this.label12.TabIndex = 86;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 22);
            this.label13.TabIndex = 85;
            this.label13.Text = "بخش";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(102, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 22);
            this.label7.TabIndex = 84;
            this.label7.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 22);
            this.label11.TabIndex = 83;
            this.label11.Text = "کد بیمه بیمار";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodeBime
            // 
            this.txtCodeBime.Location = new System.Drawing.Point(10, 35);
            this.txtCodeBime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCodeBime.MaxLength = 100;
            this.txtCodeBime.Name = "txtCodeBime";
            this.txtCodeBime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeBime.Size = new System.Drawing.Size(191, 29);
            this.txtCodeBime.TabIndex = 4;
            this.txtCodeBime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(316, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 22);
            this.label5.TabIndex = 81;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 80;
            this.label6.Text = "کد ملی بیمار";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(532, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 22);
            this.label10.TabIndex = 78;
            this.label10.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(773, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 22);
            this.label2.TabIndex = 77;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 76;
            this.label3.Text = "نام خانوادگی";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName_
            // 
            this.txtLastName_.Location = new System.Drawing.Point(440, 35);
            this.txtLastName_.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLastName_.MaxLength = 100;
            this.txtLastName_.Name = "txtLastName_";
            this.txtLastName_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLastName_.Size = new System.Drawing.Size(191, 29);
            this.txtLastName_.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "نام بیمار";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName_
            // 
            this.txtName_.Location = new System.Drawing.Point(657, 35);
            this.txtName_.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName_.MaxLength = 50;
            this.txtName_.Name = "txtName_";
            this.txtName_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName_.Size = new System.Drawing.Size(191, 29);
            this.txtName_.TabIndex = 0;
            // 
            // cmbPezeshk_
            // 
            this.cmbPezeshk_.FormattingEnabled = true;
            this.cmbPezeshk_.Location = new System.Drawing.Point(657, 97);
            this.cmbPezeshk_.Name = "cmbPezeshk_";
            this.cmbPezeshk_.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbPezeshk_.Size = new System.Drawing.Size(191, 30);
            this.cmbPezeshk_.TabIndex = 5;
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
            // frmPaziresh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlNewEdit);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "frmPaziresh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پذیرش";
            this.Load += new System.EventHandler(this.frmPaziresh_Load);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlNewEdit.ResumeLayout(false);
            this.pnlNewEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeMelli_)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlNewEdit;
        private System.Windows.Forms.ComboBox cmbPezeshk_;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName_;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName_;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodeBime;
        private System.Windows.Forms.ComboBox cmbBakhsh_;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbOtagh_;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown txtCodeMelli_;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.CheckBox chkArshive;
    }
}