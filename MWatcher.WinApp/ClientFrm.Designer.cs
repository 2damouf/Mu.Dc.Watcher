namespace MWatcher.WinApp
{
    partial class ClientFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_CharName = new System.Windows.Forms.TextBox();
            this.btn_CreateClient = new System.Windows.Forms.Button();
            this.btn_UpdateListProcc = new System.Windows.Forms.Button();
            this.lst_Process = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_Clients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "CharName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ProccID";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(78, 246);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(139, 20);
            this.txt_Id.TabIndex = 24;
            // 
            // txt_CharName
            // 
            this.txt_CharName.Location = new System.Drawing.Point(298, 246);
            this.txt_CharName.Name = "txt_CharName";
            this.txt_CharName.Size = new System.Drawing.Size(139, 20);
            this.txt_CharName.TabIndex = 23;
            // 
            // btn_CreateClient
            // 
            this.btn_CreateClient.Location = new System.Drawing.Point(443, 243);
            this.btn_CreateClient.Name = "btn_CreateClient";
            this.btn_CreateClient.Size = new System.Drawing.Size(161, 23);
            this.btn_CreateClient.TabIndex = 22;
            this.btn_CreateClient.Text = "Add Client";
            this.btn_CreateClient.UseVisualStyleBackColor = true;
            this.btn_CreateClient.Click += new System.EventHandler(this.btn_CreateClient_Click);
            // 
            // btn_UpdateListProcc
            // 
            this.btn_UpdateListProcc.Location = new System.Drawing.Point(21, 217);
            this.btn_UpdateListProcc.Name = "btn_UpdateListProcc";
            this.btn_UpdateListProcc.Size = new System.Drawing.Size(257, 23);
            this.btn_UpdateListProcc.TabIndex = 28;
            this.btn_UpdateListProcc.Text = "Update List";
            this.btn_UpdateListProcc.UseVisualStyleBackColor = true;
            this.btn_UpdateListProcc.Click += new System.EventHandler(this.btn_UpdateListProcc_Click);
            // 
            // lst_Process
            // 
            this.lst_Process.BackColor = System.Drawing.Color.Azure;
            this.lst_Process.FormattingEnabled = true;
            this.lst_Process.Location = new System.Drawing.Point(21, 29);
            this.lst_Process.Name = "lst_Process";
            this.lst_Process.Size = new System.Drawing.Size(257, 173);
            this.lst_Process.TabIndex = 27;
            this.lst_Process.DoubleClick += new System.EventHandler(this.lst_Process_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Procc List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Client List";
            // 
            // lst_Clients
            // 
            this.lst_Clients.BackColor = System.Drawing.Color.Azure;
            this.lst_Clients.FormattingEnabled = true;
            this.lst_Clients.Location = new System.Drawing.Point(298, 29);
            this.lst_Clients.Name = "lst_Clients";
            this.lst_Clients.Size = new System.Drawing.Size(306, 212);
            this.lst_Clients.TabIndex = 30;
            // 
            // ClientFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(621, 275);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.txt_CharName);
            this.Controls.Add(this.btn_CreateClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_Clients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_UpdateListProcc);
            this.Controls.Add(this.lst_Process);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientFrm";
            this.Text = "ClientFrm";
            this.Load += new System.EventHandler(this.ClientFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_CharName;
        private System.Windows.Forms.Button btn_CreateClient;
        private System.Windows.Forms.Button btn_UpdateListProcc;
        private System.Windows.Forms.ListBox lst_Process;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_Clients;
    }
}