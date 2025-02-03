namespace CShapeWinFormHomwork01
{
    partial class FrmHomework2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.tbMidTerm = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbStuID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCal = new System.Windows.Forms.Button();
            this.btCan = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStuID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbfinalScore = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(317, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "โปรแกรมผลการเรียน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbScore);
            this.groupBox1.Controls.Add(this.tbFinal);
            this.groupBox1.Controls.Add(this.tbMidTerm);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbStuID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 133);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(953, 327);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลนักศึกษา";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(240, 260);
            this.tbScore.Margin = new System.Windows.Forms.Padding(4);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(644, 22);
            this.tbScore.TabIndex = 1;
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(240, 207);
            this.tbFinal.Margin = new System.Windows.Forms.Padding(4);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(644, 22);
            this.tbFinal.TabIndex = 1;
            // 
            // tbMidTerm
            // 
            this.tbMidTerm.Location = new System.Drawing.Point(240, 154);
            this.tbMidTerm.Margin = new System.Windows.Forms.Padding(4);
            this.tbMidTerm.Name = "tbMidTerm";
            this.tbMidTerm.Size = new System.Drawing.Size(644, 22);
            this.tbMidTerm.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(240, 101);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(644, 22);
            this.tbName.TabIndex = 1;
            // 
            // tbStuID
            // 
            this.tbStuID.Location = new System.Drawing.Point(240, 48);
            this.tbStuID.Margin = new System.Windows.Forms.Padding(4);
            this.tbStuID.Name = "tbStuID";
            this.tbStuID.Size = new System.Drawing.Size(644, 22);
            this.tbStuID.TabIndex = 1;
            this.tbStuID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "คะแนนปลายภาค";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "คะแนนเก็บ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "คะแนนกลางภาค";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "ชื่อ-สกุล";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสนักศึกษา";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btCal
            // 
            this.btCal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCal.Image = global::CShapeWinFormHomwork01.Properties.Resources.calculator_icon;
            this.btCal.Location = new System.Drawing.Point(247, 481);
            this.btCal.Margin = new System.Windows.Forms.Padding(4);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(152, 139);
            this.btCal.TabIndex = 4;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = false;
            // 
            // btCan
            // 
            this.btCan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btCan.Image = global::CShapeWinFormHomwork01.Properties.Resources.exit_icon;
            this.btCan.Location = new System.Drawing.Point(464, 481);
            this.btCan.Margin = new System.Windows.Forms.Padding(4);
            this.btCan.Name = "btCan";
            this.btCan.Size = new System.Drawing.Size(152, 139);
            this.btCan.TabIndex = 4;
            this.btCan.Text = "ยกเลิก";
            this.btCan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCan.UseVisualStyleBackColor = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btExit.Image = global::CShapeWinFormHomwork01.Properties.Resources.Power_icon;
            this.btExit.Location = new System.Drawing.Point(691, 481);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(152, 139);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 657);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "รหัสนักศึกษา";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 705);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "ชื่อ-สกุล";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(120, 801);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "เกรด";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 753);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "คะแนนรวม";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbStuID
            // 
            this.lbStuID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbStuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStuID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbStuID.Location = new System.Drawing.Point(289, 657);
            this.lbStuID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStuID.Name = "lbStuID";
            this.lbStuID.Size = new System.Drawing.Size(649, 28);
            this.lbStuID.TabIndex = 5;
            this.lbStuID.Text = "XXXXXXXXXXXXX";
            this.lbStuID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbName.Location = new System.Drawing.Point(289, 705);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(649, 28);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "XXXXXXXXXXXXX";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbfinalScore
            // 
            this.lbfinalScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbfinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfinalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbfinalScore.Location = new System.Drawing.Point(289, 753);
            this.lbfinalScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbfinalScore.Name = "lbfinalScore";
            this.lbfinalScore.Size = new System.Drawing.Size(649, 28);
            this.lbfinalScore.TabIndex = 5;
            this.lbfinalScore.Text = "XXXXXXXXXXXXX";
            this.lbfinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGrade
            // 
            this.lbGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbGrade.Location = new System.Drawing.Point(289, 801);
            this.lbGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(649, 28);
            this.lbGrade.TabIndex = 5;
            this.lbGrade.Text = "XXXXXXXXXXXXX";
            this.lbGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmHomework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 860);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbfinalScore);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbStuID);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCan);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHomework2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 2";
            this.Load += new System.EventHandler(this.FrmHomework2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.TextBox tbMidTerm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbStuID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btCan;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbStuID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbfinalScore;
        private System.Windows.Forms.Label lbGrade;
    }
}