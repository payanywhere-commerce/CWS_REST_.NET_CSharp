namespace SampleCode
{
    partial class SampleCodeREST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleCodeREST));
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdSignOnWithToken = new System.Windows.Forms.Button();
            this.lnkRetrieveServiceInformation = new System.Windows.Forms.LinkLabel();
            this.lnkManageApplicationData = new System.Windows.Forms.LinkLabel();
            this.lnkSignOnWithToken = new System.Windows.Forms.LinkLabel();
            this.chkStep2 = new System.Windows.Forms.CheckBox();
            this.chkStep3 = new System.Windows.Forms.CheckBox();
            this.chkStep1 = new System.Windows.Forms.CheckBox();
            this.cmdRetrieveServiceInformation = new System.Windows.Forms.Button();
            this.cmdPOST = new System.Windows.Forms.Button();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSendREST = new System.Windows.Forms.GroupBox();
            this.txtReplaceInURLWith = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReplaceInURL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdClearRequest = new System.Windows.Forms.Button();
            this.chkAlwaysCheckSessionToken = new System.Windows.Forms.CheckBox();
            this.cmdClearResponse = new System.Windows.Forms.Button();
            this.lnkMoreAboutREST = new System.Windows.Forms.LinkLabel();
            this.cboActionOrMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboServiceIds = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lnkManageMerchantProfiles = new System.Windows.Forms.LinkLabel();
            this.lblIsProfileInitialized = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmdPerformMerchantProfileAction = new System.Windows.Forms.Button();
            this.cboMerchantProfileAction = new System.Windows.Forms.ComboBox();
            this.cboAvailableProfiles = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtApplicationProfileId = new System.Windows.Forms.TextBox();
            this.cboApplicationDataAction = new System.Windows.Forms.ComboBox();
            this.cmdManageApplicationData = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TabControl();
            this.tbServiceInformation = new System.Windows.Forms.TabPage();
            this.CboWorkflowId = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtServiceKeyValue = new System.Windows.Forms.TextBox();
            this.lblServiceKey = new System.Windows.Forms.Label();
            this.ChkUseJsonInstead = new System.Windows.Forms.CheckBox();
            this.ChkUseCertEndpoint = new System.Windows.Forms.CheckBox();
            this.CboPTLSVersion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtLoadIdentityToken = new System.Windows.Forms.TextBox();
            this.tbTransactionProcessing = new System.Windows.Forms.TabPage();
            this.TxtSvcId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RTxtSummary = new System.Windows.Forms.RichTextBox();
            this.CmdGenerateTCSamples = new System.Windows.Forms.Button();
            this.CmdGenerateHCSamples = new System.Windows.Forms.Button();
            this.TxtAltWorkFlowId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ChkProcessAsMagensa = new System.Windows.Forms.CheckBox();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmdProcess = new System.Windows.Forms.Button();
            this.CboProcessString = new System.Windows.Forms.ComboBox();
            this.ChkProcessAsAuthorizeAndCaptureString = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtConfigurationValues = new System.Windows.Forms.TextBox();
            this.TbTMS = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpEndTimeTMS = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTimeTMS = new System.Windows.Forms.DateTimePicker();
            this.ChkLstTMSFunctions = new System.Windows.Forms.CheckedListBox();
            this.TxtTransactionId = new System.Windows.Forms.TextBox();
            this.TmsQuery = new System.Windows.Forms.Button();
            this.ChkShowRequestModal = new System.Windows.Forms.CheckBox();
            this.CboIndustryType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ChkSaveDeleteApplicationData = new System.Windows.Forms.CheckBox();
            this.grpSendREST.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tbMain.SuspendLayout();
            this.tbServiceInformation.SuspendLayout();
            this.tbTransactionProcessing.SuspendLayout();
            this.TbTMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtResponse.ForeColor = System.Drawing.SystemColors.Window;
            this.txtResponse.Location = new System.Drawing.Point(6, 278);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(764, 158);
            this.txtResponse.TabIndex = 2;
            this.txtResponse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResponse_KeyDown);
            // 
            // cmdSignOnWithToken
            // 
            this.cmdSignOnWithToken.Location = new System.Drawing.Point(8, 39);
            this.cmdSignOnWithToken.Name = "cmdSignOnWithToken";
            this.cmdSignOnWithToken.Size = new System.Drawing.Size(218, 23);
            this.cmdSignOnWithToken.TabIndex = 3;
            this.cmdSignOnWithToken.Text = "Step 1: Sign On With Token";
            this.cmdSignOnWithToken.UseVisualStyleBackColor = true;
            this.cmdSignOnWithToken.Click += new System.EventHandler(this.cmdSignOnWithToken_Click);
            // 
            // lnkRetrieveServiceInformation
            // 
            this.lnkRetrieveServiceInformation.AutoSize = true;
            this.lnkRetrieveServiceInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkRetrieveServiceInformation.Image = ((System.Drawing.Image)(resources.GetObject("lnkRetrieveServiceInformation.Image")));
            this.lnkRetrieveServiceInformation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lnkRetrieveServiceInformation.Location = new System.Drawing.Point(648, 99);
            this.lnkRetrieveServiceInformation.Margin = new System.Windows.Forms.Padding(0);
            this.lnkRetrieveServiceInformation.MinimumSize = new System.Drawing.Size(20, 20);
            this.lnkRetrieveServiceInformation.Name = "lnkRetrieveServiceInformation";
            this.lnkRetrieveServiceInformation.Size = new System.Drawing.Size(20, 20);
            this.lnkRetrieveServiceInformation.TabIndex = 132;
            this.lnkRetrieveServiceInformation.Tag = "Learn more about \"Sign On\"";
            this.lnkRetrieveServiceInformation.Click += new System.EventHandler(this.lnkRetrieveServiceInformation_Click);
            // 
            // lnkManageApplicationData
            // 
            this.lnkManageApplicationData.AutoSize = true;
            this.lnkManageApplicationData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkManageApplicationData.Image = ((System.Drawing.Image)(resources.GetObject("lnkManageApplicationData.Image")));
            this.lnkManageApplicationData.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lnkManageApplicationData.Location = new System.Drawing.Point(648, 70);
            this.lnkManageApplicationData.Margin = new System.Windows.Forms.Padding(0);
            this.lnkManageApplicationData.MinimumSize = new System.Drawing.Size(20, 20);
            this.lnkManageApplicationData.Name = "lnkManageApplicationData";
            this.lnkManageApplicationData.Size = new System.Drawing.Size(20, 20);
            this.lnkManageApplicationData.TabIndex = 131;
            this.lnkManageApplicationData.Tag = "Learn more about \"Sign On\"";
            this.lnkManageApplicationData.Click += new System.EventHandler(this.lnkManageApplicationData_Click);
            // 
            // lnkSignOnWithToken
            // 
            this.lnkSignOnWithToken.AutoSize = true;
            this.lnkSignOnWithToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSignOnWithToken.Image = ((System.Drawing.Image)(resources.GetObject("lnkSignOnWithToken.Image")));
            this.lnkSignOnWithToken.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lnkSignOnWithToken.Location = new System.Drawing.Point(648, 40);
            this.lnkSignOnWithToken.Margin = new System.Windows.Forms.Padding(0);
            this.lnkSignOnWithToken.MinimumSize = new System.Drawing.Size(20, 20);
            this.lnkSignOnWithToken.Name = "lnkSignOnWithToken";
            this.lnkSignOnWithToken.Size = new System.Drawing.Size(20, 20);
            this.lnkSignOnWithToken.TabIndex = 130;
            this.lnkSignOnWithToken.Tag = "Learn more about \"Sign On\"";
            this.lnkSignOnWithToken.Click += new System.EventHandler(this.lnkSignOnWithToken_Click);
            // 
            // chkStep2
            // 
            this.chkStep2.AutoSize = true;
            this.chkStep2.Location = new System.Drawing.Point(476, 73);
            this.chkStep2.Name = "chkStep2";
            this.chkStep2.Size = new System.Drawing.Size(162, 17);
            this.chkStep2.TabIndex = 129;
            this.chkStep2.Text = "ApplicationProfileId Obtained";
            this.chkStep2.UseVisualStyleBackColor = true;
            // 
            // chkStep3
            // 
            this.chkStep3.AutoSize = true;
            this.chkStep3.Location = new System.Drawing.Point(476, 102);
            this.chkStep3.Name = "chkStep3";
            this.chkStep3.Size = new System.Drawing.Size(128, 17);
            this.chkStep3.TabIndex = 128;
            this.chkStep3.Text = "ServiceId(s) Obtained";
            this.chkStep3.UseVisualStyleBackColor = true;
            // 
            // chkStep1
            // 
            this.chkStep1.AutoSize = true;
            this.chkStep1.Location = new System.Drawing.Point(476, 43);
            this.chkStep1.Name = "chkStep1";
            this.chkStep1.Size = new System.Drawing.Size(143, 17);
            this.chkStep1.TabIndex = 127;
            this.chkStep1.Text = "Session Token Obtained";
            this.chkStep1.UseVisualStyleBackColor = true;
            // 
            // cmdRetrieveServiceInformation
            // 
            this.cmdRetrieveServiceInformation.Enabled = false;
            this.cmdRetrieveServiceInformation.Location = new System.Drawing.Point(8, 97);
            this.cmdRetrieveServiceInformation.Name = "cmdRetrieveServiceInformation";
            this.cmdRetrieveServiceInformation.Size = new System.Drawing.Size(218, 23);
            this.cmdRetrieveServiceInformation.TabIndex = 125;
            this.cmdRetrieveServiceInformation.Text = "Step 3: Retrieving Service Information";
            this.cmdRetrieveServiceInformation.UseVisualStyleBackColor = true;
            this.cmdRetrieveServiceInformation.Click += new System.EventHandler(this.cmdRetrieveServiceInformation_Click);
            // 
            // cmdPOST
            // 
            this.cmdPOST.Location = new System.Drawing.Point(6, 19);
            this.cmdPOST.Name = "cmdPOST";
            this.cmdPOST.Size = new System.Drawing.Size(75, 23);
            this.cmdPOST.TabIndex = 0;
            this.cmdPOST.Text = "POST";
            this.cmdPOST.UseVisualStyleBackColor = true;
            this.cmdPOST.Click += new System.EventHandler(this.cmdPOST_Click);
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRequest.Location = new System.Drawing.Point(6, 88);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(764, 158);
            this.txtRequest.TabIndex = 1;
            this.txtRequest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequest_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "Request (Document, Body)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 134;
            this.label2.Text = "Response";
            // 
            // grpSendREST
            // 
            this.grpSendREST.Controls.Add(this.txtReplaceInURLWith);
            this.grpSendREST.Controls.Add(this.label7);
            this.grpSendREST.Controls.Add(this.txtReplaceInURL);
            this.grpSendREST.Controls.Add(this.label6);
            this.grpSendREST.Controls.Add(this.cmdClearRequest);
            this.grpSendREST.Controls.Add(this.chkAlwaysCheckSessionToken);
            this.grpSendREST.Controls.Add(this.cmdClearResponse);
            this.grpSendREST.Controls.Add(this.lnkMoreAboutREST);
            this.grpSendREST.Controls.Add(this.cboActionOrMethod);
            this.grpSendREST.Controls.Add(this.label4);
            this.grpSendREST.Controls.Add(this.txtUrl);
            this.grpSendREST.Controls.Add(this.label3);
            this.grpSendREST.Controls.Add(this.cmdPOST);
            this.grpSendREST.Controls.Add(this.label2);
            this.grpSendREST.Controls.Add(this.txtRequest);
            this.grpSendREST.Controls.Add(this.label1);
            this.grpSendREST.Controls.Add(this.txtResponse);
            this.grpSendREST.Location = new System.Drawing.Point(12, 354);
            this.grpSendREST.Name = "grpSendREST";
            this.grpSendREST.Size = new System.Drawing.Size(779, 442);
            this.grpSendREST.TabIndex = 135;
            this.grpSendREST.TabStop = false;
            this.grpSendREST.Text = "Send REST";
            // 
            // txtReplaceInURLWith
            // 
            this.txtReplaceInURLWith.Location = new System.Drawing.Point(389, 43);
            this.txtReplaceInURLWith.Name = "txtReplaceInURLWith";
            this.txtReplaceInURLWith.Size = new System.Drawing.Size(110, 20);
            this.txtReplaceInURLWith.TabIndex = 147;
            this.txtReplaceInURLWith.Text = "2.0.17";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 146;
            this.label7.Text = "With";
            // 
            // txtReplaceInURL
            // 
            this.txtReplaceInURL.Location = new System.Drawing.Point(236, 43);
            this.txtReplaceInURL.Name = "txtReplaceInURL";
            this.txtReplaceInURL.Size = new System.Drawing.Size(110, 20);
            this.txtReplaceInURL.TabIndex = 145;
            this.txtReplaceInURL.Text = "x.xx.x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "Replace in Url";
            // 
            // cmdClearRequest
            // 
            this.cmdClearRequest.BackColor = System.Drawing.Color.Olive;
            this.cmdClearRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearRequest.Location = new System.Drawing.Point(653, 64);
            this.cmdClearRequest.Name = "cmdClearRequest";
            this.cmdClearRequest.Size = new System.Drawing.Size(117, 20);
            this.cmdClearRequest.TabIndex = 143;
            this.cmdClearRequest.Text = "Clear Request";
            this.cmdClearRequest.UseVisualStyleBackColor = false;
            this.cmdClearRequest.Click += new System.EventHandler(this.cmdClearRequest_Click);
            // 
            // chkAlwaysCheckSessionToken
            // 
            this.chkAlwaysCheckSessionToken.AutoSize = true;
            this.chkAlwaysCheckSessionToken.Checked = true;
            this.chkAlwaysCheckSessionToken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysCheckSessionToken.Location = new System.Drawing.Point(352, 68);
            this.chkAlwaysCheckSessionToken.Name = "chkAlwaysCheckSessionToken";
            this.chkAlwaysCheckSessionToken.Size = new System.Drawing.Size(167, 17);
            this.chkAlwaysCheckSessionToken.TabIndex = 140;
            this.chkAlwaysCheckSessionToken.Text = "Always Check Session Token";
            this.chkAlwaysCheckSessionToken.UseVisualStyleBackColor = true;
            // 
            // cmdClearResponse
            // 
            this.cmdClearResponse.BackColor = System.Drawing.Color.Olive;
            this.cmdClearResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClearResponse.Location = new System.Drawing.Point(653, 250);
            this.cmdClearResponse.Name = "cmdClearResponse";
            this.cmdClearResponse.Size = new System.Drawing.Size(117, 20);
            this.cmdClearResponse.TabIndex = 139;
            this.cmdClearResponse.Text = "Clear Response";
            this.cmdClearResponse.UseVisualStyleBackColor = false;
            this.cmdClearResponse.Click += new System.EventHandler(this.cmdClearResponse_Click);
            // 
            // lnkMoreAboutREST
            // 
            this.lnkMoreAboutREST.AutoSize = true;
            this.lnkMoreAboutREST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkMoreAboutREST.Image = ((System.Drawing.Image)(resources.GetObject("lnkMoreAboutREST.Image")));
            this.lnkMoreAboutREST.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lnkMoreAboutREST.Location = new System.Drawing.Point(84, 19);
            this.lnkMoreAboutREST.Margin = new System.Windows.Forms.Padding(0);
            this.lnkMoreAboutREST.MinimumSize = new System.Drawing.Size(20, 20);
            this.lnkMoreAboutREST.Name = "lnkMoreAboutREST";
            this.lnkMoreAboutREST.Size = new System.Drawing.Size(20, 20);
            this.lnkMoreAboutREST.TabIndex = 136;
            this.lnkMoreAboutREST.Tag = "Learn more about \"REST\"";
            this.lnkMoreAboutREST.Click += new System.EventHandler(this.lnkMoreAboutREST_Click);
            // 
            // cboActionOrMethod
            // 
            this.cboActionOrMethod.FormattingEnabled = true;
            this.cboActionOrMethod.Items.AddRange(new object[] {
            "GET",
            "POST",
            "PUT",
            "DELETE"});
            this.cboActionOrMethod.Location = new System.Drawing.Point(236, 65);
            this.cboActionOrMethod.Name = "cboActionOrMethod";
            this.cboActionOrMethod.Size = new System.Drawing.Size(109, 21);
            this.cboActionOrMethod.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 137;
            this.label4.Text = "Action (Method)";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(174, 21);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(472, 20);
            this.txtUrl.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 135;
            this.label3.Text = "Url";
            // 
            // cboServiceIds
            // 
            this.cboServiceIds.FormattingEnabled = true;
            this.cboServiceIds.Location = new System.Drawing.Point(8, 140);
            this.cboServiceIds.Name = "cboServiceIds";
            this.cboServiceIds.Size = new System.Drawing.Size(218, 21);
            this.cboServiceIds.TabIndex = 137;
            this.cboServiceIds.SelectedIndexChanged += new System.EventHandler(this.cboServiceIds_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 138;
            this.label8.Text = "Available Services";
            // 
            // lnkManageMerchantProfiles
            // 
            this.lnkManageMerchantProfiles.AutoSize = true;
            this.lnkManageMerchantProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkManageMerchantProfiles.Image = ((System.Drawing.Image)(resources.GetObject("lnkManageMerchantProfiles.Image")));
            this.lnkManageMerchantProfiles.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lnkManageMerchantProfiles.Location = new System.Drawing.Point(648, 177);
            this.lnkManageMerchantProfiles.Margin = new System.Windows.Forms.Padding(0);
            this.lnkManageMerchantProfiles.MinimumSize = new System.Drawing.Size(20, 20);
            this.lnkManageMerchantProfiles.Name = "lnkManageMerchantProfiles";
            this.lnkManageMerchantProfiles.Size = new System.Drawing.Size(20, 20);
            this.lnkManageMerchantProfiles.TabIndex = 143;
            this.lnkManageMerchantProfiles.Tag = "Learn more about \"Sign On\"";
            this.lnkManageMerchantProfiles.Click += new System.EventHandler(this.lnkManageMerchantProfiles_Click);
            // 
            // lblIsProfileInitialized
            // 
            this.lblIsProfileInitialized.AutoSize = true;
            this.lblIsProfileInitialized.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsProfileInitialized.ForeColor = System.Drawing.Color.Green;
            this.lblIsProfileInitialized.Location = new System.Drawing.Point(233, 181);
            this.lblIsProfileInitialized.Name = "lblIsProfileInitialized";
            this.lblIsProfileInitialized.Size = new System.Drawing.Size(0, 15);
            this.lblIsProfileInitialized.TabIndex = 142;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmdPerformMerchantProfileAction);
            this.groupBox4.Controls.Add(this.cboMerchantProfileAction);
            this.groupBox4.Controls.Add(this.cboAvailableProfiles);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(8, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 109);
            this.groupBox4.TabIndex = 141;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4: Manage Merchant Profiles";
            // 
            // cmdPerformMerchantProfileAction
            // 
            this.cmdPerformMerchantProfileAction.Enabled = false;
            this.cmdPerformMerchantProfileAction.Location = new System.Drawing.Point(228, 58);
            this.cmdPerformMerchantProfileAction.Name = "cmdPerformMerchantProfileAction";
            this.cmdPerformMerchantProfileAction.Size = new System.Drawing.Size(93, 23);
            this.cmdPerformMerchantProfileAction.TabIndex = 150;
            this.cmdPerformMerchantProfileAction.Text = "Perform Action";
            this.cmdPerformMerchantProfileAction.UseVisualStyleBackColor = true;
            this.cmdPerformMerchantProfileAction.Click += new System.EventHandler(this.cmdPerformMerchantProfileAction_Click);
            // 
            // cboMerchantProfileAction
            // 
            this.cboMerchantProfileAction.FormattingEnabled = true;
            this.cboMerchantProfileAction.Location = new System.Drawing.Point(6, 60);
            this.cboMerchantProfileAction.Name = "cboMerchantProfileAction";
            this.cboMerchantProfileAction.Size = new System.Drawing.Size(216, 21);
            this.cboMerchantProfileAction.TabIndex = 149;
            // 
            // cboAvailableProfiles
            // 
            this.cboAvailableProfiles.FormattingEnabled = true;
            this.cboAvailableProfiles.Location = new System.Drawing.Point(6, 33);
            this.cboAvailableProfiles.Name = "cboAvailableProfiles";
            this.cboAvailableProfiles.Size = new System.Drawing.Size(218, 21);
            this.cboAvailableProfiles.TabIndex = 139;
            this.cboAvailableProfiles.SelectedIndexChanged += new System.EventHandler(this.cboAvailableProfiles_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(528, 13);
            this.label11.TabIndex = 140;
            this.label11.Text = "Available Profile(s) -- To add a new profile type in the name and select the acti" +
                "on below \"Save Merchant Data\"";
            // 
            // txtApplicationProfileId
            // 
            this.txtApplicationProfileId.Location = new System.Drawing.Point(417, 70);
            this.txtApplicationProfileId.Name = "txtApplicationProfileId";
            this.txtApplicationProfileId.Size = new System.Drawing.Size(53, 20);
            this.txtApplicationProfileId.TabIndex = 145;
            // 
            // cboApplicationDataAction
            // 
            this.cboApplicationDataAction.FormattingEnabled = true;
            this.cboApplicationDataAction.Location = new System.Drawing.Point(232, 70);
            this.cboApplicationDataAction.Name = "cboApplicationDataAction";
            this.cboApplicationDataAction.Size = new System.Drawing.Size(179, 21);
            this.cboApplicationDataAction.TabIndex = 146;
            // 
            // cmdManageApplicationData
            // 
            this.cmdManageApplicationData.Enabled = false;
            this.cmdManageApplicationData.Location = new System.Drawing.Point(8, 68);
            this.cmdManageApplicationData.Name = "cmdManageApplicationData";
            this.cmdManageApplicationData.Size = new System.Drawing.Size(218, 23);
            this.cmdManageApplicationData.TabIndex = 147;
            this.cmdManageApplicationData.Text = "Step 2: Manage Application Data";
            this.cmdManageApplicationData.UseVisualStyleBackColor = true;
            this.cmdManageApplicationData.Click += new System.EventHandler(this.cmdManageApplicationData_Click);
            // 
            // tbMain
            // 
            this.tbMain.Controls.Add(this.tbServiceInformation);
            this.tbMain.Controls.Add(this.tbTransactionProcessing);
            this.tbMain.Controls.Add(this.TbTMS);
            this.tbMain.Location = new System.Drawing.Point(12, 17);
            this.tbMain.Name = "tbMain";
            this.tbMain.SelectedIndex = 0;
            this.tbMain.Size = new System.Drawing.Size(779, 325);
            this.tbMain.TabIndex = 148;
            // 
            // tbServiceInformation
            // 
            this.tbServiceInformation.Controls.Add(this.CboWorkflowId);
            this.tbServiceInformation.Controls.Add(this.label15);
            this.tbServiceInformation.Controls.Add(this.TxtServiceKeyValue);
            this.tbServiceInformation.Controls.Add(this.lblServiceKey);
            this.tbServiceInformation.Controls.Add(this.ChkUseJsonInstead);
            this.tbServiceInformation.Controls.Add(this.ChkUseCertEndpoint);
            this.tbServiceInformation.Controls.Add(this.CboPTLSVersion);
            this.tbServiceInformation.Controls.Add(this.label5);
            this.tbServiceInformation.Controls.Add(this.TxtLoadIdentityToken);
            this.tbServiceInformation.Controls.Add(this.cmdManageApplicationData);
            this.tbServiceInformation.Controls.Add(this.cmdSignOnWithToken);
            this.tbServiceInformation.Controls.Add(this.cboApplicationDataAction);
            this.tbServiceInformation.Controls.Add(this.cmdRetrieveServiceInformation);
            this.tbServiceInformation.Controls.Add(this.txtApplicationProfileId);
            this.tbServiceInformation.Controls.Add(this.chkStep1);
            this.tbServiceInformation.Controls.Add(this.lnkManageMerchantProfiles);
            this.tbServiceInformation.Controls.Add(this.chkStep3);
            this.tbServiceInformation.Controls.Add(this.lblIsProfileInitialized);
            this.tbServiceInformation.Controls.Add(this.chkStep2);
            this.tbServiceInformation.Controls.Add(this.groupBox4);
            this.tbServiceInformation.Controls.Add(this.lnkSignOnWithToken);
            this.tbServiceInformation.Controls.Add(this.label8);
            this.tbServiceInformation.Controls.Add(this.lnkManageApplicationData);
            this.tbServiceInformation.Controls.Add(this.cboServiceIds);
            this.tbServiceInformation.Controls.Add(this.lnkRetrieveServiceInformation);
            this.tbServiceInformation.Location = new System.Drawing.Point(4, 22);
            this.tbServiceInformation.Name = "tbServiceInformation";
            this.tbServiceInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbServiceInformation.Size = new System.Drawing.Size(771, 299);
            this.tbServiceInformation.TabIndex = 0;
            this.tbServiceInformation.Text = "Service Information";
            this.tbServiceInformation.UseVisualStyleBackColor = true;
            // 
            // CboWorkflowId
            // 
            this.CboWorkflowId.FormattingEnabled = true;
            this.CboWorkflowId.Location = new System.Drawing.Point(232, 140);
            this.CboWorkflowId.Name = "CboWorkflowId";
            this.CboWorkflowId.Size = new System.Drawing.Size(238, 21);
            this.CboWorkflowId.TabIndex = 156;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(229, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 13);
            this.label15.TabIndex = 155;
            this.label15.Text = "Available WorkFlowIds";
            // 
            // TxtServiceKeyValue
            // 
            this.TxtServiceKeyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServiceKeyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TxtServiceKeyValue.Location = new System.Drawing.Point(546, 17);
            this.TxtServiceKeyValue.Name = "TxtServiceKeyValue";
            this.TxtServiceKeyValue.Size = new System.Drawing.Size(122, 20);
            this.TxtServiceKeyValue.TabIndex = 154;
            // 
            // lblServiceKey
            // 
            this.lblServiceKey.AutoSize = true;
            this.lblServiceKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblServiceKey.Location = new System.Drawing.Point(517, 21);
            this.lblServiceKey.Name = "lblServiceKey";
            this.lblServiceKey.Size = new System.Drawing.Size(23, 13);
            this.lblServiceKey.TabIndex = 153;
            this.lblServiceKey.Text = "SK";
            // 
            // ChkUseJsonInstead
            // 
            this.ChkUseJsonInstead.AutoSize = true;
            this.ChkUseJsonInstead.Location = new System.Drawing.Point(368, 3);
            this.ChkUseJsonInstead.Name = "ChkUseJsonInstead";
            this.ChkUseJsonInstead.Size = new System.Drawing.Size(145, 17);
            this.ChkUseJsonInstead.TabIndex = 152;
            this.ChkUseJsonInstead.Text = "Use Json Instead of XML";
            this.ChkUseJsonInstead.UseVisualStyleBackColor = true;
            // 
            // ChkUseCertEndpoint
            // 
            this.ChkUseCertEndpoint.AutoSize = true;
            this.ChkUseCertEndpoint.Checked = true;
            this.ChkUseCertEndpoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkUseCertEndpoint.Location = new System.Drawing.Point(368, 20);
            this.ChkUseCertEndpoint.Name = "ChkUseCertEndpoint";
            this.ChkUseCertEndpoint.Size = new System.Drawing.Size(112, 17);
            this.ChkUseCertEndpoint.TabIndex = 151;
            this.ChkUseCertEndpoint.Text = "Use Cert Endpoint";
            this.ChkUseCertEndpoint.UseVisualStyleBackColor = true;
            this.ChkUseCertEndpoint.CheckedChanged += new System.EventHandler(this.ChkUseCertEndpoint_CheckedChanged);
            // 
            // CboPTLSVersion
            // 
            this.CboPTLSVersion.FormattingEnabled = true;
            this.CboPTLSVersion.Location = new System.Drawing.Point(89, 9);
            this.CboPTLSVersion.Name = "CboPTLSVersion";
            this.CboPTLSVersion.Size = new System.Drawing.Size(137, 21);
            this.CboPTLSVersion.TabIndex = 150;
            this.CboPTLSVersion.TextChanged += new System.EventHandler(this.CboPTLSVersion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 149;
            this.label5.Text = "PTLS Version";
            // 
            // TxtLoadIdentityToken
            // 
            this.TxtLoadIdentityToken.Location = new System.Drawing.Point(232, 41);
            this.TxtLoadIdentityToken.Name = "TxtLoadIdentityToken";
            this.TxtLoadIdentityToken.Size = new System.Drawing.Size(238, 20);
            this.TxtLoadIdentityToken.TabIndex = 148;
            this.TxtLoadIdentityToken.Text = "[Override App.Config IdentityToken]";
            this.TxtLoadIdentityToken.Click += new System.EventHandler(this.TxtLoadIdentityToken_Click);
            this.TxtLoadIdentityToken.TextChanged += new System.EventHandler(this.TxtLoadIdentityToken_TextChanged);
            // 
            // tbTransactionProcessing
            // 
            this.tbTransactionProcessing.Controls.Add(this.ChkSaveDeleteApplicationData);
            this.tbTransactionProcessing.Controls.Add(this.TxtSvcId);
            this.tbTransactionProcessing.Controls.Add(this.label13);
            this.tbTransactionProcessing.Controls.Add(this.RTxtSummary);
            this.tbTransactionProcessing.Controls.Add(this.CmdGenerateTCSamples);
            this.tbTransactionProcessing.Controls.Add(this.CmdGenerateHCSamples);
            this.tbTransactionProcessing.Controls.Add(this.TxtAltWorkFlowId);
            this.tbTransactionProcessing.Controls.Add(this.label12);
            this.tbTransactionProcessing.Controls.Add(this.ChkProcessAsMagensa);
            this.tbTransactionProcessing.Controls.Add(this.TxtAmount);
            this.tbTransactionProcessing.Controls.Add(this.label10);
            this.tbTransactionProcessing.Controls.Add(this.CmdProcess);
            this.tbTransactionProcessing.Controls.Add(this.CboProcessString);
            this.tbTransactionProcessing.Controls.Add(this.ChkProcessAsAuthorizeAndCaptureString);
            this.tbTransactionProcessing.Controls.Add(this.label9);
            this.tbTransactionProcessing.Controls.Add(this.TxtConfigurationValues);
            this.tbTransactionProcessing.Location = new System.Drawing.Point(4, 22);
            this.tbTransactionProcessing.Name = "tbTransactionProcessing";
            this.tbTransactionProcessing.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransactionProcessing.Size = new System.Drawing.Size(771, 299);
            this.tbTransactionProcessing.TabIndex = 1;
            this.tbTransactionProcessing.Text = "Transaction Processing";
            this.tbTransactionProcessing.UseVisualStyleBackColor = true;
            this.tbTransactionProcessing.Enter += new System.EventHandler(this.tbTransactionProcessing_Enter);
            // 
            // TxtSvcId
            // 
            this.TxtSvcId.Location = new System.Drawing.Point(67, 244);
            this.TxtSvcId.Name = "TxtSvcId";
            this.TxtSvcId.Size = new System.Drawing.Size(74, 20);
            this.TxtSvcId.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Svc Id";
            // 
            // RTxtSummary
            // 
            this.RTxtSummary.Location = new System.Drawing.Point(147, 186);
            this.RTxtSummary.Name = "RTxtSummary";
            this.RTxtSummary.Size = new System.Drawing.Size(618, 107);
            this.RTxtSummary.TabIndex = 13;
            this.RTxtSummary.Text = "";
            // 
            // CmdGenerateTCSamples
            // 
            this.CmdGenerateTCSamples.Location = new System.Drawing.Point(26, 215);
            this.CmdGenerateTCSamples.Name = "CmdGenerateTCSamples";
            this.CmdGenerateTCSamples.Size = new System.Drawing.Size(115, 23);
            this.CmdGenerateTCSamples.TabIndex = 12;
            this.CmdGenerateTCSamples.Text = "Gen TC Samples";
            this.CmdGenerateTCSamples.UseVisualStyleBackColor = true;
            this.CmdGenerateTCSamples.Click += new System.EventHandler(this.CmdGenerateTCSamples_Click);
            // 
            // CmdGenerateHCSamples
            // 
            this.CmdGenerateHCSamples.Location = new System.Drawing.Point(26, 186);
            this.CmdGenerateHCSamples.Name = "CmdGenerateHCSamples";
            this.CmdGenerateHCSamples.Size = new System.Drawing.Size(115, 23);
            this.CmdGenerateHCSamples.TabIndex = 11;
            this.CmdGenerateHCSamples.Text = "Gen HC Samples";
            this.CmdGenerateHCSamples.UseVisualStyleBackColor = true;
            this.CmdGenerateHCSamples.Click += new System.EventHandler(this.CmdGenerateHCSamples_Click);
            // 
            // TxtAltWorkFlowId
            // 
            this.TxtAltWorkFlowId.Location = new System.Drawing.Point(408, 15);
            this.TxtAltWorkFlowId.Name = "TxtAltWorkFlowId";
            this.TxtAltWorkFlowId.Size = new System.Drawing.Size(72, 20);
            this.TxtAltWorkFlowId.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Use WorkflowId Instead";
            // 
            // ChkProcessAsMagensa
            // 
            this.ChkProcessAsMagensa.AutoSize = true;
            this.ChkProcessAsMagensa.Location = new System.Drawing.Point(224, 163);
            this.ChkProcessAsMagensa.Name = "ChkProcessAsMagensa";
            this.ChkProcessAsMagensa.Size = new System.Drawing.Size(126, 17);
            this.ChkProcessAsMagensa.TabIndex = 8;
            this.ChkProcessAsMagensa.Text = "Process As Magensa";
            this.ChkProcessAsMagensa.UseVisualStyleBackColor = true;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(147, 143);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(71, 20);
            this.TxtAmount.TabIndex = 7;
            this.TxtAmount.Text = "10.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Amount";
            // 
            // CmdProcess
            // 
            this.CmdProcess.Location = new System.Drawing.Point(224, 116);
            this.CmdProcess.Name = "CmdProcess";
            this.CmdProcess.Size = new System.Drawing.Size(142, 23);
            this.CmdProcess.TabIndex = 5;
            this.CmdProcess.Text = "Process Transaction Type";
            this.CmdProcess.UseVisualStyleBackColor = true;
            this.CmdProcess.Click += new System.EventHandler(this.CmdProcess_Click);
            // 
            // CboProcessString
            // 
            this.CboProcessString.FormattingEnabled = true;
            this.CboProcessString.Location = new System.Drawing.Point(23, 118);
            this.CboProcessString.Name = "CboProcessString";
            this.CboProcessString.Size = new System.Drawing.Size(195, 21);
            this.CboProcessString.TabIndex = 4;
            // 
            // ChkProcessAsAuthorizeAndCaptureString
            // 
            this.ChkProcessAsAuthorizeAndCaptureString.AutoSize = true;
            this.ChkProcessAsAuthorizeAndCaptureString.Location = new System.Drawing.Point(224, 140);
            this.ChkProcessAsAuthorizeAndCaptureString.Name = "ChkProcessAsAuthorizeAndCaptureString";
            this.ChkProcessAsAuthorizeAndCaptureString.Size = new System.Drawing.Size(108, 17);
            this.ChkProcessAsAuthorizeAndCaptureString.TabIndex = 3;
            this.ChkProcessAsAuthorizeAndCaptureString.Text = "Process as String";
            this.ChkProcessAsAuthorizeAndCaptureString.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Configuration Values";
            // 
            // TxtConfigurationValues
            // 
            this.TxtConfigurationValues.Location = new System.Drawing.Point(23, 41);
            this.TxtConfigurationValues.Multiline = true;
            this.TxtConfigurationValues.Name = "TxtConfigurationValues";
            this.TxtConfigurationValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtConfigurationValues.Size = new System.Drawing.Size(457, 69);
            this.TxtConfigurationValues.TabIndex = 1;
            // 
            // TbTMS
            // 
            this.TbTMS.Controls.Add(this.label17);
            this.TbTMS.Controls.Add(this.label25);
            this.TbTMS.Controls.Add(this.label16);
            this.TbTMS.Controls.Add(this.dtpEndTimeTMS);
            this.TbTMS.Controls.Add(this.dtpStartTimeTMS);
            this.TbTMS.Controls.Add(this.ChkLstTMSFunctions);
            this.TbTMS.Controls.Add(this.TxtTransactionId);
            this.TbTMS.Controls.Add(this.TmsQuery);
            this.TbTMS.Location = new System.Drawing.Point(4, 22);
            this.TbTMS.Name = "TbTMS";
            this.TbTMS.Padding = new System.Windows.Forms.Padding(3);
            this.TbTMS.Size = new System.Drawing.Size(771, 299);
            this.TbTMS.TabIndex = 2;
            this.TbTMS.Text = "TMS Queries";
            this.TbTMS.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "TxnId";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 67);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "End";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Start";
            // 
            // dtpEndTimeTMS
            // 
            this.dtpEndTimeTMS.CustomFormat = "";
            this.dtpEndTimeTMS.Location = new System.Drawing.Point(50, 64);
            this.dtpEndTimeTMS.Name = "dtpEndTimeTMS";
            this.dtpEndTimeTMS.Size = new System.Drawing.Size(229, 20);
            this.dtpEndTimeTMS.TabIndex = 26;
            // 
            // dtpStartTimeTMS
            // 
            this.dtpStartTimeTMS.CustomFormat = "";
            this.dtpStartTimeTMS.Location = new System.Drawing.Point(50, 38);
            this.dtpStartTimeTMS.Name = "dtpStartTimeTMS";
            this.dtpStartTimeTMS.Size = new System.Drawing.Size(229, 20);
            this.dtpStartTimeTMS.TabIndex = 25;
            // 
            // ChkLstTMSFunctions
            // 
            this.ChkLstTMSFunctions.FormattingEnabled = true;
            this.ChkLstTMSFunctions.Items.AddRange(new object[] {
            "QueryBatch",
            "QueryTransactionsSummary",
            "QueryTransactionsFamilies",
            "QueryTransactionsDetail"});
            this.ChkLstTMSFunctions.Location = new System.Drawing.Point(50, 121);
            this.ChkLstTMSFunctions.Name = "ChkLstTMSFunctions";
            this.ChkLstTMSFunctions.Size = new System.Drawing.Size(229, 64);
            this.ChkLstTMSFunctions.TabIndex = 21;
            // 
            // TxtTransactionId
            // 
            this.TxtTransactionId.Location = new System.Drawing.Point(50, 95);
            this.TxtTransactionId.Name = "TxtTransactionId";
            this.TxtTransactionId.Size = new System.Drawing.Size(229, 20);
            this.TxtTransactionId.TabIndex = 20;
            // 
            // TmsQuery
            // 
            this.TmsQuery.Location = new System.Drawing.Point(6, 6);
            this.TmsQuery.Name = "TmsQuery";
            this.TmsQuery.Size = new System.Drawing.Size(94, 23);
            this.TmsQuery.TabIndex = 19;
            this.TmsQuery.Text = "Query";
            this.TmsQuery.UseVisualStyleBackColor = true;
            this.TmsQuery.Click += new System.EventHandler(this.TmsSamples_Click);
            // 
            // ChkShowRequestModal
            // 
            this.ChkShowRequestModal.AutoSize = true;
            this.ChkShowRequestModal.Location = new System.Drawing.Point(619, 12);
            this.ChkShowRequestModal.Name = "ChkShowRequestModal";
            this.ChkShowRequestModal.Size = new System.Drawing.Size(168, 17);
            this.ChkShowRequestModal.TabIndex = 151;
            this.ChkShowRequestModal.Text = "Show Request and Response";
            this.ChkShowRequestModal.UseVisualStyleBackColor = true;
            // 
            // CboIndustryType
            // 
            this.CboIndustryType.FormattingEnabled = true;
            this.CboIndustryType.Items.AddRange(new object[] {
            "Ecommerce",
            "MOTO",
            "Retail",
            "Restaurant"});
            this.CboIndustryType.Location = new System.Drawing.Point(528, 8);
            this.CboIndustryType.Name = "CboIndustryType";
            this.CboIndustryType.Size = new System.Drawing.Size(85, 21);
            this.CboIndustryType.TabIndex = 16;
            this.CboIndustryType.SelectedIndexChanged += new System.EventHandler(this.CboIndustryType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Industry Type";
            // 
            // ChkSaveDeleteApplicationData
            // 
            this.ChkSaveDeleteApplicationData.AutoSize = true;
            this.ChkSaveDeleteApplicationData.Location = new System.Drawing.Point(26, 169);
            this.ChkSaveDeleteApplicationData.Name = "ChkSaveDeleteApplicationData";
            this.ChkSaveDeleteApplicationData.Size = new System.Drawing.Size(168, 17);
            this.ChkSaveDeleteApplicationData.TabIndex = 16;
            this.ChkSaveDeleteApplicationData.Text = "Save/Delete Application Data";
            this.ChkSaveDeleteApplicationData.UseVisualStyleBackColor = true;
            // 
            // SampleCodeREST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 808);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.CboIndustryType);
            this.Controls.Add(this.ChkShowRequestModal);
            this.Controls.Add(this.grpSendREST);
            this.Controls.Add(this.tbMain);
            this.Name = "SampleCodeREST";
            this.Text = "Sample Code REST";
            this.grpSendREST.ResumeLayout(false);
            this.grpSendREST.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbServiceInformation.ResumeLayout(false);
            this.tbServiceInformation.PerformLayout();
            this.tbTransactionProcessing.ResumeLayout(false);
            this.tbTransactionProcessing.PerformLayout();
            this.TbTMS.ResumeLayout(false);
            this.TbTMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdSignOnWithToken;
        private System.Windows.Forms.LinkLabel lnkRetrieveServiceInformation;
        private System.Windows.Forms.LinkLabel lnkManageApplicationData;
        private System.Windows.Forms.LinkLabel lnkSignOnWithToken;
        private System.Windows.Forms.CheckBox chkStep2;
        private System.Windows.Forms.CheckBox chkStep3;
        private System.Windows.Forms.CheckBox chkStep1;
        private System.Windows.Forms.Button cmdRetrieveServiceInformation;
        private System.Windows.Forms.Button cmdPOST;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSendREST;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboActionOrMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lnkMoreAboutREST;
        private System.Windows.Forms.Button cmdClearResponse;
        private System.Windows.Forms.CheckBox chkAlwaysCheckSessionToken;
        private System.Windows.Forms.Button cmdClearRequest;
        private System.Windows.Forms.TextBox txtReplaceInURL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReplaceInURLWith;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServiceIds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lnkManageMerchantProfiles;
        private System.Windows.Forms.Label lblIsProfileInitialized;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboAvailableProfiles;
        private System.Windows.Forms.TextBox txtApplicationProfileId;
        private System.Windows.Forms.ComboBox cboApplicationDataAction;
        private System.Windows.Forms.Button cmdManageApplicationData;
        private System.Windows.Forms.ComboBox cboMerchantProfileAction;
        private System.Windows.Forms.Button cmdPerformMerchantProfileAction;
        private System.Windows.Forms.TabControl tbMain;
        private System.Windows.Forms.TabPage tbServiceInformation;
        private System.Windows.Forms.TabPage tbTransactionProcessing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtConfigurationValues;
        private System.Windows.Forms.CheckBox ChkProcessAsAuthorizeAndCaptureString;
        private System.Windows.Forms.ComboBox CboProcessString;
        private System.Windows.Forms.Button CmdProcess;
        private System.Windows.Forms.TextBox TxtLoadIdentityToken;
        private System.Windows.Forms.ComboBox CboPTLSVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChkUseCertEndpoint;
        private System.Windows.Forms.CheckBox ChkShowRequestModal;
        private System.Windows.Forms.CheckBox ChkUseJsonInstead;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ChkProcessAsMagensa;
        private System.Windows.Forms.Label lblServiceKey;
        private System.Windows.Forms.TextBox TxtServiceKeyValue;
        private System.Windows.Forms.TextBox TxtAltWorkFlowId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox RTxtSummary;
        private System.Windows.Forms.Button CmdGenerateTCSamples;
        private System.Windows.Forms.Button CmdGenerateHCSamples;
        private System.Windows.Forms.TextBox TxtSvcId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboIndustryType;
        private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox CboWorkflowId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage TbTMS;
        private System.Windows.Forms.CheckedListBox ChkLstTMSFunctions;
        private System.Windows.Forms.TextBox TxtTransactionId;
        private System.Windows.Forms.Button TmsQuery;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpEndTimeTMS;
        private System.Windows.Forms.DateTimePicker dtpStartTimeTMS;
        private System.Windows.Forms.CheckBox ChkSaveDeleteApplicationData;
    }
}

