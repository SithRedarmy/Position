namespace AppRegister
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSubID = new ToolsDocument.ucTextBox();
            this.tbSubName = new ToolsDocument.ucTextBox();
            this.tbTime = new ToolsDocument.ucTextBox();
            this.tbDay = new ToolsDocument.ucTextBox();
            this.tbTeacher = new ToolsDocument.ucTextBox();
            this.tbClass = new ToolsDocument.ucTextBox();
            this.ucMappingControls1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "วิชาเรียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "รหัสวิชา";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ชื่อวิชา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "เวลาเรียน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "วันที่เรียน";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "อาจารย์ผู้สอน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "ห้องเรียน";
            // 
            // tbSubID
            // 
            this.tbSubID._PasswordChar = '\0';
            this.tbSubID._Value = "";
            this.tbSubID._XPath = null;
            this.tbSubID.BackColor = System.Drawing.Color.Transparent;
            this.tbSubID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSubID.Location = new System.Drawing.Point(144, 53);
            this.tbSubID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSubID.Name = "tbSubID";
            this.tbSubID.Size = new System.Drawing.Size(237, 21);
            this.tbSubID.TabIndex = 9;
            // 
            // tbSubName
            // 
            this.tbSubName._PasswordChar = '\0';
            this.tbSubName._Value = "";
            this.tbSubName._XPath = null;
            this.tbSubName.BackColor = System.Drawing.Color.Transparent;
            this.tbSubName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSubName.Location = new System.Drawing.Point(144, 80);
            this.tbSubName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSubName.Name = "tbSubName";
            this.tbSubName.Size = new System.Drawing.Size(237, 21);
            this.tbSubName.TabIndex = 10;
            // 
            // tbTime
            // 
            this.tbTime._PasswordChar = '\0';
            this.tbTime._Value = "";
            this.tbTime._XPath = null;
            this.tbTime.BackColor = System.Drawing.Color.Transparent;
            this.tbTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTime.Location = new System.Drawing.Point(144, 107);
            this.tbTime.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(237, 21);
            this.tbTime.TabIndex = 11;
            // 
            // tbDay
            // 
            this.tbDay._PasswordChar = '\0';
            this.tbDay._Value = "";
            this.tbDay._XPath = null;
            this.tbDay.BackColor = System.Drawing.Color.Transparent;
            this.tbDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDay.Location = new System.Drawing.Point(144, 134);
            this.tbDay.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(237, 21);
            this.tbDay.TabIndex = 12;
            // 
            // tbTeacher
            // 
            this.tbTeacher._PasswordChar = '\0';
            this.tbTeacher._Value = "";
            this.tbTeacher._XPath = null;
            this.tbTeacher.BackColor = System.Drawing.Color.Transparent;
            this.tbTeacher.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTeacher.Location = new System.Drawing.Point(144, 161);
            this.tbTeacher.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(237, 21);
            this.tbTeacher.TabIndex = 13;
            // 
            // tbClass
            // 
            this.tbClass._PasswordChar = '\0';
            this.tbClass._Value = "";
            this.tbClass._XPath = null;
            this.tbClass.BackColor = System.Drawing.Color.Transparent;
            this.tbClass.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbClass.Location = new System.Drawing.Point(144, 188);
            this.tbClass.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(237, 21);
            this.tbClass.TabIndex = 14;
            // 
            // ucMappingControls1
            // 
            this.ucMappingControls1.Location = new System.Drawing.Point(389, 13);
            this.ucMappingControls1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.Name = "ucMappingControls1";
            this.ucMappingControls1.Size = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 257);
            this.Controls.Add(this.ucMappingControls1);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.tbTeacher);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbSubName);
            this.Controls.Add(this.tbSubID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ToolsDocument.ucTextBox tbSubID;
        private ToolsDocument.ucTextBox tbSubName;
        private ToolsDocument.ucTextBox tbTime;
        private ToolsDocument.ucTextBox tbDay;
        private ToolsDocument.ucTextBox tbTeacher;
        private ToolsDocument.ucTextBox tbClass;
        private ToolsDocument.ucMappingControls ucMappingControls1;
    }
}