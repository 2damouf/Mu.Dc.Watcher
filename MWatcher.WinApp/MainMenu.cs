using MWatcher.Core.Helper;
using MWatcher.Entities;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace MWatcher.WinApp
{
    public partial class MainMenu : Form
    {
        MWatcher.Core.Operations BLL;
        public MainMenu()
        {

            BLL = new Core.Operations();
            InitializeComponent();
            DcChecker.WorkerSupportsCancellation = true;
        }
        private void DcChecker_DoWork(object sender, DoWorkEventArgs e)
        {
            lst_CharacterStatus.Items.Clear();
            foreach (var item in BaseClass.ClientList)
            {
                lst_CharacterStatus.Items.Add($"Client: {item.CharName}-{item.ClientId} Client Status: {item.CharStatus} Starting Date: {item.ClientStartDate} Package: {item.OldPackageValue}");
            }
            foreach (var item in BaseClass.DcList)
            {
                lst_CharacterStatus.Items.Add($"!!DC!! Karakter: {item.CharName}-{item.ClientId} Karakter Durumu: {item.CharStatus} Dc Time: {item.ClientDcDate}");
            }
            BLL.Run();
            Thread.Sleep(5000);
        }

        private void DcChecker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DcChecker.RunWorkerAsync();
        }

        private void InitializeListBox()
        {
            lst_CharacterStatus.DrawMode = DrawMode.OwnerDrawFixed;
            lst_CharacterStatus.DrawItem += new DrawItemEventHandler(lst_CharacterStatus_DrawItem);
            Controls.Add(lst_CharacterStatus);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            InitializeListBox();
        }

        private void lst_CharacterStatus_DrawItem(object sender, DrawItemEventArgs e)
        {

            GlobalProcs.TryCatch(() =>
            {
                string s = lst_CharacterStatus.Items[e.Index].ToString();
                e.DrawBackground();
                Brush myBrush = Brushes.Black;
                if (s.StartsWith("!!"))
                {
                    myBrush = Brushes.Red;
                }
                else
                {
                    myBrush = Brushes.DarkGreen;
                }
                e.Graphics.DrawString(lst_CharacterStatus.Items[e.Index].ToString(),
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                e.DrawFocusRectangle();
            });
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BaseClass.ClientList.Count > 0)
            {
                startToolStripMenuItem.Enabled = false;
                BLL.StartListWatcher();
                DcChecker.RunWorkerAsync();
                return;
            }
            MessageBox.Show("Client list is empty.", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientFrm frm = new ClientFrm();
            frm.Show();
        }

        private void btn_TestNotify_Click(object sender, EventArgs e)
        {
            BLL.TestNotify();
        }

        private void btn_TestWp_Click(object sender, EventArgs e)
        {
            BLL.TestWp();
        }

        private void lbl_HideSettings_Click(object sender, EventArgs e)
        {
            gbox_Settings.Visible = false;
            settingsToolStripMenuItem.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsToolStripMenuItem.Enabled = false;
            gbox_Settings.Visible = true;
        }


        private async void chck_HeartBeat_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_HeartBeat.Checked)
            {
                BaseClass.HeartBeat = true;
                await BLL.SendHeartBeatAsync(Convert.ToInt32(txt_HeartBeatVal.Text));
                return;
            }
            BaseClass.HeartBeat = false;
        }
    }
}
