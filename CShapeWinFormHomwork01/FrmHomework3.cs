using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CShapeWinFormHomwork01
{
    public partial class FrmHomework3 : Form
    {
        public FrmHomework3()
        {
            InitializeComponent();
        }

        private void FrmHomework3_Load(object sender, EventArgs e)
        {

        }

        private void tbPay_TextChanged(object sender, EventArgs e)
        {

        }
        private bool validateInput(TextBox textBox, string message)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG(message);
                return false;
            }
            return true;
        }
        private void validateNumberInput(TextBox textBox, KeyPressEventArgs e, bool allowDecimal)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (!allowDecimal || e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (allowDecimal && e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btCal_Click_1(object sender, EventArgs e)
        {
            if (!validateInput(tbPay, "ป้อนจำนวนเงินด้วย") || !validateInput(tbPerson, "ป้อนจำนวนคนด้วย"))
                return;

            double money = Convert.ToDouble(tbPay.Text.Trim());
            int people = Convert.ToInt32(tbPerson.Text.Trim());
            lbPPP.Text = (money / people).ToString("0.00");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tbPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumberInput(sender as TextBox, e, true);
        }

        private void tbPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateNumberInput(sender as TextBox, e, true);
        }
    }
}
