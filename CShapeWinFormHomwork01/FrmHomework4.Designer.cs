namespace CShapeWinFormHomwork01
{
    partial class FrmHomework4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbiOS = new System.Windows.Forms.RadioButton();
            this.rbPHP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbShowPay = new System.Windows.Forms.Label();
            this.lbShowjoins = new System.Windows.Forms.Label();
            this.lbShowPro = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(337, 427);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "หมายเหตุ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "-กรณีเข้าอบรม 5 คนขึ้นไป ลด 10%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "-กรณีเข้าอบรม 2-4 คน ลด 5%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(183, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(655, 63);
            this.label4.TabIndex = 14;
            this.label4.Text = "โปรแกรมคำนวณค่าอบรม สัมมนา";
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Image = global::CShapeWinFormHomwork01.Properties.Resources.Power_icon;
            this.btExit.Location = new System.Drawing.Point(629, 622);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(188, 121);
            this.btExit.TabIndex = 15;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCancel.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit_icon;
            this.btCancel.Location = new System.Drawing.Point(403, 622);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(188, 121);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator_icon;
            this.btCal.Location = new System.Drawing.Point(192, 622);
            this.btCal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(188, 121);
            this.btCal.TabIndex = 17;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click_1);
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(269, 382);
            this.tbPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(456, 22);
            this.tbPeople.TabIndex = 19;
            this.tbPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPeople_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 379);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "จำนวนคนที่เข้าร่วม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "คน";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(268, 161);
            this.rbJava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(255, 20);
            this.rbJava.TabIndex = 20;
            this.rbJava.TabStop = true;
            this.rbJava.Text = "อบรม JAVA Developer (คนละ 1,000 บาท )";
            this.rbJava.UseVisualStyleBackColor = true;
            this.rbJava.Click += new System.EventHandler(this.rbJava_Click);
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(268, 209);
            this.rbAndroid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(268, 20);
            this.rbAndroid.TabIndex = 20;
            this.rbAndroid.TabStop = true;
            this.rbAndroid.Text = "อบรม Android Developer (คนละ 1,200 บาท )";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbiOS
            // 
            this.rbiOS.AutoSize = true;
            this.rbiOS.Location = new System.Drawing.Point(268, 266);
            this.rbiOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbiOS.Name = "rbiOS";
            this.rbiOS.Size = new System.Drawing.Size(243, 20);
            this.rbiOS.TabIndex = 20;
            this.rbiOS.TabStop = true;
            this.rbiOS.Text = "อบรม iOS Developer (คนละ 1,400 บาท )";
            this.rbiOS.UseVisualStyleBackColor = true;
            // 
            // rbPHP
            // 
            this.rbPHP.AutoSize = true;
            this.rbPHP.Location = new System.Drawing.Point(268, 316);
            this.rbPHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPHP.Name = "rbPHP";
            this.rbPHP.Size = new System.Drawing.Size(249, 20);
            this.rbPHP.TabIndex = 20;
            this.rbPHP.TabStop = true;
            this.rbPHP.Text = "อบรม PHP Developer (คนละ 1,600 บาท )";
            this.rbPHP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lbShowPay);
            this.groupBox2.Controls.Add(this.lbShowjoins);
            this.groupBox2.Controls.Add(this.lbShowPro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(927, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(599, 709);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // lbShowPay
            // 
            this.lbShowPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowPay.ForeColor = System.Drawing.Color.Red;
            this.lbShowPay.Location = new System.Drawing.Point(195, 539);
            this.lbShowPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowPay.Name = "lbShowPay";
            this.lbShowPay.Size = new System.Drawing.Size(227, 63);
            this.lbShowPay.TabIndex = 23;
            this.lbShowPay.Text = "XXX";
            this.lbShowPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShowjoins
            // 
            this.lbShowjoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowjoins.ForeColor = System.Drawing.Color.Red;
            this.lbShowjoins.Location = new System.Drawing.Point(195, 379);
            this.lbShowjoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowjoins.Name = "lbShowjoins";
            this.lbShowjoins.Size = new System.Drawing.Size(227, 63);
            this.lbShowjoins.TabIndex = 23;
            this.lbShowjoins.Text = "XXX";
            this.lbShowjoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShowPro
            // 
            this.lbShowPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowPro.ForeColor = System.Drawing.Color.Red;
            this.lbShowPro.Location = new System.Drawing.Point(195, 219);
            this.lbShowPro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbShowPro.Name = "lbShowPro";
            this.lbShowPro.Size = new System.Drawing.Size(227, 63);
            this.lbShowPro.TabIndex = 23;
            this.lbShowPro.Text = "XXX";
            this.lbShowPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(195, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 63);
            this.label9.TabIndex = 22;
            this.label9.Text = "สรุปข้อมูล";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(227, 476);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "ค่าอบรมที่ต้องชำระ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "จำนวนผู้เข้าร่วม";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 156);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "เข้าอบรมหัวข้อ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmHomework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 869);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rbPHP);
            this.Controls.Add(this.rbiOS);
            this.Controls.Add(this.rbAndroid);
            this.Controls.Add(this.rbJava);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmHomework4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbiOS;
        private System.Windows.Forms.RadioButton rbPHP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbShowPay;
        private System.Windows.Forms.Label lbShowjoins;
        private System.Windows.Forms.Label lbShowPro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}