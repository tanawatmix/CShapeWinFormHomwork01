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
    public partial class FrmHomework2 : Form
    {
        public FrmHomework2()
        {
            InitializeComponent();
        }

        private void FrmHomework2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            FrmHomework3 frmHomework3 = new FrmHomework3();
            frmHomework3.Show();
            Hide();
        }

        private void btCal_Click(object sender, EventArgs e)
        {
            //Validate
            if (tbStuID.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนรหัสประจำตัวด้วย");
            }
            else if (tbName.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนชื่อ-สกุลด้วย");
            }
            else if (tbMidTerm.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนสอบกลางภาคด้วย");

            }
            else if (tbFinal.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนสอบปลายภาคด้วย");

            }
            else if (tbScore.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG("ป้อนคะแนนเก็บด้วย");

            }
            else
            {
                lbStuID.Text = tbStuID.Text.Trim();
                lbName.Text = tbName.Text.Trim();
                int totalPoint = Convert.ToInt32(tbMidTerm.Text.Trim()) +
                    Convert.ToInt32(tbFinal.Text.Trim()) +
                    Convert.ToInt32(tbScore.Text.Trim());
                lbfinalScore.Text = totalPoint.ToString("0");
                string grade;
                if (totalPoint >= 80)
                    grade = "A";
                else if (totalPoint >= 70)
                    grade = "B";
                else if (totalPoint >= 60)
                    grade = "C";
                else if (totalPoint >= 50)
                    grade = "D";
                else
                    grade = "F";
                lbGrade.Text = grade;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            tbStuID.Clear();
            tbName.Clear();
            tbMidTerm.Clear();
            tbFinal.Clear();
            tbScore.Clear();
            lbStuID.Text = "XXXXXXXXX";
            lbName.Text = "XXXXXXXX";
            lbfinalScore.Text = "XXXXXXXX";
            lbGrade.Text = "XXXXXXXX";
        }
        private void tbStuID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbMidterm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }

        private void tbCollect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ป้องกันไม่ให้ป้อนอักขระที่ไม่ใช่ตัวเลข
            }
        }
    }
}

