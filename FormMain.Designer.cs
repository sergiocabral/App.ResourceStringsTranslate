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
            this.components = new System.ComponentModel.Container();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.splitterStatus = new System.Windows.Forms.Splitter();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listViewSelectResource = new System.Windows.Forms.ListView();
            this.columnHeaderFilename = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLanguage = new System.Windows.Forms.ColumnHeader();
            this.labelSelectResource = new System.Windows.Forms.Label();
            this.textBoxSelectFolder = new System.Windows.Forms.TextBox();
            this.labelSelectFolder = new System.Windows.Forms.Label();
            this.splitterSelect = new System.Windows.Forms.Splitter();
            this.panelControls = new System.Windows.Forms.Panel();
            this.tabControlControls = new System.Windows.Forms.TabControl();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.textBoxDefaultLanguage = new System.Windows.Forms.TextBox();
            this.labelDefaultLanguage = new System.Windows.Forms.Label();
            this.flowLayoutPanelActions = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonReloadData = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonTranslateNext = new System.Windows.Forms.Button();
            this.buttonTranslateAll = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.panelModeMicrosoftApi = new System.Windows.Forms.Panel();
            this.textBoxModeMicrosoftApiUrl = new System.Windows.Forms.TextBox();
            this.labelModeMicrosoftApiUrl = new System.Windows.Forms.Label();
            this.textBoxModeMicrosoftApiKey = new System.Windows.Forms.TextBox();
            this.label1ModeMicrosoftApiKey = new System.Windows.Forms.Label();
            this.radioButtonModeMicrosoftApi = new System.Windows.Forms.RadioButton();
            this.panelModeGoogleApi = new System.Windows.Forms.Panel();
            this.textBoxModeGoogleApiUrl = new System.Windows.Forms.TextBox();
            this.labelModeGoogleApiUrl = new System.Windows.Forms.Label();
            this.textBoxModeGoogleApiKey = new System.Windows.Forms.TextBox();
            this.labelModeGoogleApiKey = new System.Windows.Forms.Label();
            this.radioButtonModeGoogleApi = new System.Windows.Forms.RadioButton();
            this.panelModeGoogleTranslate = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxModeGoogleTranslateUrl = new System.Windows.Forms.TextBox();
            this.labelModeGoogleTranslateUrl = new System.Windows.Forms.Label();
            this.numericUpDownModeGoogleTranslateAfterBlock = new System.Windows.Forms.NumericUpDown();
            this.labelModeGoogleTranslateAfterBlock = new System.Windows.Forms.Label();
            this.numericUpDownModeGoogleTranslateBetweenRequests = new System.Windows.Forms.NumericUpDown();
            this.labelModeGoogleTranslateBetweenRequests = new System.Windows.Forms.Label();
            this.radioButtonModeGoogleTranslate = new System.Windows.Forms.RadioButton();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelStatus.SuspendLayout();
            this.panelSelect.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.tabControlControls.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.flowLayoutPanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewData)).BeginInit();
            this.tabPageConfiguration.SuspendLayout();
            this.panelModeMicrosoftApi.SuspendLayout();
            this.panelModeGoogleApi.SuspendLayout();
            this.panelModeGoogleTranslate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownModeGoogleTranslateAfterBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownModeGoogleTranslateBetweenRequests))
                .BeginInit();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarStatus.Location = new System.Drawing.Point(14, 128);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(887, 27);
            this.progressBarStatus.TabIndex = 1;
            this.progressBarStatus.Value = 100;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxStatus.Location = new System.Drawing.Point(14, 13);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(886, 108);
            this.textBoxStatus.TabIndex = 0;
            this.textBoxStatus.Text = "(press Delete to clear)\r\n";
            this.textBoxStatus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStatus_KeyUp);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.progressBarStatus);
            this.panelStatus.Controls.Add(this.textBoxStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 525);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(915, 168);
            this.panelStatus.TabIndex = 2;
            // 
            // splitterStatus
            // 
            this.splitterStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterStatus.Location = new System.Drawing.Point(0, 518);
            this.splitterStatus.MinSize = 70;
            this.splitterStatus.Name = "splitterStatus";
            this.splitterStatus.Size = new System.Drawing.Size(915, 7);
            this.splitterStatus.TabIndex = 1;
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
            this.panelSelect.Size = new System.Drawing.Size(233, 518);
            this.panelSelect.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(188, 29);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(33, 23);
            this.buttonSelectFolder.TabIndex = 2;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // listViewSelectResource
            // 
            this.listViewSelectResource.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSelectResource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.columnHeaderFilename, this.columnHeaderLanguage});
            this.listViewSelectResource.GridLines = true;
            this.listViewSelectResource.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSelectResource.HideSelection = false;
            this.listViewSelectResource.Location = new System.Drawing.Point(14, 85);
            this.listViewSelectResource.MultiSelect = false;
            this.listViewSelectResource.Name = "listViewSelectResource";
            this.listViewSelectResource.Size = new System.Drawing.Size(206, 419);
            this.listViewSelectResource.TabIndex = 4;
            this.listViewSelectResource.UseCompatibleStateImageBehavior = false;
            this.listViewSelectResource.View = System.Windows.Forms.View.Details;
            this.listViewSelectResource.SelectedIndexChanged +=
                new System.EventHandler(this.listViewSelectResource_SelectedIndexChanged);
            // 
            // columnHeaderFilename
            // 
            this.columnHeaderFilename.Text = "Filename";
            this.columnHeaderFilename.Width = 113;
            // 
            // columnHeaderLanguage
            // 
            this.columnHeaderLanguage.Text = "Language";
            // 
            // labelSelectResource
            // 
            this.labelSelectResource.AutoSize = true;
            this.labelSelectResource.Location = new System.Drawing.Point(14, 67);
            this.labelSelectResource.Name = "labelSelectResource";
            this.labelSelectResource.Size = new System.Drawing.Size(89, 15);
            this.labelSelectResource.TabIndex = 3;
            this.labelSelectResource.Text = "Select resource:";
            // 
            // textBoxSelectFolder
            // 
            this.textBoxSelectFolder.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSelectFolder.Location = new System.Drawing.Point(14, 29);
            this.textBoxSelectFolder.Name = "textBoxSelectFolder";
            this.textBoxSelectFolder.Size = new System.Drawing.Size(166, 23);
            this.textBoxSelectFolder.TabIndex = 1;
            this.textBoxSelectFolder.TextChanged += new System.EventHandler(this.textBoxSelectFolder_TextChanged);
            // 
            // labelSelectFolder
            // 
            this.labelSelectFolder.AutoSize = true;
            this.labelSelectFolder.Location = new System.Drawing.Point(14, 10);
            this.labelSelectFolder.Name = "labelSelectFolder";
            this.labelSelectFolder.Size = new System.Drawing.Size(75, 15);
            this.labelSelectFolder.TabIndex = 0;
            this.labelSelectFolder.Text = "Select folder:";
            // 
            // splitterSelect
            // 
            this.splitterSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitterSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitterSelect.Location = new System.Drawing.Point(233, 0);
            this.splitterSelect.MinSize = 110;
            this.splitterSelect.Name = "splitterSelect";
            this.splitterSelect.Size = new System.Drawing.Size(7, 518);
            this.splitterSelect.TabIndex = 1;
            this.splitterSelect.TabStop = false;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.tabControlControls);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(240, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(675, 518);
            this.panelControls.TabIndex = 2;
            // 
            // tabControlControls
            // 
            this.tabControlControls.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlControls.Controls.Add(this.tabPageData);
            this.tabControlControls.Controls.Add(this.tabPageConfiguration);
            this.tabControlControls.Location = new System.Drawing.Point(10, 10);
            this.tabControlControls.Name = "tabControlControls";
            this.tabControlControls.SelectedIndex = 0;
            this.tabControlControls.Size = new System.Drawing.Size(654, 496);
            this.tabControlControls.TabIndex = 0;
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.textBoxDefaultLanguage);
            this.tabPageData.Controls.Add(this.labelDefaultLanguage);
            this.tabPageData.Controls.Add(this.flowLayoutPanelActions);
            this.tabPageData.Controls.Add(this.dataGridViewData);
            this.tabPageData.Location = new System.Drawing.Point(4, 24);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(646, 468);
            this.tabPageData.TabIndex = 0;
            this.tabPageData.Text = "Translate";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // textBoxDefaultLanguage
            // 
            this.textBoxDefaultLanguage.Location = new System.Drawing.Point(7, 21);
            this.textBoxDefaultLanguage.Name = "textBoxDefaultLanguage";
            this.textBoxDefaultLanguage.Size = new System.Drawing.Size(98, 23);
            this.textBoxDefaultLanguage.TabIndex = 1;
            this.textBoxDefaultLanguage.Text = "??";
            this.textBoxDefaultLanguage.TextChanged += new System.EventHandler(this.textBoxDefaultLanguage_TextChanged);
            // 
            // labelDefaultLanguage
            // 
            this.labelDefaultLanguage.AutoSize = true;
            this.labelDefaultLanguage.Location = new System.Drawing.Point(3, 3);
            this.labelDefaultLanguage.Name = "labelDefaultLanguage";
            this.labelDefaultLanguage.Size = new System.Drawing.Size(103, 15);
            this.labelDefaultLanguage.TabIndex = 0;
            this.labelDefaultLanguage.Text = "Default Language:";
            // 
            // flowLayoutPanelActions
            // 
            this.flowLayoutPanelActions.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelActions.AutoScroll = true;
            this.flowLayoutPanelActions.Controls.Add(this.buttonReloadData);
            this.flowLayoutPanelActions.Controls.Add(this.buttonSaveChanges);
            this.flowLayoutPanelActions.Controls.Add(this.buttonTranslateNext);
            this.flowLayoutPanelActions.Controls.Add(this.buttonTranslateAll);
            this.flowLayoutPanelActions.Controls.Add(this.buttonStop);
            this.flowLayoutPanelActions.Location = new System.Drawing.Point(2, 425);
            this.flowLayoutPanelActions.Name = "flowLayoutPanelActions";
            this.flowLayoutPanelActions.Size = new System.Drawing.Size(633, 36);
            this.flowLayoutPanelActions.TabIndex = 3;
            // 
            // buttonReloadData
            // 
            this.buttonReloadData.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReloadData.Location = new System.Drawing.Point(3, 3);
            this.buttonReloadData.Name = "buttonReloadData";
            this.buttonReloadData.Size = new System.Drawing.Size(105, 29);
            this.buttonReloadData.TabIndex = 4;
            this.buttonReloadData.Text = "Reload Data";
            this.buttonReloadData.UseVisualStyleBackColor = true;
            this.buttonReloadData.Click += new System.EventHandler(this.buttonReloadData_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(114, 3);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(105, 29);
            this.buttonSaveChanges.TabIndex = 5;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonTranslateNext
            // 
            this.buttonTranslateNext.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateNext.Location = new System.Drawing.Point(225, 3);
            this.buttonTranslateNext.Name = "buttonTranslateNext";
            this.buttonTranslateNext.Size = new System.Drawing.Size(105, 29);
            this.buttonTranslateNext.TabIndex = 6;
            this.buttonTranslateNext.Text = "Translate Next";
            this.buttonTranslateNext.UseVisualStyleBackColor = true;
            // 
            // buttonTranslateAll
            // 
            this.buttonTranslateAll.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslateAll.Location = new System.Drawing.Point(336, 3);
            this.buttonTranslateAll.Name = "buttonTranslateAll";
            this.buttonTranslateAll.Size = new System.Drawing.Size(105, 29);
            this.buttonTranslateAll.TabIndex = 7;
            this.buttonTranslateAll.Text = "Translate All";
            this.buttonTranslateAll.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.Location = new System.Drawing.Point(447, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(105, 29);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToOrderColumns = true;
            this.dataGridViewData.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewData.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(7, 50);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(631, 372);
            this.dataGridViewData.TabIndex = 2;
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
            this.tabPageConfiguration.Size = new System.Drawing.Size(644, 469);
            this.tabPageConfiguration.TabIndex = 1;
            this.tabPageConfiguration.Text = "Configuration";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // panelModeMicrosoftApi
            // 
            this.panelModeMicrosoftApi.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeMicrosoftApi.Controls.Add(this.textBoxModeMicrosoftApiUrl);
            this.panelModeMicrosoftApi.Controls.Add(this.labelModeMicrosoftApiUrl);
            this.panelModeMicrosoftApi.Controls.Add(this.textBoxModeMicrosoftApiKey);
            this.panelModeMicrosoftApi.Controls.Add(this.label1ModeMicrosoftApiKey);
            this.panelModeMicrosoftApi.Location = new System.Drawing.Point(7, 276);
            this.panelModeMicrosoftApi.Name = "panelModeMicrosoftApi";
            this.panelModeMicrosoftApi.Size = new System.Drawing.Size(640, 60);
            this.panelModeMicrosoftApi.TabIndex = 5;
            // 
            // textBoxModeMicrosoftApiUrl
            // 
            this.textBoxModeMicrosoftApiUrl.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeMicrosoftApiUrl.Location = new System.Drawing.Point(210, 3);
            this.textBoxModeMicrosoftApiUrl.Name = "textBoxModeMicrosoftApiUrl";
            this.textBoxModeMicrosoftApiUrl.Size = new System.Drawing.Size(426, 23);
            this.textBoxModeMicrosoftApiUrl.TabIndex = 1;
            this.textBoxModeMicrosoftApiUrl.TextChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeMicrosoftApiUrl
            // 
            this.labelModeMicrosoftApiUrl.AutoSize = true;
            this.labelModeMicrosoftApiUrl.Location = new System.Drawing.Point(77, 7);
            this.labelModeMicrosoftApiUrl.Name = "labelModeMicrosoftApiUrl";
            this.labelModeMicrosoftApiUrl.Size = new System.Drawing.Size(117, 15);
            this.labelModeMicrosoftApiUrl.TabIndex = 0;
            this.labelModeMicrosoftApiUrl.Text = "URL of API endpoint:";
            // 
            // textBoxModeMicrosoftApiKey
            // 
            this.textBoxModeMicrosoftApiKey.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeMicrosoftApiKey.Location = new System.Drawing.Point(210, 33);
            this.textBoxModeMicrosoftApiKey.Name = "textBoxModeMicrosoftApiKey";
            this.textBoxModeMicrosoftApiKey.Size = new System.Drawing.Size(426, 23);
            this.textBoxModeMicrosoftApiKey.TabIndex = 3;
            this.textBoxModeMicrosoftApiKey.TextChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // label1ModeMicrosoftApiKey
            // 
            this.label1ModeMicrosoftApiKey.AutoSize = true;
            this.label1ModeMicrosoftApiKey.Location = new System.Drawing.Point(49, 37);
            this.label1ModeMicrosoftApiKey.Name = "label1ModeMicrosoftApiKey";
            this.label1ModeMicrosoftApiKey.Size = new System.Drawing.Size(147, 15);
            this.label1ModeMicrosoftApiKey.TabIndex = 2;
            this.label1ModeMicrosoftApiKey.Text = "API key for authentication:";
            // 
            // radioButtonModeMicrosoftApi
            // 
            this.radioButtonModeMicrosoftApi.AutoSize = true;
            this.radioButtonModeMicrosoftApi.Location = new System.Drawing.Point(7, 249);
            this.radioButtonModeMicrosoftApi.Name = "radioButtonModeMicrosoftApi";
            this.radioButtonModeMicrosoftApi.Size = new System.Drawing.Size(169, 19);
            this.radioButtonModeMicrosoftApi.TabIndex = 4;
            this.radioButtonModeMicrosoftApi.TabStop = true;
            this.radioButtonModeMicrosoftApi.Text = "Use API of Microsoft Azure:";
            this.radioButtonModeMicrosoftApi.UseVisualStyleBackColor = true;
            this.radioButtonModeMicrosoftApi.CheckedChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // panelModeGoogleApi
            // 
            this.panelModeGoogleApi.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeGoogleApi.Controls.Add(this.textBoxModeGoogleApiUrl);
            this.panelModeGoogleApi.Controls.Add(this.labelModeGoogleApiUrl);
            this.panelModeGoogleApi.Controls.Add(this.textBoxModeGoogleApiKey);
            this.panelModeGoogleApi.Controls.Add(this.labelModeGoogleApiKey);
            this.panelModeGoogleApi.Location = new System.Drawing.Point(7, 170);
            this.panelModeGoogleApi.Name = "panelModeGoogleApi";
            this.panelModeGoogleApi.Size = new System.Drawing.Size(640, 60);
            this.panelModeGoogleApi.TabIndex = 3;
            // 
            // textBoxModeGoogleApiUrl
            // 
            this.textBoxModeGoogleApiUrl.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleApiUrl.Location = new System.Drawing.Point(210, 3);
            this.textBoxModeGoogleApiUrl.Name = "textBoxModeGoogleApiUrl";
            this.textBoxModeGoogleApiUrl.Size = new System.Drawing.Size(426, 23);
            this.textBoxModeGoogleApiUrl.TabIndex = 1;
            this.textBoxModeGoogleApiUrl.TextChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeGoogleApiUrl
            // 
            this.labelModeGoogleApiUrl.AutoSize = true;
            this.labelModeGoogleApiUrl.Location = new System.Drawing.Point(77, 7);
            this.labelModeGoogleApiUrl.Name = "labelModeGoogleApiUrl";
            this.labelModeGoogleApiUrl.Size = new System.Drawing.Size(117, 15);
            this.labelModeGoogleApiUrl.TabIndex = 0;
            this.labelModeGoogleApiUrl.Text = "URL of API endpoint:";
            // 
            // textBoxModeGoogleApiKey
            // 
            this.textBoxModeGoogleApiKey.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleApiKey.Location = new System.Drawing.Point(210, 33);
            this.textBoxModeGoogleApiKey.Name = "textBoxModeGoogleApiKey";
            this.textBoxModeGoogleApiKey.Size = new System.Drawing.Size(426, 23);
            this.textBoxModeGoogleApiKey.TabIndex = 3;
            this.textBoxModeGoogleApiKey.TextChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeGoogleApiKey
            // 
            this.labelModeGoogleApiKey.AutoSize = true;
            this.labelModeGoogleApiKey.Location = new System.Drawing.Point(49, 37);
            this.labelModeGoogleApiKey.Name = "labelModeGoogleApiKey";
            this.labelModeGoogleApiKey.Size = new System.Drawing.Size(147, 15);
            this.labelModeGoogleApiKey.TabIndex = 2;
            this.labelModeGoogleApiKey.Text = "API key for authentication:";
            // 
            // radioButtonModeGoogleApi
            // 
            this.radioButtonModeGoogleApi.AutoSize = true;
            this.radioButtonModeGoogleApi.Location = new System.Drawing.Point(7, 143);
            this.radioButtonModeGoogleApi.Name = "radioButtonModeGoogleApi";
            this.radioButtonModeGoogleApi.Size = new System.Drawing.Size(169, 19);
            this.radioButtonModeGoogleApi.TabIndex = 2;
            this.radioButtonModeGoogleApi.TabStop = true;
            this.radioButtonModeGoogleApi.Text = "Use API of Google Translate";
            this.radioButtonModeGoogleApi.UseVisualStyleBackColor = true;
            this.radioButtonModeGoogleApi.CheckedChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // panelModeGoogleTranslate
            // 
            this.panelModeGoogleTranslate.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panelModeGoogleTranslate.Controls.Add(this.label7);
            this.panelModeGoogleTranslate.Controls.Add(this.label6);
            this.panelModeGoogleTranslate.Controls.Add(this.textBoxModeGoogleTranslateUrl);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateUrl);
            this.panelModeGoogleTranslate.Controls.Add(this.numericUpDownModeGoogleTranslateAfterBlock);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateAfterBlock);
            this.panelModeGoogleTranslate.Controls.Add(this.numericUpDownModeGoogleTranslateBetweenRequests);
            this.panelModeGoogleTranslate.Controls.Add(this.labelModeGoogleTranslateBetweenRequests);
            this.panelModeGoogleTranslate.Location = new System.Drawing.Point(7, 33);
            this.panelModeGoogleTranslate.Name = "panelModeGoogleTranslate";
            this.panelModeGoogleTranslate.Size = new System.Drawing.Size(640, 90);
            this.panelModeGoogleTranslate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(292, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Blocks occurs because this service is for real users.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(292, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Multiples and faster requests will block your machine.";
            // 
            // textBoxModeGoogleTranslateUrl
            // 
            this.textBoxModeGoogleTranslateUrl.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModeGoogleTranslateUrl.Location = new System.Drawing.Point(210, 63);
            this.textBoxModeGoogleTranslateUrl.Name = "textBoxModeGoogleTranslateUrl";
            this.textBoxModeGoogleTranslateUrl.Size = new System.Drawing.Size(426, 23);
            this.textBoxModeGoogleTranslateUrl.TabIndex = 9;
            this.textBoxModeGoogleTranslateUrl.TextChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeGoogleTranslateUrl
            // 
            this.labelModeGoogleTranslateUrl.AutoSize = true;
            this.labelModeGoogleTranslateUrl.Location = new System.Drawing.Point(77, 67);
            this.labelModeGoogleTranslateUrl.Name = "labelModeGoogleTranslateUrl";
            this.labelModeGoogleTranslateUrl.Size = new System.Drawing.Size(117, 15);
            this.labelModeGoogleTranslateUrl.TabIndex = 8;
            this.labelModeGoogleTranslateUrl.Text = "URL of API endpoint:";
            // 
            // numericUpDownModeGoogleTranslateAfterBlock
            // 
            this.numericUpDownModeGoogleTranslateAfterBlock.Location = new System.Drawing.Point(210, 33);
            this.numericUpDownModeGoogleTranslateAfterBlock.Maximum = new decimal(new int[] {86400, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateAfterBlock.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateAfterBlock.Name = "numericUpDownModeGoogleTranslateAfterBlock";
            this.numericUpDownModeGoogleTranslateAfterBlock.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownModeGoogleTranslateAfterBlock.TabIndex = 6;
            this.numericUpDownModeGoogleTranslateAfterBlock.Value = new decimal(new int[] {99, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateAfterBlock.ValueChanged +=
                new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeGoogleTranslateAfterBlock
            // 
            this.labelModeGoogleTranslateAfterBlock.AutoSize = true;
            this.labelModeGoogleTranslateAfterBlock.Location = new System.Drawing.Point(3, 36);
            this.labelModeGoogleTranslateAfterBlock.Name = "labelModeGoogleTranslateAfterBlock";
            this.labelModeGoogleTranslateAfterBlock.Size = new System.Drawing.Size(186, 15);
            this.labelModeGoogleTranslateAfterBlock.TabIndex = 5;
            this.labelModeGoogleTranslateAfterBlock.Text = "Wait seconds after block response";
            // 
            // numericUpDownModeGoogleTranslateBetweenRequests
            // 
            this.numericUpDownModeGoogleTranslateBetweenRequests.Location = new System.Drawing.Point(210, 3);
            this.numericUpDownModeGoogleTranslateBetweenRequests.Maximum = new decimal(new int[] {86400, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateBetweenRequests.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateBetweenRequests.Name =
                "numericUpDownModeGoogleTranslateBetweenRequests";
            this.numericUpDownModeGoogleTranslateBetweenRequests.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownModeGoogleTranslateBetweenRequests.TabIndex = 3;
            this.numericUpDownModeGoogleTranslateBetweenRequests.Value = new decimal(new int[] {99, 0, 0, 0});
            this.numericUpDownModeGoogleTranslateBetweenRequests.ValueChanged +=
                new System.EventHandler(this.controlMode_Changed);
            // 
            // labelModeGoogleTranslateBetweenRequests
            // 
            this.labelModeGoogleTranslateBetweenRequests.AutoSize = true;
            this.labelModeGoogleTranslateBetweenRequests.Location = new System.Drawing.Point(7, 6);
            this.labelModeGoogleTranslateBetweenRequests.Name = "labelModeGoogleTranslateBetweenRequests";
            this.labelModeGoogleTranslateBetweenRequests.Size = new System.Drawing.Size(177, 15);
            this.labelModeGoogleTranslateBetweenRequests.TabIndex = 2;
            this.labelModeGoogleTranslateBetweenRequests.Text = "Seconds between HTTP requests";
            // 
            // radioButtonModeGoogleTranslate
            // 
            this.radioButtonModeGoogleTranslate.AutoSize = true;
            this.radioButtonModeGoogleTranslate.Checked = true;
            this.radioButtonModeGoogleTranslate.Location = new System.Drawing.Point(7, 7);
            this.radioButtonModeGoogleTranslate.Name = "radioButtonModeGoogleTranslate";
            this.radioButtonModeGoogleTranslate.Size = new System.Drawing.Size(134, 19);
            this.radioButtonModeGoogleTranslate.TabIndex = 0;
            this.radioButtonModeGoogleTranslate.TabStop = true;
            this.radioButtonModeGoogleTranslate.Text = "Use Google Translate";
            this.radioButtonModeGoogleTranslate.UseVisualStyleBackColor = true;
            this.radioButtonModeGoogleTranslate.CheckedChanged += new System.EventHandler(this.controlMode_Changed);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.panelControls);
            this.panelOperations.Controls.Add(this.splitterSelect);
            this.panelOperations.Controls.Add(this.panelSelect);
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOperations.Location = new System.Drawing.Point(0, 0);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(915, 518);
            this.panelOperations.TabIndex = 0;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select folder of resource string files:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 693);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.splitterStatus);
            this.Controls.Add(this.panelStatus);
            this.MinimumSize = new System.Drawing.Size(590, 610);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resource Strings Translate";
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.panelControls.ResumeLayout(false);
            this.tabControlControls.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.flowLayoutPanelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewData)).EndInit();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            this.panelModeMicrosoftApi.ResumeLayout(false);
            this.panelModeMicrosoftApi.PerformLayout();
            this.panelModeGoogleApi.ResumeLayout(false);
            this.panelModeGoogleApi.PerformLayout();
            this.panelModeGoogleTranslate.ResumeLayout(false);
            this.panelModeGoogleTranslate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownModeGoogleTranslateAfterBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownModeGoogleTranslateBetweenRequests))
                .EndInit();
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
        private System.Windows.Forms.TextBox textBoxDefaultLanguage;
        private System.Windows.Forms.Label labelDefaultLanguage;
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColumnHeader columnHeaderFilename;
        private System.Windows.Forms.ColumnHeader columnHeaderLanguage;
    }
}

