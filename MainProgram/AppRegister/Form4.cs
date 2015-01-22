using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppRegister
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.RegisterSubjectTable' table. You can move, or remove it, as needed.
            this.RegisterSubjectTableTableAdapter.Fill(this.DataSet2.RegisterSubjectTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
