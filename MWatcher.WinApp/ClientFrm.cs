using MWatcher.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MWatcher.WinApp
{
    public partial class ClientFrm : Form
    {
        readonly Core.Operations BLL;
        public ClientFrm()
        {
            BLL = new Core.Operations();
            InitializeComponent();
        }

        private void ClientFrm_Load(object sender, EventArgs e)
        {
            foreach (var item in BaseClass.ClientList)
            {
                lst_Clients.Items.Add($"Karakter: {item.CharName} ID: {item.ClientId}");
            }
        }

        private void btn_UpdateListProcc_Click(object sender, EventArgs e)
        {
            lst_Process.Items.Clear();
            Process[] processlist = Process.GetProcesses();

            foreach (var p in processlist)
            {
                if (p.ProcessName == "main")
                {
                    lst_Process.Items.Add(p.Id);
                }
            }
        }

        private void btn_CreateClient_Click(object sender, EventArgs e)
        {
            BLL.SetCharacter(txt_CharName.Text, Convert.ToInt64(txt_Id.Text), DateTime.Now, true);
            lst_Clients.Items.Clear();
            foreach (var item in BaseClass.ClientList)
            {
                lst_Clients.Items.Add($"Karakter: {item.CharName} ID: {item.ClientId}");
            }
        }

        private void lst_Process_DoubleClick(object sender, EventArgs e)
        {
            txt_Id.Text = lst_Process.SelectedItem.ToString();
            txt_CharName.Focus();
        }
    }
}
