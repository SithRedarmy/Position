using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRegister
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SubjectTable' table. You can move, or remove it, as needed.
            this.SubjectTableTableAdapter.Fill(this.DataSet1.SubjectTable);

            this.reportViewer1.RefreshReport();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.SubjectTableTableAdapter.Fill(this.DataSet1.SubjectTable);
            }
            else
            {
                this.SubjectTableTableAdapter.FillBy(this.DataSet1.SubjectTable, textBox1.Text);
            }

            this.reportViewer1.RefreshReport();
        }
    }
}
