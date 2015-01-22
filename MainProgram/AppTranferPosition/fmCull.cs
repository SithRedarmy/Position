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
    public partial class fmCull : Form
    {
        public fmCull()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/CullPosition.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "CullPosition", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='CullPosition']";
            tbPositionId._XPath = RootPath + "/Item[@Name='ID_Position']";
            ucDateTimePicker1._XPath = RootPath + "/Item[@Name='Consider_Date']";

            ucDataGridView1._XPath = "//Document/Data/Section[@ID='2']/Items[@Name='PositionIn']";


            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbPositionId);
            ucMappingControls1.AddControl(ucDateTimePicker1);

            ucMappingControls1.AddControl(ucDataGridView1);
        }

        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("ID_POSITION", tbPositionId._Value));
                NCS.Add(new NextwaverDB.NColumn("CONSIDER_DATE", ucDateTimePicker1._Day.ToString()));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);


                if (Command == "New")
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "CullPosition", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "CullPosition", NCS, NWS, strDoc))
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
