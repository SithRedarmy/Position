using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AppTranferPosition
{
    public partial class fmPosition : Form
    {
        public fmPosition()
        {
            InitializeComponent();
        }

        public string Command;

        public string ID_TEMP;

        XmlDocument xDoc;

        public void funLoad()
        {

            xDoc = new XmlDocument();

            if (Command == "New")
            {
                xDoc.Load(Application.StartupPath + "//TempDoc/Position.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Position", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Position']";
            tbPositionID._XPath = RootPath + "/Item[@Name='ID_Position']";
            tbPosition._XPath = RootPath + "/Item[@Name='Position']";
            tbSalary._XPath = RootPath + "/Item[@Name='Salary']";
            tbMission._XPath = RootPath + "/Item[@Name='Mission']";
            tbDivision._XPath = RootPath + "/Item[@Name='Division']";
            tbLevel._XPath = RootPath + "/Item[@Name='Level']";
            ucComboBox1._XPath = RootPath + "/Item[@Name='Status']";

            ucDataGridView1._XPath = "//Document/Data/Section[@ID='2']/Items[@Name='PositionIn']";
            ucDataGridView2._XPath = "//Document/Data/Section[@ID='3']/Items[@Name='candidatePositionIn']";


            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbPositionID);
            ucMappingControls1.AddControl(tbPosition);
            ucMappingControls1.AddControl(tbSalary);
            ucMappingControls1.AddControl(tbMission);
            ucMappingControls1.AddControl(tbDivision);
            ucMappingControls1.AddControl(tbLevel);
            ucMappingControls1.AddControl(ucComboBox1);

            ucMappingControls1.AddControl(ucDataGridView1);
            ucMappingControls1.AddControl(ucDataGridView2);
        }

        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("ID_POSITION", tbPositionID._Value));
                NCS.Add(new NextwaverDB.NColumn("POSITION", tbPosition._Value));
                NCS.Add(new NextwaverDB.NColumn("SALARY", tbSalary._Value));
                NCS.Add(new NextwaverDB.NColumn("MISSION", tbMission._Value));
                NCS.Add(new NextwaverDB.NColumn("DIVISION", tbDivision._Value));
                NCS.Add(new NextwaverDB.NColumn("LEVEL", tbLevel._Value));
                NCS.Add(new NextwaverDB.NColumn("STATUS", ucComboBox1._SelectedText));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);


                if (Command == "New")
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Position", NCS, strDoc))
                    {
                        MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว", "สร้างใหม่");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก" + cCon.ErrorMsg(), "สร้างใหม่");
                    }

                }

                else
                {
                    NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
                    NWS.Add(new NextwaverDB.NWhere("ID", ID_TEMP));

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Position", NCS, NWS, strDoc))
                    {
                        MessageBox.Show("แก้ไขข้อมูลเรียบร้อย", "แก้ไขข้อมูล");
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกข้อมูลได้เนื่องจาก : " + cCon.ErrorMsg(), "แก้ไขข้อมูล");
                    }
                }

            }

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
