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
    public partial class FrmHomework4 : Form
    {
        public FrmHomework4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbJava_Click(object sender, EventArgs e)
        {

        }        
        // กำหนดให้ tbAmountPeople รับเฉพาะตัวเลขเท่านั้น
        private void tbPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        // ปุ่มคำนวณราคาคอร์สเรียน
        private void btCal_Click_1(object sender, EventArgs e)
        {
            // ตรวจสอบว่าผู้ใช้ป้อนจำนวนคนหรือไม่
            if (!validateInput(tbPeople, "ป้อนจำนวนคนด้วย")) return;

            // แปลงค่าข้อมูลที่ป้อนเป็นจำนวนเต็ม
            int people = Convert.ToInt32(tbPeople.Text.Trim());

            // ดึงราคาต่อคนตามประเภทคอร์สที่เลือก
            double pricePerPerson = getPricePerPerson();

            // คำนวณราคาก่อนหักส่วนลด
            double totalPrice = pricePerPerson * people;

            // คำนวณส่วนลดตามจำนวนคน
            double discount = getDiscount(totalPrice, people);

            // คำนวณราคาสุทธิหลังหักส่วนลด
            double totalPay = totalPrice - discount;

            // แสดงผลลัพธ์บน Label
            lbShowjoins.Text = people.ToString();
            lbShowPay.Text = totalPay.ToString("0.00");
        }

        // ฟังก์ชันตรวจสอบว่าผู้ใช้ป้อนค่าหรือไม่
        private bool validateInput(TextBox textBox, string message)
        {
            if (textBox.Text.Trim().Length == 0)
            {
                ShareData.showWarningMSG(message);
                return false;
            }
            return true;
        }

        // ฟังก์ชันคืนค่าราคาต่อคน ตามคอร์สที่เลือก
        private double getPricePerPerson()
        {
            if (rbJava.Checked) { lbShowPro.Text = "JAVA Developer"; return 1000; }
            if (rbAndroid.Checked) { lbShowPro.Text = "Android Developer"; return 1200; }
            if (rbiOS.Checked) { lbShowPro.Text = "iOS Developer"; return 1400; }

            // หากเลือก PHP
            lbShowPro.Text = "PHP Developer";
            return 1600;
        }

        // ฟังก์ชันคำนวณส่วนลดจากจำนวนคน
        private double getDiscount(double totalPrice, int people)
        {
            if (people >= 5) return totalPrice * 0.10; // ลด 10% เมื่อมี 5 คนขึ้นไป
            if (people >= 2) return totalPrice * 0.05; // ลด 5% เมื่อมี 2-4 คน
            return 0; // ไม่มีส่วนลด
        }

        // ปุ่มยกเลิก ล้างค่าและคืนค่ากลับเป็นค่าเริ่มต้น
        private void btCancel_Click_1(object sender, EventArgs e)
        {
            tbPeople.Clear();
            rbJava.Checked = true;
            lbShowPro.Text = lbShowjoins.Text = lbShowPay.Text = "XXX";
        }
        // ปุ่มปิดโปรแกรม
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมใช่มั้ย", "ยืนยัน",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
