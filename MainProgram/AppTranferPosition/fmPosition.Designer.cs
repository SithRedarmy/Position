namespace AppTranferPosition
{
    partial class fmPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPosition));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucDataGridView1 = new ToolsDocument.ucDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucDataGridView2 = new ToolsDocument.ucDataGridView();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPositionID = new ToolsDocument.ucTextBox();
            this.tbPosition = new ToolsDocument.ucTextBox();
            this.tbSalary = new ToolsDocument.ucTextBox();
            this.tbMission = new ToolsDocument.ucTextBox();
            this.tbDivision = new ToolsDocument.ucTextBox();
            this.tbLevel = new ToolsDocument.ucTextBox();
            this.ucComboBox1 = new ToolsDocument.ucComboBox();
            this.ucMappingControls1 = new ToolsDocument.ucMappingControls();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 274);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 427);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ประวัติผู้ตำรงตำแหน่ง";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1._DataText = null;
            this.ucDataGridView1._XPath = null;
            this.ucDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Size = new System.Drawing.Size(498, 398);
            this.ucDataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucDataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ผู้มีความเหมาะสม";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucDataGridView2
            // 
            this.ucDataGridView2._DataText = null;
            this.ucDataGridView2._XPath = null;
            this.ucDataGridView2.Location = new System.Drawing.Point(1, 0);
            this.ucDataGridView2.Name = "ucDataGridView2";
            this.ucDataGridView2.Size = new System.Drawing.Size(498, 398);
            this.ucDataGridView2.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(365, 707);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(446, 707);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ตำแหน่งงาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "รหัสตำแหน่ง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ตำแหน่ง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "เงินเดือน";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "หน้าที่";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "แผนก";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "ระดับ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "สถานะ";
            // 
            // tbPositionID
            // 
            this.tbPositionID._PasswordChar = '\0';
            this.tbPositionID._Value = "";
            this.tbPositionID._XPath = null;
            this.tbPositionID.BackColor = System.Drawing.Color.Transparent;
            this.tbPositionID.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPositionID.Location = new System.Drawing.Point(184, 63);
            this.tbPositionID.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPositionID.Name = "tbPositionID";
            this.tbPositionID.Size = new System.Drawing.Size(237, 21);
            this.tbPositionID.TabIndex = 11;
            // 
            // tbPosition
            // 
            this.tbPosition._PasswordChar = '\0';
            this.tbPosition._Value = "";
            this.tbPosition._XPath = null;
            this.tbPosition.BackColor = System.Drawing.Color.Transparent;
            this.tbPosition.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPosition.Location = new System.Drawing.Point(184, 91);
            this.tbPosition.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(237, 21);
            this.tbPosition.TabIndex = 12;
            // 
            // tbSalary
            // 
            this.tbSalary._PasswordChar = '\0';
            this.tbSalary._Value = "";
            this.tbSalary._XPath = null;
            this.tbSalary.BackColor = System.Drawing.Color.Transparent;
            this.tbSalary.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbSalary.Location = new System.Drawing.Point(184, 119);
            this.tbSalary.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(237, 21);
            this.tbSalary.TabIndex = 13;
            // 
            // tbMission
            // 
            this.tbMission._PasswordChar = '\0';
            this.tbMission._Value = "";
            this.tbMission._XPath = null;
            this.tbMission.BackColor = System.Drawing.Color.Transparent;
            this.tbMission.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbMission.Location = new System.Drawing.Point(184, 146);
            this.tbMission.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbMission.Name = "tbMission";
            this.tbMission.Size = new System.Drawing.Size(237, 21);
            this.tbMission.TabIndex = 14;
            // 
            // tbDivision
            // 
            this.tbDivision._PasswordChar = '\0';
            this.tbDivision._Value = "";
            this.tbDivision._XPath = null;
            this.tbDivision.BackColor = System.Drawing.Color.Transparent;
            this.tbDivision.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbDivision.Location = new System.Drawing.Point(184, 174);
            this.tbDivision.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Size = new System.Drawing.Size(237, 21);
            this.tbDivision.TabIndex = 15;
            // 
            // tbLevel
            // 
            this.tbLevel._PasswordChar = '\0';
            this.tbLevel._Value = "";
            this.tbLevel._XPath = null;
            this.tbLevel.BackColor = System.Drawing.Color.Transparent;
            this.tbLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbLevel.Location = new System.Drawing.Point(184, 202);
            this.tbLevel.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(237, 21);
            this.tbLevel.TabIndex = 16;
            // 
            // ucComboBox1
            // 
            this.ucComboBox1._DataSourceID = null;
            this.ucComboBox1._DisplayMember = null;
            this.ucComboBox1._SelectedIndex = -1;
            this.ucComboBox1._SelectedText = "";
            this.ucComboBox1._SelectedValue = "";
            this.ucComboBox1._ValueMember = null;
            this.ucComboBox1._XPath = null;
            this.ucComboBox1.Location = new System.Drawing.Point(184, 229);
            this.ucComboBox1.Name = "ucComboBox1";
            this.ucComboBox1.Size = new System.Drawing.Size(177, 21);
            this.ucComboBox1.TabIndex = 17;
            // 
            // ucMappingControls1
            // 
            this.ucMappingControls1.Location = new System.Drawing.Point(12, 707);
            this.ucMappingControls1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.Name = "ucMappingControls1";
            this.ucMappingControls1.Size = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.TabIndex = 18;
            this.ucMappingControls1.Visible = false;
            // 
            // fmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 742);
            this.Controls.Add(this.ucMappingControls1);
            this.Controls.Add(this.ucComboBox1);
            this.Controls.Add(this.tbLevel);
            this.Controls.Add(this.tbDivision);
            this.Controls.Add(this.tbMission);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.tbPositionID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "fmPosition";
            this.Text = "ตำแหน่ง";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ToolsDocument.ucDataGridView ucDataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ToolsDocument.ucTextBox tbPositionID;
        private ToolsDocument.ucTextBox tbPosition;
        private ToolsDocument.ucTextBox tbSalary;
        private ToolsDocument.ucTextBox tbMission;
        private ToolsDocument.ucTextBox tbDivision;
        private ToolsDocument.ucTextBox tbLevel;
        private ToolsDocument.ucDataGridView ucDataGridView2;
        private ToolsDocument.ucComboBox ucComboBox1;
        private ToolsDocument.ucMappingControls ucMappingControls1;
    }
}