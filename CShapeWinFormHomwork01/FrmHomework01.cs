﻿using System;
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
    public partial class FrmHomework01 : Form
    {
        public FrmHomework01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("January - มกราคม");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("February - กุมภาพันธ์");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("March - มีนาคม");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("April - เมษายน");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("May - พฤษภาคม");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("June - มิถุนายน");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("July - กรกฎาคม");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("August - สิงหาคม");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("September - กันยายน");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("October - ตุลาคม");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("November - พฤศจิกายน");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShareData.showDialogMSG("December - ธันวาคม");
        }
    }
}
