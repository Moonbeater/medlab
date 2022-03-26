using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedLab.Classes;
using MedLabAnalizatorDLL;

namespace MedLab.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из программы?","Внимание",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        static public string role;

        private void EnterAsLaborantBtn_Click(object sender, EventArgs e)
        {
            role = "laborant";
            OrdersForm of = new OrdersForm();
            this.Hide();
            of.ShowDialog();
        }

        private void EnterAsResearcherBtn_Click(object sender, EventArgs e)
        {
            role = "researcher";
            OrdersForm of = new OrdersForm();
            this.Hide();
            of.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connect())
            {
                MessageBox.Show("Ошибка при подключении к БД");
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBConnection.Disconnect();
        }
    }
}
