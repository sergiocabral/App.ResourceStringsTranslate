namespace ResourceStringsTranslate
{
    partial class FormMain
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
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.splitterStatus = new System.Windows.Forms.Splitter();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.labelSelectFolder = new System.Windows.Forms.Label();
            this.textBoxSelectFolder = new System.Windows.Forms.TextBox();
            this.labelSelectResource = new System.Windows.Forms.Label();
            this.listViewSelectResource = new System.Windows.Forms.ListView();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.splitterSelect = new System.Windows.Forms.Splitter();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tabControlControls = new System.Windows.Forms.TabControl();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.radioButtonModeGoogleTranslate = new System.Windows.Forms.RadioButton();
            this.panelModeGoogleTranslate = new System.Windows.Forms.Panel();
            this.labelModeGoogleTranslateBetweenRequests = new System.Windows.Forms.Label();
            this.numericUpDownModeGoogleTranslateBetweenRequests = new System.Windows.Forms.NumericUpDown();
            this.labelModeGoogleTranslateAfterBlock = new System.Windows.Forms.Label();
            this.numericUpDownModeGoogleTranslateAfterBlock = new System.Windows.Forms.NumericUpDown();
            this.labelModeGoogleTranslateUrl = new System.Windows.Forms.Label();
            this.textBoxModeGoogleTranslateUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonModeGoogleApi = new System.Windows.Forms.RadioButton();
            this.panelModeGoogleApi = new System.Windows.Forms.Panel();
            this.labelModeGoogleApiKey = new System.Windows.Forms.Label();
            this.textBoxModeGoogleApiKey = new System.Windows.Forms.TextBox();
            this.labelModeGoogleApiUrl = new System.Windows.Forms.Label();
            this.textBoxModeGoogleApiUrl = new System.Windows.Forms.TextBox();
            this.radioButtonModeMicrosoftApi = new System.Windows.Forms.RadioButton();
            this.panelModeMicrosoftApi = new System.Windows.Forms.Panel();
            this.label1ModeMicrosoftApiKey = new System.Windows.Forms.Label();
            this.textBoxModeMicrosoftApiKey = new System.Windows.Forms.TextBox();
            this.labelModeMicrosoftApiUrl = new System.Windows.Forms.Label();
            this.textBoxModeMicrosoftApiUrl = new System.Windows.Forms.TextBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonTranslateAll = new System.Windows.Forms.Button();
            this.buttonTranslateNext = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonReloadData = new System.Windows.Forms.Button();
            this.labelLanguageFrom = new System.Windows.Forms.Label();
            this.textBoxLanguageFrom = new System.Windows.Forms.TextBox();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.panelStatus.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.tabControlControls.SuspendLayout();
            this.tabPageConfiguration.SuspendLayout();
            this.panelModeGoogleTranslate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModeGoogleTranslateBetweenRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModeGoogleTranslateAfterBlock)).BeginInit();
            this.panelModeGoogleApi.SuspendLayout();
            this.panelModeMicrosoftApi.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.flowLayoutPanelActions.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarStatus.Location = new System.Drawing.Point(12, 111);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(760, 23);
            this.progressBarStatus.TabIndex = 0;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(12, 11);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(760, 94);
            this.textBoxStatus.TabIndex = 1;
            this.textBoxStatus.WordWrap = false;
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.progressBarStatus);
            this.panelStatus.Controls.Add(this.textBoxStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 455);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(784, 146);
            this.panelStatus.TabIndex = 2;
            // 
            // splitterStatus
            // 
            this.splitterStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterStatus.Location = new System.Drawing.Point(0, 448);
            this.splitterStatus.MinSize = 70;
            this.splitterStatus.Name = "splitterStatus";
            this.splitterStatus.Size = new System.Drawing.Size(784, 7);
            this.splitterStatus.TabIndex = 3;
            this.splitterStatus.TabStop = false;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.buttonSelectFolder);
            this.panelSelect.Controls.Add(this.listViewSelectResource);
            this.panelSelect.Controls.Add(this.labelSelectResource);
            this.panelSelect.Controls.Add(this.textBoxSelectFolder);
            this.panelSelect.Controls.Add(this.labelSelectFolder);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(200, 448);
            this.panelSelect.TabIndex = 0;
            // 
            // labelSelectFolder
            // 
            this.labelSelectFolder.AutoSize = true;
            this.labelSelectFolder.Location = new System.Drawing.Point(12, 9);
            this.labelSelectFolder.Name = "labelSelectFolder";
            this.labelSelectFolder.Size = new System.Drawing.Size(69, 13);
            this.labelSelectFolder.TabIndex = 0;
            this.labelSelectFolder.Text = "Select folder:";
            // 
            // textBoxSelectFolder
            // 
            this.textBoxSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectFolder.Location = new System.Drawing.Point(12, 25);
            this.textBoxSelectFolder.Name = "textBoxSelectFolder";
            this.textBoxSelectFolder.Size = new System.Drawing.Size(143, 20);
            this.textBoxSelectFolder.TabIndex = 1;
            // 
            // labelSelectResource
            // 
            this.labelSelectResource.AutoSize = true;
            this.labelSelectResource.Location = new System.Drawing.Point(12, 58);
            this.labelSelectResource.Name = "labelSelectResource";
            this.labelSelectResource.Size = new System.Drawing.Size(84, 13);
            this.labelSelectResource.TabIndex = 2;
            this.labelSelectResource.Text = "Select resource:";
            // 
            // listViewSelectResource
            // 
            this.listViewSelectResource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectResource.HideSelection = false;
            this.listViewSelectResource.Location = new System.Drawing.Point(12, 74);
            this.listViewSelectResource.MultiSelect = false;
            this.listViewSelectResource.Name = "listViewSelectResource";
            this.listViewSelectResource.Size = new System.Drawing.Size(177, 363);
            this.listViewSelectResource.TabIndex = 3;
            this.listViewSelectResource.UseCompatibleStateImageBehavior = false;
            this.listViewSelectResource.View = System.Windows.Forms.View.List;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(161, 25);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(28, 20);
            this.buttonSelectFolder.TabIndex = 4;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            // 
            // splitterSelect
            // 
            this.splitterSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterSelect.Location = new System.Drawing.Point(200, 0);
            this.splitterSelect.MinSize = 110;
            this.splitterSelect.Name = "splitterSelect";
            this.splitterSelect.Size = new System.Drawing.Size(7, 448);
            this.splitterSelect.TabIndex = 4;
            this.splitterSelect.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.tabControlControls);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(207, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(577, 448);
            this.panelControls.TabIndex = 8;
            // 
            // tabControlControls
            // 
            this.tabControlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlControls.Controls.Add(this.tabPageData);
            this.tabControlControls.Controls.Add(this.tabPageConfiguration);
            this.tabControlControls.Location = new System.Drawing.Point(9, 9);
            this.tabControlControls.Name = "tabControlControls";
            this.tabControlControls.SelectedIndex = 0;
            this.tabControlControls.Size = new System.Drawing.Size(559, 429);
            this.tabControlControls.TabIndex = 20;
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.panelModeMicrosoftApi);
            this.tabPageConfiguration.Controls.Add(this.radioButtonModeMicrosoftApi);
            this.tabPageConfiguration.Controls.Add(this.panelModeGoogleApi);
            this.tabPageConfiguration.Controls.Add(this.radioButtonModeGoogleApi);
            this.tabPageConfiguration.Controls.Add(this.panelModeGoogleTranslate);
            this.tabPageConfiguration.Controls.Add(this.radioButtonModeGoogleTranslate);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(551, 403);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // radioButtonModeGoogleTranslate
            // 
            this.radioButtonModeGoogleTranslate.AutoSize = true;
            this.radioButtonModeGoogleTranslate.Checked = true;
            this.radioButtonModeGoogleTranslate.Location = new System.Drawing.Point(6, 6);
            this.radioButtonModeGoogleTranslate.Name = "radioButtonModeGoogleTranslate";
            this.radioButtonModeGoogleTranslate.Size = new System.Drawing.Size(128, 17);
            this.radioButtonModeGoogleTranslate.TabIndex = 0;
            this.radioButtonModeGoogleTranslate.TabStop = true;
            this.radioButtonModeGoogleTranslate.Text = "Use Google Translate";
            this.radioButtonModeGoogleTranslate.UseVisualStyleBackColor = true;
            // 
            // panelModeGoogleTranslate
            // 
            this.panelModeGoogleTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeGoogleTranslate.Controls.Add(this.label7);
            this.panelModeGoogleTranslate.Controls.Add(this.label6);
            this.panelModeGoogleTranslate.Controls.Add(this.textBoxModeGoogleTranslateUrl);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateUrl);
            this.panelModeGoogleTranslate.Controls.Add(this.numericUpDownModeGoogleTranslateAfterBlock);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateAfterBlock);
            this.panelModeGoogleTranslate.Controls.Add(this.numericUpDownModeGoogleTranslateBetweenRequests);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateBetweenRequests);
            this.panelModeGoogleTranslate.Location = new System.Drawing.Point(6, 29);
            this.panelModeGoogleTranslate.Name = "panelModeGoogleTranslate";
            this.panelModeGoogleTranslate.Size = new System.Drawing.Size(539, 78);
            this.panelModeGoogleTranslate.TabIndex = 1;
            // 
            // labelModeGoogleTranslateBetweenRequests
            // 
            this.labelModeGoogleTranslateBetweenRequests.AutoSize = true;
            this.labelModeGoogleTranslateBetweenRequests.Location = new System.Drawing.Point(6, 5);
            this.labelModeGoogleTranslateBetweenRequests.Name = "labelModeGoogleTranslateBetweenRequests";
            this.labelModeGoogleTranslateBetweenRequests.Size = new System.Drawing.Size(168, 13);
            this.labelModeGoogleTranslateBetweenRequests.TabIndex = 0;
            this.labelModeGoogleTranslateBetweenRequests.Text = "Seconds between HTTP requests";
            // 
            // numericUpDownModeGoogleTranslateBetweenRequests
            // 
            this.numericUpDownModeGoogleTranslateBetweenRequests.Location = new System.Drawing.Point(180, 3);
            this.numericUpDownModeGoogleTranslateBetweenRequests.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDownModeGoogleTranslateBetweenRequests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownModeGoogleTranslateBetweenRequests.Name = "numericUpDownModeGoogleTranslateBetweenRequests";
            this.numericUpDownModeGoogleTranslateBetweenRequests.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownModeGoogleTranslateBetweenRequests.TabIndex = 1;
            this.numericUpDownModeGoogleTranslateBetweenRequests.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelModeGoogleTranslateAfterBlock
            // 
            this.labelModeGoogleTranslateAfterBlock.AutoSize = true;
            this.labelModeGoogleTranslateAfterBlock.Location = new System.Drawing.Point(3, 31);
            this.labelModeGoogleTranslateAfterBlock.Name = "labelModeGoogleTranslateAfterBlock";
            this.labelModeGoogleTranslateAfterBlock.Size = new System.Drawing.Size(171, 13);
            this.labelModeGoogleTranslateAfterBlock.TabIndex = 2;
            this.labelModeGoogleTranslateAfterBlock.Text = "Wait seconds after block response";
            // 
            // numericUpDownModeGoogleTranslateAfterBlock
            // 
            this.numericUpDownModeGoogleTranslateAfterBlock.Location = new System.Drawing.Point(180, 29);
            this.numericUpDownModeGoogleTranslateAfterBlock.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numericUpDownModeGoogleTranslateAfterBlock.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownModeGoogleTranslateAfterBlock.Name = "numericUpDownModeGoogleTranslateAfterBlock";
            this.numericUpDownModeGoogleTranslateAfterBlock.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownModeGoogleTranslateAfterBlock.TabIndex = 3;
            this.numericUpDownModeGoogleTranslateAfterBlock.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // labelModeGoogleTranslateUrl
            // 
            this.labelModeGoogleTranslateUrl.AutoSize = true;
            this.labelModeGoogleTranslateUrl.Location = new System.Drawing.Point(66, 58);
            this.labelModeGoogleTranslateUrl.Name = "labelModeGoogleTranslateUrl";
            this.labelModeGoogleTranslateUrl.Size = new System.Drawing.Size(108, 13);
            this.labelModeGoogleTranslateUrl.TabIndex = 4;
            this.labelModeGoogleTranslateUrl.Text = "URL of API endpoint:";
            // 
            // textBoxModeGoogleTranslateUrl
            // 
            this.textBoxModeGoogleTranslateUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleTranslateUrl.Location = new System.Drawing.Point(180, 55);
            this.textBoxModeGoogleTranslateUrl.Name = "textBoxModeGoogleTranslateUrl";
            this.textBoxModeGoogleTranslateUrl.Size = new System.Drawing.Size(356, 20);
            this.textBoxModeGoogleTranslateUrl.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(250, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Multiples and faster requests will block your machine.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(250, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Blocks occurs because this service is for real users.";
            // 
            // radioButtonModeGoogleApi
            // 
            this.radioButtonModeGoogleApi.AutoSize = true;
            this.radioButtonModeGoogleApi.Location = new System.Drawing.Point(6, 124);
            this.radioButtonModeGoogleApi.Name = "radioButtonModeGoogleApi";
            this.radioButtonModeGoogleApi.Size = new System.Drawing.Size(160, 17);
            this.radioButtonModeGoogleApi.TabIndex = 2;
            this.radioButtonModeGoogleApi.TabStop = true;
            this.radioButtonModeGoogleApi.Text = "Use API of Google Translate";
            this.radioButtonModeGoogleApi.UseVisualStyleBackColor = true;
            // 
            // panelModeGoogleApi
            // 
            this.panelModeGoogleApi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeGoogleApi.Controls.Add(this.textBoxModeGoogleApiUrl);
            this.panelModeGoogleApi.Controls.Add(this.labelModeGoogleApiUrl);
            this.panelModeGoogleApi.Controls.Add(this.textBoxModeGoogleApiKey);
            this.panelModeGoogleApi.Controls.Add(this.labelModeGoogleApiKey);
            this.panelModeGoogleApi.Location = new System.Drawing.Point(6, 147);
            this.panelModeGoogleApi.Name = "panelModeGoogleApi";
            this.panelModeGoogleApi.Size = new System.Drawing.Size(539, 52);
            this.panelModeGoogleApi.TabIndex = 8;
            // 
            // labelModeGoogleApiKey
            // 
            this.labelModeGoogleApiKey.AutoSize = true;
            this.labelModeGoogleApiKey.Location = new System.Drawing.Point(42, 32);
            this.labelModeGoogleApiKey.Name = "labelModeGoogleApiKey";
            this.labelModeGoogleApiKey.Size = new System.Drawing.Size(132, 13);
            this.labelModeGoogleApiKey.TabIndex = 4;
            this.labelModeGoogleApiKey.Text = "API key for authentication:";
            // 
            // textBoxModeGoogleApiKey
            // 
            this.textBoxModeGoogleApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleApiKey.Location = new System.Drawing.Point(180, 29);
            this.textBoxModeGoogleApiKey.Name = "textBoxModeGoogleApiKey";
            this.textBoxModeGoogleApiKey.Size = new System.Drawing.Size(356, 20);
            this.textBoxModeGoogleApiKey.TabIndex = 5;
            // 
            // labelModeGoogleApiUrl
            // 
            this.labelModeGoogleApiUrl.AutoSize = true;
            this.labelModeGoogleApiUrl.Location = new System.Drawing.Point(66, 6);
            this.labelModeGoogleApiUrl.Name = "labelModeGoogleApiUrl";
            this.labelModeGoogleApiUrl.Size = new System.Drawing.Size(108, 13);
            this.labelModeGoogleApiUrl.TabIndex = 6;
            this.labelModeGoogleApiUrl.Text = "URL of API endpoint:";
            // 
            // textBoxModeGoogleApiUrl
            // 
            this.textBoxModeGoogleApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleApiUrl.Location = new System.Drawing.Point(180, 3);
            this.textBoxModeGoogleApiUrl.Name = "textBoxModeGoogleApiUrl";
            this.textBoxModeGoogleApiUrl.Size = new System.Drawing.Size(356, 20);
            this.textBoxModeGoogleApiUrl.TabIndex = 7;
            // 
            // radioButtonModeMicrosoftApi
            // 
            this.radioButtonModeMicrosoftApi.AutoSize = true;
            this.radioButtonModeMicrosoftApi.Location = new System.Drawing.Point(6, 216);
            this.radioButtonModeMicrosoftApi.Name = "radioButtonModeMicrosoftApi";
            this.radioButtonModeMicrosoftApi.Size = new System.Drawing.Size(155, 17);
            this.radioButtonModeMicrosoftApi.TabIndex = 9;
            this.radioButtonModeMicrosoftApi.TabStop = true;
            this.radioButtonModeMicrosoftApi.Text = "Use API of Microsoft Azure:";
            this.radioButtonModeMicrosoftApi.UseVisualStyleBackColor = true;
            // 
            // panelModeMicrosoftApi
            // 
            this.panelModeMicrosoftApi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeMicrosoftApi.Controls.Add(this.textBoxModeMicrosoftApiUrl);
            this.panelModeMicrosoftApi.Controls.Add(this.labelModeMicrosoftApiUrl);
            this.panelModeMicrosoftApi.Controls.Add(this.textBoxModeMicrosoftApiKey);
            this.panelModeMicrosoftApi.Controls.Add(this.label1ModeMicrosoftApiKey);
            this.panelModeMicrosoftApi.Location = new System.Drawing.Point(6, 239);
            this.panelModeMicrosoftApi.Name = "panelModeMicrosoftApi";
            this.panelModeMicrosoftApi.Size = new System.Drawing.Size(539, 52);
            this.panelModeMicrosoftApi.TabIndex = 10;
            // 
            // label1ModeMicrosoftApiKey
            // 
            this.label1ModeMicrosoftApiKey.AutoSize = true;
            this.label1ModeMicrosoftApiKey.Location = new System.Drawing.Point(42, 32);
            this.label1ModeMicrosoftApiKey.Name = "label1ModeMicrosoftApiKey";
            this.label1ModeMicrosoftApiKey.Size = new System.Drawing.Size(132, 13);
            this.label1ModeMicrosoftApiKey.TabIndex = 4;
            this.label1ModeMicrosoftApiKey.Text = "API key for authentication:";
            // 
            // textBoxModeMicrosoftApiKey
            // 
            this.textBoxModeMicrosoftApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeMicrosoftApiKey.Location = new System.Drawing.Point(180, 29);
            this.textBoxModeMicrosoftApiKey.Name = "textBoxModeMicrosoftApiKey";
            this.textBoxModeMicrosoftApiKey.Size = new System.Drawing.Size(356, 20);
            this.textBoxModeMicrosoftApiKey.TabIndex = 5;
            // 
            // labelModeMicrosoftApiUrl
            // 
            this.labelModeMicrosoftApiUrl.AutoSize = true;
            this.labelModeMicrosoftApiUrl.Location = new System.Drawing.Point(66, 6);
            this.labelModeMicrosoftApiUrl.Name = "labelModeMicrosoftApiUrl";
            this.labelModeMicrosoftApiUrl.Size = new System.Drawing.Size(108, 13);
            this.labelModeMicrosoftApiUrl.TabIndex = 6;
            this.labelModeMicrosoftApiUrl.Text = "URL of API endpoint:";
            // 
            // textBoxModeMicrosoftApiUrl
            // 
            this.textBoxModeMicrosoftApiUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeMicrosoftApiUrl.Location = new System.Drawing.Point(180, 3);
            this.textBoxModeMicrosoftApiUrl.Name = "textBoxModeMicrosoftApiUrl";
            this.textBoxModeMicrosoftApiUrl.Size = new System.Drawing.Size(356, 20);
            this.textBoxModeMicrosoftApiUrl.TabIndex = 7;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.textBoxLanguageFrom);
            this.tabPageData.Controls.Add(this.labelLanguageFrom);
            this.tabPageData.Controls.Add(this.flowLayoutPanelActions);
            this.tabPageData.Controls.Add(this.dataGridViewData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(551, 403);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Translate";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(6, 43);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(539, 325);
            this.dataGridViewData.TabIndex = 9;
            // 
            // flowLayoutPanelActions
            // 
            this.flowLayoutPanelActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelActions.AutoScroll = true;
            this.flowLayoutPanelActions.Controls.Add(this.buttonReloadData);
            this.flowLayoutPanelActions.Controls.Add(this.buttonSaveChanges);
            this.flowLayoutPanelActions.Controls.Add(this.buttonTranslateNext);
            this.flowLayoutPanelActions.Controls.Add(this.buttonTranslateAll);
            this.flowLayoutPanelActions.Controls.Add(this.buttonStop);
            this.flowLayoutPanelActions.Location = new System.Drawing.Point(2, 371);
            this.flowLayoutPanelActions.Name = "flowLayoutPanelActions";
            this.flowLayoutPanelActions.Size = new System.Drawing.Size(543, 31);
            this.flowLayoutPanelActions.TabIndex = 20;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(387, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(90, 25);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateAll
            // 
            this.buttonTranslateAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateAll.Location = new System.Drawing.Point(291, 3);
            this.buttonTranslateAll.Name = "buttonTranslateAll";
            this.buttonTranslateAll.Size = new System.Drawing.Size(90, 25);
            this.buttonTranslateAll.TabIndex = 16;
            this.buttonTranslateAll.Text = "Translate All";
            this.buttonTranslateAll.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateNext
            // 
            this.buttonTranslateNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateNext.Location = new System.Drawing.Point(195, 3);
            this.buttonTranslateNext.Name = "buttonTranslateNext";
            this.buttonTranslateNext.Size = new System.Drawing.Size(90, 25);
            this.buttonTranslateNext.TabIndex = 17;
            this.buttonTranslateNext.Text = "Translate Next";
            this.buttonTranslateNext.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(99, 3);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(90, 25);
            this.buttonSaveChanges.TabIndex = 12;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonReloadData
            // 
            this.buttonReloadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReloadData.Location = new System.Drawing.Point(3, 3);
            this.buttonReloadData.Name = "buttonReloadData";
            this.buttonReloadData.Size = new System.Drawing.Size(90, 25);
            this.buttonReloadData.TabIndex = 13;
            this.buttonReloadData.Text = "Reload Data";
            this.buttonReloadData.UseVisualStyleBackColor = true;
            // 
            // labelLanguageFrom
            // 
            this.labelLanguageFrom.AutoSize = true;
            this.labelLanguageFrom.Location = new System.Drawing.Point(3, 3);
            this.labelLanguageFrom.Name = "labelLanguageFrom";
            this.labelLanguageFrom.Size = new System.Drawing.Size(121, 13);
            this.labelLanguageFrom.TabIndex = 21;
            this.labelLanguageFrom.Text = "Default Language From:";
            // 
            // textBoxLanguageFrom
            // 
            this.textBoxLanguageFrom.Location = new System.Drawing.Point(6, 19);
            this.textBoxLanguageFrom.Name = "textBoxLanguageFrom";
            this.textBoxLanguageFrom.Size = new System.Drawing.Size(118, 20);
            this.textBoxLanguageFrom.TabIndex = 22;
            this.textBoxLanguageFrom.Text = "en";
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.panelControls);
            this.panelOperations.Controls.Add(this.splitterSelect);
            this.panelOperations.Controls.Add(this.panelSelect);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(0, 0);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(784, 448);
            this.panelOperations.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.splitterStatus);
            this.Controls.Add(this.panelStatus);
            this.MinimumSize = new System.Drawing.Size(508, 534);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Strings Translate";
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.tabControlControls.ResumeLayout(false);
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.panelModeGoogleTranslate.ResumeLayout(false);
            this.panelModeGoogleTranslate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModeGoogleTranslateBetweenRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModeGoogleTranslateAfterBlock)).EndInit();
            this.panelModeGoogleApi.ResumeLayout(false);
            this.panelModeGoogleApi.PerformLayout();
            this.panelModeMicrosoftApi.ResumeLayout(false);
            this.panelModeMicrosoftApi.PerformLayout();
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.flowLayoutPanelActions.ResumeLayout(false);
            this.panelOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Splitter splitterStatus;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.ListView listViewSelectResource;
        private System.Windows.Forms.Label labelSelectResource;
        private System.Windows.Forms.TextBox textBoxSelectFolder;
        private System.Windows.Forms.Label labelSelectFolder;
        private System.Windows.Forms.Splitter splitterSelect;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.TabControl tabControlControls;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.TextBox textBoxLanguageFrom;
        private System.Windows.Forms.Label labelLanguageFrom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelActions;
        private System.Windows.Forms.Button buttonReloadData;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonTranslateNext;
        private System.Windows.Forms.Button buttonTranslateAll;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.TabPage tabPageConfiguration;
        private System.Windows.Forms.Panel panelModeMicrosoftApi;
        private System.Windows.Forms.TextBox textBoxModeMicrosoftApiUrl;
        private System.Windows.Forms.Label labelModeMicrosoftApiUrl;
        private System.Windows.Forms.TextBox textBoxModeMicrosoftApiKey;
        private System.Windows.Forms.Label label1ModeMicrosoftApiKey;
        private System.Windows.Forms.RadioButton radioButtonModeMicrosoftApi;
        private System.Windows.Forms.Panel panelModeGoogleApi;
        private System.Windows.Forms.TextBox textBoxModeGoogleApiUrl;
        private System.Windows.Forms.Label labelModeGoogleApiUrl;
        private System.Windows.Forms.TextBox textBoxModeGoogleApiKey;
        private System.Windows.Forms.Label labelModeGoogleApiKey;
        private System.Windows.Forms.RadioButton radioButtonModeGoogleApi;
        private System.Windows.Forms.Panel panelModeGoogleTranslate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxModeGoogleTranslateUrl;
        private System.Windows.Forms.Label labelModeGoogleTranslateUrl;
        private System.Windows.Forms.NumericUpDown numericUpDownModeGoogleTranslateAfterBlock;
        private System.Windows.Forms.Label labelModeGoogleTranslateAfterBlock;
        private System.Windows.Forms.NumericUpDown numericUpDownModeGoogleTranslateBetweenRequests;
        private System.Windows.Forms.Label labelModeGoogleTranslateBetweenRequests;
        private System.Windows.Forms.RadioButton radioButtonModeGoogleTranslate;
        private System.Windows.Forms.Panel panelOperations;
    }
}

