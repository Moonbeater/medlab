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

namespace MedLab.Forms
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private string GenerateCodeBio(DateTime date)
        {
            string orderNumb = OrdersClass.GetMaxOrderNumber().ToString() + "·";

            string day = date.ToString("dd") + "·";

            string month = date.ToString("MM") + "·";

            string year = date.ToString("yyyy") + "·";

            Random rnd = new Random();

            string randCode = rnd.Next(0, 99).ToString() + "·" + rnd.Next(0, 99).ToString() + "·" + 
                rnd.Next(0, 99).ToString() + "·" + rnd.Next(0, 99).ToString() + "·" + rnd.Next(0, 99).ToString() + "·" + rnd.Next(0, 99).ToString();

            string code = orderNumb + day + month + year + randCode;

            return code;
        }

        private void GenerateCodeBtn_Click(object sender, EventArgs e)
        {
            TxtCodeBio.Text = GenerateCodeBio(OrderDTP.Value);
            AfterGenPanel.Enabled = true;
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            OrdersClass.GetCmbPatientsList();
            if (OrdersClass.dtCmbPatients.Rows.Count == 0)
            {
                PatientCB.Enabled = false;
            }
            PatientCB.DataSource = OrdersClass.dtCmbPatients;
            PatientCB.DisplayMember = "Fname";
            PatientCB.ValueMember = "IdPatient";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OrdersClass.AddOrder(TxtCodeBio.Text, OrderDTP.Value.ToString("yyyy-MM-dd"), PatientCB.SelectedValue.ToString(), "0"))
            {
                MessageBox.Show("Заказ успешно добавлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersClass.GetOrderList();
                this.Close();
            }
        }
    }
}
