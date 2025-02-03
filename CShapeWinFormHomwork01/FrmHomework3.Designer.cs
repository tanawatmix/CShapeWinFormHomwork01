namespace CShapeWinFormHomwork01
{
    partial class FrmHomework3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework3));
            this.btExit = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.tbPerson = new System.Windows.Forms.TextBox();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPPP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Image = global::CShapeWinFormHomwork01.Properties.Resources.Power_icon;
            this.btExit.Location = new System.Drawing.Point(699, 332);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(309, 143);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator_icon;
            this.btCal.Location = new System.Drawing.Point(363, 332);
            this.btCal.Margin = new System.Windows.Forms.Padding(4);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(309, 143);
            this.btCal.TabIndex = 6;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            this.btCal.Click += new System.EventHandler(this.btCal_Click_1);
            // 
            // tbPerson
            // 
            this.tbPerson.Location = new System.Drawing.Point(363, 254);
            this.tbPerson.Margin = new System.Windows.Forms.Padding(4);
            this.tbPerson.Name = "tbPerson";
            this.tbPerson.Size = new System.Drawing.Size(644, 22);
            this.tbPerson.TabIndex = 9;
            this.tbPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPerson_KeyPress);
            // 
            // tbPay
            // 
            this.tbPay.Location = new System.Drawing.Point(363, 181);
            this.tbPay.Margin = new System.Windows.Forms.Padding(4);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(644, 22);
            this.tbPay.TabIndex = 10;
            this.tbPay.TextChanged += new System.EventHandler(this.tbPay_TextChanged);
            this.tbPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPay_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "จำนวนคนที่จะหาร";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "จำนวนเงินที่จะหาร";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPPP
            // 
            this.lbPPP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbPPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPPP.ForeColor = System.Drawing.Color.Red;
            this.lbPPP.Location = new System.Drawing.Point(349, 538);
            this.lbPPP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPPP.Name = "lbPPP";
            this.lbPPP.Size = new System.Drawing.Size(649, 139);
            this.lbPPP.TabIndex = 12;
            this.lbPPP.Text = "xx.xx";
            this.lbPPP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 593);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "หารคนละ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1019, 593);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "บาท";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(329, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(583, 63);
            this.label4.TabIndex = 13;
            this.label4.Text = "โปรแกรม American Share";
            // 
            // FrmHomework3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPPP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPerson);
            this.Controls.Add(this.tbPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHomework3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 3";
            this.Load += new System.EventHandler(this.FrmHomework3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.TextBox tbPerson;
        private System.Windows.Forms.TextBox tbPay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPPP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}