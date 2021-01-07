namespace Hospital
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVorud = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 78;
            this.label2.Text = "کلمه عبور :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(13, 103);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(308, 34);
            this.txtPassword.TabIndex = 75;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 77;
            this.label1.Text = "نام کاربری :";
            // 
            // btnVorud
            // 
            this.btnVorud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVorud.Image = global::Hospital.Properties.Resources.locked;
            this.btnVorud.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVorud.Location = new System.Drawing.Point(160, 163);
            this.btnVorud.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVorud.Name = "btnVorud";
            this.btnVorud.Size = new System.Drawing.Size(89, 34);
            this.btnVorud.TabIndex = 76;
            this.btnVorud.Text = "ورود";
            this.btnVorud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVorud.UseVisualStyleBackColor = true;
            this.btnVorud.Click += new System.EventHandler(this.btnVorud_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(13, 20);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(308, 34);
            this.txtUserName.TabIndex = 74;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(419, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVorud);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("IRANSansWeb", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود کاربران";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVorud;
        private System.Windows.Forms.TextBox txtUserName;
    }
}