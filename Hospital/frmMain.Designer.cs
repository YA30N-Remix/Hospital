namespace Hospital
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.sideBar1 = new DevComponents.DotNetBar.SideBar();
            this.sideBarPanelItem3 = new DevComponents.DotNetBar.SideBarPanelItem();
            this.btnUsers = new DevComponents.DotNetBar.ButtonItem();
            this.btnOtagh = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaziresh = new DevComponents.DotNetBar.ButtonItem();
            this.btnTasviyeHeasb = new DevComponents.DotNetBar.ButtonItem();
            this.btnExit = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportReciveDocument = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportSendDocument = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportReciveCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportSendCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportFinancialState = new DevComponents.DotNetBar.ButtonItem();
            this.btnReportDemands = new DevComponents.DotNetBar.ButtonItem();
            this.btnPersonnelFunctionReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnPersonnelFunction = new DevComponents.DotNetBar.ButtonItem();
            this.btnChecks = new DevComponents.DotNetBar.ButtonItem();
            this.btnDocuments = new DevComponents.DotNetBar.ButtonItem();
            this.btnCostumerBuyList = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactors2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactors = new DevComponents.DotNetBar.ButtonItem();
            this.btnSettings = new DevComponents.DotNetBar.ButtonItem();
            this.btnBackUp = new DevComponents.DotNetBar.ButtonItem();
            this.imgBackGround = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.Controls.Add(this.sideBar1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEx2.Location = new System.Drawing.Point(534, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(250, 564);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 7;
            // 
            // sideBar1
            // 
            this.sideBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.sideBar1.BorderStyle = DevComponents.DotNetBar.eBorderType.None;
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar1.ExpandedPanel = this.sideBarPanelItem3;
            this.sideBar1.Font = new System.Drawing.Font("IRANSansWeb", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.Panels.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideBarPanelItem3});
            this.sideBar1.Size = new System.Drawing.Size(250, 564);
            this.sideBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.sideBar1.TabIndex = 5;
            this.sideBar1.Text = "sideBar1";
            // 
            // sideBarPanelItem3
            // 
            this.sideBarPanelItem3.FontBold = true;
            this.sideBarPanelItem3.Name = "sideBarPanelItem3";
            this.sideBarPanelItem3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUsers,
            this.btnOtagh,
            this.btnPaziresh,
            this.btnTasviyeHeasb,
            this.btnExit});
            this.sideBarPanelItem3.Text = "عملیات";
            // 
            // btnUsers
            // 
            this.btnUsers.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUsers.Image = global::Hospital.Properties.Resources.profle;
            this.btnUsers.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnUsers.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Text = "مدیریت کاربران";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnOtagh
            // 
            this.btnOtagh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnOtagh.Image = global::Hospital.Properties.Resources.contacts;
            this.btnOtagh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnOtagh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnOtagh.Name = "btnOtagh";
            this.btnOtagh.Text = "اتاق ها";
            this.btnOtagh.Click += new System.EventHandler(this.btnOtagh_Click);
            // 
            // btnPaziresh
            // 
            this.btnPaziresh.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPaziresh.Image = global::Hospital.Properties.Resources.swatches;
            this.btnPaziresh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnPaziresh.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPaziresh.Name = "btnPaziresh";
            this.btnPaziresh.Text = "پذیرش";
            this.btnPaziresh.Click += new System.EventHandler(this.btnPaziresh_Click);
            // 
            // btnTasviyeHeasb
            // 
            this.btnTasviyeHeasb.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTasviyeHeasb.Image = global::Hospital.Properties.Resources.money;
            this.btnTasviyeHeasb.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnTasviyeHeasb.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnTasviyeHeasb.Name = "btnTasviyeHeasb";
            this.btnTasviyeHeasb.Text = "تسویه حساب";
            this.btnTasviyeHeasb.Click += new System.EventHandler(this.btnTasviyeHeasb_Click);
            // 
            // btnExit
            // 
            this.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnExit.Image = global::Hospital.Properties.Resources.power;
            this.btnExit.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnExit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnExit.Name = "btnExit";
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReportReciveDocument
            // 
            this.btnReportReciveDocument.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportReciveDocument.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportReciveDocument.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportReciveDocument.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportReciveDocument.Name = "btnReportReciveDocument";
            this.btnReportReciveDocument.Text = "گزارشات سند دریافت";
            // 
            // btnReportSendDocument
            // 
            this.btnReportSendDocument.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportSendDocument.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportSendDocument.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportSendDocument.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportSendDocument.Name = "btnReportSendDocument";
            this.btnReportSendDocument.Text = "گزارشات سند پرداخت";
            // 
            // btnReportReciveCheck
            // 
            this.btnReportReciveCheck.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportReciveCheck.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportReciveCheck.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportReciveCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportReciveCheck.Name = "btnReportReciveCheck";
            this.btnReportReciveCheck.Text = "گزارشات چک دریافتی";
            // 
            // btnReportSendCheck
            // 
            this.btnReportSendCheck.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportSendCheck.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportSendCheck.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportSendCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportSendCheck.Name = "btnReportSendCheck";
            this.btnReportSendCheck.Text = "گزارشات چک پرداختی";
            // 
            // btnReportFinancialState
            // 
            this.btnReportFinancialState.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportFinancialState.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportFinancialState.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportFinancialState.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportFinancialState.Name = "btnReportFinancialState";
            this.btnReportFinancialState.Text = "صورت مالی";
            // 
            // btnReportDemands
            // 
            this.btnReportDemands.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnReportDemands.Image = global::Hospital.Properties.Resources.browser;
            this.btnReportDemands.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnReportDemands.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnReportDemands.Name = "btnReportDemands";
            this.btnReportDemands.Text = "گزارشات مطالبات";
            // 
            // btnPersonnelFunctionReport
            // 
            this.btnPersonnelFunctionReport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPersonnelFunctionReport.Image = global::Hospital.Properties.Resources.browser;
            this.btnPersonnelFunctionReport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnPersonnelFunctionReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnPersonnelFunctionReport.Name = "btnPersonnelFunctionReport";
            this.btnPersonnelFunctionReport.Text = "گزارشات کارکرد پرسنل";
            // 
            // btnPersonnelFunction
            // 
            this.btnPersonnelFunction.Name = "btnPersonnelFunction";
            // 
            // btnChecks
            // 
            this.btnChecks.Name = "btnChecks";
            // 
            // btnDocuments
            // 
            this.btnDocuments.Name = "btnDocuments";
            // 
            // btnCostumerBuyList
            // 
            this.btnCostumerBuyList.Name = "btnCostumerBuyList";
            // 
            // btnFactors2
            // 
            this.btnFactors2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnFactors2.Image = global::Hospital.Properties.Resources.bookshelf;
            this.btnFactors2.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFactors2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnFactors2.Name = "btnFactors2";
            this.btnFactors2.Text = "صدور فاکتور بازار و واسطه ای";
            // 
            // btnFactors
            // 
            this.btnFactors.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnFactors.Image = global::Hospital.Properties.Resources.bookshelf;
            this.btnFactors.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFactors.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnFactors.Name = "btnFactors";
            this.btnFactors.Text = "صدور فاکتور خانه دار و کارخانه";
            // 
            // btnSettings
            // 
            this.btnSettings.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSettings.Image = global::Hospital.Properties.Resources.tools;
            this.btnSettings.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSettings.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Text = "تنظیمات";
            // 
            // btnBackUp
            // 
            this.btnBackUp.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnBackUp.Image = global::Hospital.Properties.Resources.security;
            this.btnBackUp.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnBackUp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Text = "پشتیبان گیری";
            // 
            // imgBackGround
            // 
            this.imgBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBackGround.ErrorImage = null;
            this.imgBackGround.Image = global::Hospital.Properties.Resources.Mehr_Hospital_Gallery_22_1024x632;
            this.imgBackGround.InitialImage = null;
            this.imgBackGround.Location = new System.Drawing.Point(0, 0);
            this.imgBackGround.Name = "imgBackGround";
            this.imgBackGround.Size = new System.Drawing.Size(534, 564);
            this.imgBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBackGround.TabIndex = 9;
            this.imgBackGround.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(23, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(133, 32);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "lblUserName";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.imgBackGround);
            this.Controls.Add(this.panelEx2);
            this.Font = new System.Drawing.Font("IRANSansWeb", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "سیستم مدیریت بیمارستان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.SideBar sideBar1;
        private DevComponents.DotNetBar.ButtonItem btnPersonnelFunction;
        private DevComponents.DotNetBar.SideBarPanelItem sideBarPanelItem3;
        private DevComponents.DotNetBar.ButtonItem btnUsers;
        private System.Windows.Forms.PictureBox imgBackGround;
        private DevComponents.DotNetBar.ButtonItem btnCustomers;
        private DevComponents.DotNetBar.ButtonItem btnPaziresh;
        private DevComponents.DotNetBar.ButtonItem btnExit;
        private DevComponents.DotNetBar.ButtonItem btnChecks;
        private DevComponents.DotNetBar.ButtonItem btnSettings;
        private DevComponents.DotNetBar.ButtonItem btnBackUp;
        private DevComponents.DotNetBar.ButtonItem btnDocuments;
        private DevComponents.DotNetBar.ButtonItem btnReportReciveDocument;
        private DevComponents.DotNetBar.ButtonItem btnCostumerBuyList;
        private DevComponents.DotNetBar.ButtonItem btnFactors;
        private DevComponents.DotNetBar.ButtonItem btnFactors2;
        private DevComponents.DotNetBar.ButtonItem btnReportSendDocument;
        private DevComponents.DotNetBar.ButtonItem btnReportReciveCheck;
        private DevComponents.DotNetBar.ButtonItem btnReportSendCheck;
        private DevComponents.DotNetBar.ButtonItem btnReportFinancialState;
        private DevComponents.DotNetBar.ButtonItem btnTasviyeHeasb;
        private DevComponents.DotNetBar.ButtonItem btnReportDemands;
        private DevComponents.DotNetBar.ButtonItem btnPersonnelFunctionReport;
        private System.Windows.Forms.Label lblUserName;
        private DevComponents.DotNetBar.ButtonItem btnOtagh;
    }
}