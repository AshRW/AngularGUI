
namespace AngularGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.openedProjectTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.openFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.createNewTextBox = new System.Windows.Forms.TextBox();
            this.createComponentButton = new System.Windows.Forms.Button();
            this.createServiceButton = new System.Windows.Forms.Button();
            this.createModuleButton = new System.Windows.Forms.Button();
            this.errmessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.resizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectDriveLabel = new System.Windows.Forms.Label();
            this.projectLocationLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectDriveHead = new System.Windows.Forms.Label();
            this.projectLocHead = new System.Windows.Forms.Label();
            this.projectNameHead = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errMsgFlag = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.createNewFlagTextBox = new System.Windows.Forms.TextBox();
            this.npmAuditFixButton = new System.Windows.Forms.Button();
            this.npmInstallButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.outPut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("moderna", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(88)))));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angular GUI";
            // 
            // openedProjectTextBox
            // 
            this.openedProjectTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openedProjectTextBox.Location = new System.Drawing.Point(8, 264);
            this.openedProjectTextBox.Name = "openedProjectTextBox";
            this.openedProjectTextBox.Size = new System.Drawing.Size(184, 21);
            this.openedProjectTextBox.TabIndex = 1;
            this.openedProjectTextBox.DoubleClick += new System.EventHandler(this.openedProjectTextBox_Click);
            this.openedProjectTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openedProjectTextBox_KeyDown);
            // 
            // openFolderButton
            // 
            this.openFolderButton.FlatAppearance.BorderSize = 0;
            this.openFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFolderButton.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFolderButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("openFolderButton.Image")));
            this.openFolderButton.Location = new System.Drawing.Point(0, 168);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(200, 83);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Open Folder";
            this.openFolderButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.openFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openFolderButton.UseVisualStyleBackColor = true;
            this.openFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createNewTextBox
            // 
            this.createNewTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createNewTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTextBox.Location = new System.Drawing.Point(6, 397);
            this.createNewTextBox.Name = "createNewTextBox";
            this.createNewTextBox.Size = new System.Drawing.Size(400, 21);
            this.createNewTextBox.TabIndex = 4;
            // 
            // createComponentButton
            // 
            this.createComponentButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createComponentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createComponentButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createComponentButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createComponentButton.Location = new System.Drawing.Point(21, 494);
            this.createComponentButton.Name = "createComponentButton";
            this.createComponentButton.Size = new System.Drawing.Size(120, 30);
            this.createComponentButton.TabIndex = 5;
            this.createComponentButton.Text = "Create Component";
            this.createComponentButton.UseVisualStyleBackColor = true;
            this.createComponentButton.Click += new System.EventHandler(this.createComponentButton_Click);
            // 
            // createServiceButton
            // 
            this.createServiceButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createServiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createServiceButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createServiceButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createServiceButton.Location = new System.Drawing.Point(147, 494);
            this.createServiceButton.Name = "createServiceButton";
            this.createServiceButton.Size = new System.Drawing.Size(120, 30);
            this.createServiceButton.TabIndex = 5;
            this.createServiceButton.Text = "Create Service";
            this.createServiceButton.UseVisualStyleBackColor = true;
            this.createServiceButton.Click += new System.EventHandler(this.createServiceButton_Click);
            // 
            // createModuleButton
            // 
            this.createModuleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createModuleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createModuleButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createModuleButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createModuleButton.Location = new System.Drawing.Point(273, 494);
            this.createModuleButton.Name = "createModuleButton";
            this.createModuleButton.Size = new System.Drawing.Size(120, 30);
            this.createModuleButton.TabIndex = 5;
            this.createModuleButton.Text = "Create Module";
            this.createModuleButton.UseVisualStyleBackColor = true;
            this.createModuleButton.Click += new System.EventHandler(this.createModuleButton_Click);
            // 
            // errmessage
            // 
            this.errmessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errmessage.AutoSize = true;
            this.errmessage.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errmessage.ForeColor = System.Drawing.Color.Red;
            this.errmessage.Location = new System.Drawing.Point(111, 380);
            this.errmessage.Name = "errmessage";
            this.errmessage.Size = new System.Drawing.Size(0, 14);
            this.errmessage.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 40);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.resizeButton);
            this.panel6.Controls.Add(this.closeButton);
            this.panel6.Controls.Add(this.minimizeButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(492, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(119, 40);
            this.panel6.TabIndex = 2;
            // 
            // resizeButton
            // 
            this.resizeButton.FlatAppearance.BorderSize = 0;
            this.resizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.resizeButton.Image = ((System.Drawing.Image)(resources.GetObject("resizeButton.Image")));
            this.resizeButton.Location = new System.Drawing.Point(45, 6);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Padding = new System.Windows.Forms.Padding(3);
            this.resizeButton.Size = new System.Drawing.Size(28, 28);
            this.resizeButton.TabIndex = 1;
            this.resizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.resizeButton.UseVisualStyleBackColor = true;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(83, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Padding = new System.Windows.Forms.Padding(3);
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 1;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(7, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 28);
            this.minimizeButton.TabIndex = 1;
            this.minimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angular GUI";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.projectDriveLabel);
            this.panel2.Controls.Add(this.projectLocationLabel);
            this.panel2.Controls.Add(this.projectNameLabel);
            this.panel2.Controls.Add(this.projectDriveHead);
            this.panel2.Controls.Add(this.projectLocHead);
            this.panel2.Controls.Add(this.projectNameHead);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.openedProjectTextBox);
            this.panel2.Controls.Add(this.openFolderButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 572);
            this.panel2.TabIndex = 8;
            // 
            // projectDriveLabel
            // 
            this.projectDriveLabel.AutoSize = true;
            this.projectDriveLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDriveLabel.ForeColor = System.Drawing.Color.White;
            this.projectDriveLabel.Location = new System.Drawing.Point(31, 523);
            this.projectDriveLabel.Name = "projectDriveLabel";
            this.projectDriveLabel.Size = new System.Drawing.Size(0, 17);
            this.projectDriveLabel.TabIndex = 4;
            // 
            // projectLocationLabel
            // 
            this.projectLocationLabel.AutoSize = true;
            this.projectLocationLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLocationLabel.ForeColor = System.Drawing.Color.White;
            this.projectLocationLabel.Location = new System.Drawing.Point(14, 418);
            this.projectLocationLabel.MaximumSize = new System.Drawing.Size(172, 60);
            this.projectLocationLabel.Name = "projectLocationLabel";
            this.projectLocationLabel.Size = new System.Drawing.Size(0, 17);
            this.projectLocationLabel.TabIndex = 4;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.White;
            this.projectNameLabel.Location = new System.Drawing.Point(31, 335);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(0, 17);
            this.projectNameLabel.TabIndex = 4;
            // 
            // projectDriveHead
            // 
            this.projectDriveHead.AutoSize = true;
            this.projectDriveHead.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDriveHead.ForeColor = System.Drawing.Color.White;
            this.projectDriveHead.Location = new System.Drawing.Point(5, 503);
            this.projectDriveHead.Name = "projectDriveHead";
            this.projectDriveHead.Size = new System.Drawing.Size(0, 15);
            this.projectDriveHead.TabIndex = 3;
            // 
            // projectLocHead
            // 
            this.projectLocHead.AutoSize = true;
            this.projectLocHead.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLocHead.ForeColor = System.Drawing.Color.White;
            this.projectLocHead.Location = new System.Drawing.Point(5, 395);
            this.projectLocHead.Name = "projectLocHead";
            this.projectLocHead.Size = new System.Drawing.Size(0, 15);
            this.projectLocHead.TabIndex = 3;
            // 
            // projectNameHead
            // 
            this.projectNameHead.AutoSize = true;
            this.projectNameHead.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameHead.ForeColor = System.Drawing.Color.White;
            this.projectNameHead.Location = new System.Drawing.Point(5, 313);
            this.projectNameHead.Name = "projectNameHead";
            this.projectNameHead.Size = new System.Drawing.Size(0, 15);
            this.projectNameHead.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orbitron", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(88)))));
            this.label2.Location = new System.Drawing.Point(72, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "by ARW";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(0)))), ((int)(((byte)(35)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.errMsgFlag);
            this.panel4.Controls.Add(this.errmessage);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.createNewFlagTextBox);
            this.panel4.Controls.Add(this.createNewTextBox);
            this.panel4.Controls.Add(this.npmAuditFixButton);
            this.panel4.Controls.Add(this.npmInstallButton);
            this.panel4.Controls.Add(this.createComponentButton);
            this.panel4.Controls.Add(this.createServiceButton);
            this.panel4.Controls.Add(this.createModuleButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 572);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(88)))));
            this.label4.Location = new System.Drawing.Point(6, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Option or Flag:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(22)))), ((int)(((byte)(88)))));
            this.label3.Location = new System.Drawing.Point(6, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // errMsgFlag
            // 
            this.errMsgFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errMsgFlag.AutoSize = true;
            this.errMsgFlag.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgFlag.ForeColor = System.Drawing.Color.Red;
            this.errMsgFlag.Location = new System.Drawing.Point(156, 431);
            this.errMsgFlag.Name = "errMsgFlag";
            this.errMsgFlag.Size = new System.Drawing.Size(0, 14);
            this.errMsgFlag.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.outPut);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 542);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 30);
            this.panel5.TabIndex = 6;
            // 
            // createNewFlagTextBox
            // 
            this.createNewFlagTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createNewFlagTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewFlagTextBox.Location = new System.Drawing.Point(6, 448);
            this.createNewFlagTextBox.Name = "createNewFlagTextBox";
            this.createNewFlagTextBox.Size = new System.Drawing.Size(400, 21);
            this.createNewFlagTextBox.TabIndex = 4;
            // 
            // npmAuditFixButton
            // 
            this.npmAuditFixButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.npmAuditFixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.npmAuditFixButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npmAuditFixButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.npmAuditFixButton.Location = new System.Drawing.Point(207, 313);
            this.npmAuditFixButton.Name = "npmAuditFixButton";
            this.npmAuditFixButton.Size = new System.Drawing.Size(120, 30);
            this.npmAuditFixButton.TabIndex = 5;
            this.npmAuditFixButton.Text = "Audit and Fix";
            this.npmAuditFixButton.UseVisualStyleBackColor = true;
            this.npmAuditFixButton.Click += new System.EventHandler(this.npmAuditFixButton_Click);
            // 
            // npmInstallButton
            // 
            this.npmInstallButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.npmInstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.npmInstallButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npmInstallButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.npmInstallButton.Location = new System.Drawing.Point(70, 313);
            this.npmInstallButton.Name = "npmInstallButton";
            this.npmInstallButton.Size = new System.Drawing.Size(120, 30);
            this.npmInstallButton.TabIndex = 5;
            this.npmInstallButton.Text = "npm Install";
            this.npmInstallButton.UseVisualStyleBackColor = true;
            this.npmInstallButton.Click += new System.EventHandler(this.npminstallButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.progressBar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(411, 24);
            this.panel7.TabIndex = 7;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(411, 14);
            this.progressBar.TabIndex = 0;
            // 
            // outPut
            // 
            this.outPut.AutoSize = true;
            this.outPut.Location = new System.Drawing.Point(33, 9);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(0, 13);
            this.outPut.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(611, 612);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Angular GUI by Anurag";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox openedProjectTextBox;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.FolderBrowserDialog openFolderDialog;
        private System.Windows.Forms.TextBox createNewTextBox;
        private System.Windows.Forms.Button createComponentButton;
        private System.Windows.Forms.Button createServiceButton;
        private System.Windows.Forms.Button createModuleButton;
        private System.Windows.Forms.Label errmessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label projectLocHead;
        private System.Windows.Forms.Label projectNameHead;
        private System.Windows.Forms.Label projectDriveHead;
        private System.Windows.Forms.Label projectDriveLabel;
        private System.Windows.Forms.Label projectLocationLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox createNewFlagTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errMsgFlag;
        private System.Windows.Forms.Button npmAuditFixButton;
        private System.Windows.Forms.Button npmInstallButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label outPut;
    }
}

