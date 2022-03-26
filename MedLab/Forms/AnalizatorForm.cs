using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedLabAnalizatorDLL;
using MedLab.Classes;

namespace MedLab.Forms
{
    public partial class AnalizatorForm : Form
    {
        public AnalizatorForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int i = 1;

        private void ResearchTimer_Tick(object sender, EventArgs e)
        {
            i++;
            
            if (i == 5)
            {
                TxtResult.Text = Analizator.ResultAnalizator(OrderServicesForm.idService, AnalizatorCB.Text);
                SendToResearchBtn.Enabled = true;
                if (TxtResult.Text == "Не верно выбран анализатор" || TxtResult.Text == "Сбой исследования")
                {
                    AcceptResultBtn.Enabled = false;
                }
                else
                {
                    AcceptResultBtn.Enabled = true;
                }
                LoadingPB.Hide();
                AnalizBar.Hide();
                CancelBtn.Enabled = true;
                ResearchTimer.Stop();
            }
            AnalizBar.Value = i;
        }

        private void SendToResearchBtn_Click(object sender, EventArgs e)
        {
            if (AnalizatorCB.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран анализатор", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            i = 1;
            AcceptResultBtn.Enabled = false;
            CancelBtn.Enabled = false;
            AnalizBar.Minimum = 1;
            AnalizBar.Maximum = 5;
            AnalizBar.Value = 1;
            AnalizBar.Show();
            LoadingPB.Show();

            SendToResearchBtn.Enabled = false;
            ResearchTimer.Start();
        }

        private void AcceptResultBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(OrderServicesForm.idOrdService.ToString());
            OrdersClass.ResearchService(OrderServicesForm.idOrdService, TxtResult.Text, "Выполнено");
            MessageBox.Show("Результат исследований успешно записан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OrdersClass.GetOrderServices(OrdersForm.idOrder);
            this.Close();
        }
    }
}
