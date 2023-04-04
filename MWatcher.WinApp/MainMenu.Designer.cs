namespace MWatcher.WinApp
{
    partial class MainMenu
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
            this.DcChecker = new System.ComponentModel.BackgroundWorker();
            this.lst_CharacterStatus = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbox_Settings = new System.Windows.Forms.GroupBox();
            this.btn_TestNotify = new System.Windows.Forms.Button();
            this.btn_TestWp = new System.Windows.Forms.Button();
            this.chck_HeartBeat = new System.Windows.Forms.CheckBox();
            this.txt_HeartBeatVal = new System.Windows.Forms.TextBox();
            this.lbl_HideSettings = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbox_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // DcChecker
            // 
            this.DcChecker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DcChecker_DoWork);
            this.DcChecker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DcChecker_RunWorkerCompleted);
            // 
            // lst_CharacterStatus
            // 
            this.lst_CharacterStatus.BackColor = System.Drawing.Color.Azure;
            this.lst_CharacterStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_CharacterStatus.Enabled = false;
            this.lst_CharacterStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_CharacterStatus.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lst_CharacterStatus.FormattingEnabled = true;
            this.lst_CharacterStatus.ItemHeight = 14;
            this.lst_CharacterStatus.Items.AddRange(new object[] {
            "Waiting for Clients"});
            this.lst_CharacterStatus.Location = new System.Drawing.Point(12, 36);
            this.lst_CharacterStatus.Name = "lst_CharacterStatus";
            this.lst_CharacterStatus.Size = new System.Drawing.Size(745, 224);
            this.lst_CharacterStatus.TabIndex = 24;
            this.lst_CharacterStatus.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_CharacterStatus_DrawItem);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.addClientToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // gbox_Settings
            // 
            this.gbox_Settings.Controls.Add(this.lbl_HideSettings);
            this.gbox_Settings.Controls.Add(this.txt_HeartBeatVal);
            this.gbox_Settings.Controls.Add(this.chck_HeartBeat);
            this.gbox_Settings.Controls.Add(this.btn_TestWp);
            this.gbox_Settings.Controls.Add(this.btn_TestNotify);
            this.gbox_Settings.Location = new System.Drawing.Point(12, 36);
            this.gbox_Settings.Name = "gbox_Settings";
            this.gbox_Settings.Size = new System.Drawing.Size(745, 222);
            this.gbox_Settings.TabIndex = 27;
            this.gbox_Settings.TabStop = false;
            this.gbox_Settings.Text = "Settings";
            this.gbox_Settings.Visible = false;
            // 
            // btn_TestNotify
            // 
            this.btn_TestNotify.Location = new System.Drawing.Point(506, 185);
            this.btn_TestNotify.Name = "btn_TestNotify";
            this.btn_TestNotify.Size = new System.Drawing.Size(112, 27);
            this.btn_TestNotify.TabIndex = 0;
            this.btn_TestNotify.Text = "Test Notify";
            this.btn_TestNotify.UseVisualStyleBackColor = true;
            this.btn_TestNotify.Click += new System.EventHandler(this.btn_TestNotify_Click);
            // 
            // btn_TestWp
            // 
            this.btn_TestWp.Location = new System.Drawing.Point(624, 185);
            this.btn_TestWp.Name = "btn_TestWp";
            this.btn_TestWp.Size = new System.Drawing.Size(112, 27);
            this.btn_TestWp.TabIndex = 1;
            this.btn_TestWp.Text = "Test WpMessage";
            this.btn_TestWp.UseVisualStyleBackColor = true;
            this.btn_TestWp.Click += new System.EventHandler(this.btn_TestWp_Click);
            // 
            // chck_HeartBeat
            // 
            this.chck_HeartBeat.AutoSize = true;
            this.chck_HeartBeat.Location = new System.Drawing.Point(27, 59);
            this.chck_HeartBeat.Name = "chck_HeartBeat";
            this.chck_HeartBeat.Size = new System.Drawing.Size(100, 17);
            this.chck_HeartBeat.TabIndex = 2;
            this.chck_HeartBeat.Text = "Client heartbeat";
            this.chck_HeartBeat.UseVisualStyleBackColor = true;
            this.chck_HeartBeat.CheckedChanged += new System.EventHandler(this.chck_HeartBeat_CheckedChanged);
            // 
            // txt_HeartBeatVal
            // 
            this.txt_HeartBeatVal.Location = new System.Drawing.Point(27, 33);
            this.txt_HeartBeatVal.Name = "txt_HeartBeatVal";
            this.txt_HeartBeatVal.Size = new System.Drawing.Size(100, 20);
            this.txt_HeartBeatVal.TabIndex = 3;
            this.txt_HeartBeatVal.Text = "30";
            this.txt_HeartBeatVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_HideSettings
            // 
            this.lbl_HideSettings.AutoSize = true;
            this.lbl_HideSettings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_HideSettings.Location = new System.Drawing.Point(720, 16);
            this.lbl_HideSettings.Name = "lbl_HideSettings";
            this.lbl_HideSettings.Size = new System.Drawing.Size(15, 14);
            this.lbl_HideSettings.TabIndex = 4;
            this.lbl_HideSettings.Text = "X";
            this.lbl_HideSettings.Click += new System.EventHandler(this.lbl_HideSettings_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(769, 270);
            this.Controls.Add(this.gbox_Settings);
            this.Controls.Add(this.lst_CharacterStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "MWatcher";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbox_Settings.ResumeLayout(false);
            this.gbox_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker DcChecker;
        private System.Windows.Forms.ListBox lst_CharacterStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbox_Settings;
        private System.Windows.Forms.TextBox txt_HeartBeatVal;
        private System.Windows.Forms.CheckBox chck_HeartBeat;
        private System.Windows.Forms.Button btn_TestWp;
        private System.Windows.Forms.Button btn_TestNotify;
        private System.Windows.Forms.Label lbl_HideSettings;
    }
}

