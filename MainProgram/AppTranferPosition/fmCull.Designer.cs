namespace AppTranferPosition
{
    partial class fmCull
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
            this.tbPositionId = new ToolsDocument.ucTextBox();
            this.ucDateTimePicker1 = new ToolsDocument.ucDateTimePicker();
            this.ucDataGridView1 = new ToolsDocument.ucDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.ucMappingControls1 = new ToolsDocument.ucMappingControls();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "การเลือกผู้แทนตำแหน่ง";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "รหัสตำแหน่ง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "วันที่เลือก";
            // 
            // tbPositionId
            // 
            this.tbPositionId._PasswordChar = '\0';
            this.tbPositionId._Value = "";
            this.tbPositionId._XPath = null;
            this.tbPositionId.BackColor = System.Drawing.Color.Transparent;
            this.tbPositionId.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbPositionId.Location = new System.Drawing.Point(116, 43);
            this.tbPositionId.MinimumSize = new System.Drawing.Size(0, 21);
            this.tbPositionId.Name = "tbPositionId";
            this.tbPositionId.Size = new System.Drawing.Size(237, 21);
            this.tbPositionId.TabIndex = 3;
            // 
            // ucDateTimePicker1
            // 
            this.ucDateTimePicker1._XPath = null;
            this.ucDateTimePicker1.Location = new System.Drawing.Point(116, 70);
            this.ucDateTimePicker1.Name = "ucDateTimePicker1";
            this.ucDateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.ucDateTimePicker1.TabIndex = 4;
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1._DataText = null;
            this.ucDataGridView1._XPath = null;
            this.ucDataGridView1.Location = new System.Drawing.Point(12, 147);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.Size = new System.Drawing.Size(498, 398);
            this.ucDataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "การลงคะแนนเสียง";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(362, 551);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(443, 551);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 8;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // ucMappingControls1
            // 
            this.ucMappingControls1.Location = new System.Drawing.Point(494, 12);
            this.ucMappingControls1.MaximumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.MinimumSize = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.Name = "ucMappingControls1";
            this.ucMappingControls1.Size = new System.Drawing.Size(24, 27);
            this.ucMappingControls1.TabIndex = 9;
            this.ucMappingControls1.Visible = false;
            // 
            // fmCull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 586);
            this.Controls.Add(this.ucMappingControls1);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ucDataGridView1);
            this.Controls.Add(this.ucDateTimePicker1);
            this.Controls.Add(this.tbPositionId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmCull";
            this.Text = "การเลือกผู้ดำรงตำแหน่ง";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ToolsDocument.ucTextBox tbPositionId;
        private ToolsDocument.ucDateTimePicker ucDateTimePicker1;
        private ToolsDocument.ucDataGridView ucDataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private ToolsDocument.ucMappingControls ucMappingControls1;
    }
}