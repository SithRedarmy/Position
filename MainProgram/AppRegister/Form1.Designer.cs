namespace AppRegister
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new ToolsDocument.ucTextBox();
            this.tbName = new ToolsDocument.ucTextBox();
            this.tbFaculty = new ToolsDocument.ucTextBox();
            this.tbMajor = new ToolsDocument.ucTextBox();
            this.tbClassYear = new ToolsDocument.ucTextBox();
            this.ucDataGridView1 = new ToolsDocument.ucDataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.ucMappingControls1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ลงทะเบียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "รหัสนักศึกษา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "คณะ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "สาขา";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ชั้นปี";
            // 
            // tbID
            // 
            this.tbID._PasswordChar = '\0';
            this.tbID._Value = "";
            this.tbID._XPath = null;
            this.tbID.BackColor = System.Drawing.Color.Transparent;
            this.tbID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbID.Location = new System.Drawing.Point(87, 96);
            this.tbID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(237, 21);
            this.tbID.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName._PasswordChar = '\0';
            this.tbName._Value = "";
            this.tbName._XPath = null;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbName.Location = new System.Drawing.Point(87, 123);
            this.tbName.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(237, 21);
            this.tbName.TabIndex = 7;
            // 
            // tbFaculty
            // 
            this.tbFaculty._PasswordChar = '\0';
            this.tbFaculty._Value = "";
            this.tbFaculty._XPath = null;
            this.tbFaculty.BackColor = System.Drawing.Color.Transparent;
            this.tbFaculty.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbFaculty.Location = new System.Drawing.Point(87, 150);
            this.tbFaculty.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.Size = new System.Drawing.Size(237, 21);
            this.tbFaculty.TabIndex = 8;
            // 
            // tbMajor
            // 
            this.tbMajor._PasswordChar = '\0';
            this.tbMajor._Value = "";
            this.tbMajor._XPath = null;
            this.tbMajor.BackColor = System.Drawing.Color.Transparent;
            this.tbMajor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbMajor.Location = new System.Drawing.Point(87, 177);
            this.tbMajor.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbMajor.Name = "tbMajor";
            this.tbMajor.Size = new System.Drawing.Size(237, 21);
            this.tbMajor.TabIndex = 9;
            // 
            // tbClassYear
            // 
            this.tbClassYear._PasswordChar = '\0';
            this.tbClassYear._Value = "";
            this.tbClassYear._XPath = null;
            this.tbClassYear.BackColor = System.Drawing.Color.Transparent;
            this.tbClassYear.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbClassYear.Location = new System.Drawing.Point(87, 204);
            this.tbClassYear.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbClassYear.Name = "tbClassYear";
            this.tbClassYear.Size = new System.Drawing.Size(237, 21);
            this.tbClassYear.TabIndex = 10;
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1._DataText = null;
            this.ucDataGridView1._XPath = null;
            this.ucDataGridView1.Location = new System.Drawing.Point(13, 254);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Size = new System.Drawing.Size(498, 342);
            this.ucDataGridView1.TabIndex = 11;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(355, 602);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(436, 602);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 13;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ucMappingControls1
            // 
            this.ucMappingControls1.Location = new System.Drawing.Point(492, 13);
            this.ucMappingControls1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.Name = "ucMappingControls1";
            this.ucMappingControls1.Size = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.TabIndex = 14;
            this.ucMappingControls1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 641);
            this.Controls.Add(this.ucMappingControls1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.ucDataGridView1);
            this.Controls.Add(this.tbClassYear);
            this.Controls.Add(this.tbMajor);
            this.Controls.Add(this.tbFaculty);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private ToolsDocument.ucTextBox tbID;
        private ToolsDocument.ucTextBox tbName;
        private ToolsDocument.ucTextBox tbFaculty;
        private ToolsDocument.ucTextBox tbMajor;
        private ToolsDocument.ucTextBox tbClassYear;
        private ToolsDocument.ucDataGridView ucDataGridView1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private ToolsDocument.ucMappingControls ucMappingControls1;
    }
}

