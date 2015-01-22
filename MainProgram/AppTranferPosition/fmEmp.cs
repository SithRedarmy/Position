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
    public partial class fmEmp : Form
    {
        public fmEmp()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/Employee.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Employee", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Employee']";
            tbEmpID._XPath = RootPath + "/Item[@Name='ID_Emp']";
            tbNameEmp._XPath = RootPath + "/Item[@Name='Name_Emp']";
            tbAdd._XPath = RootPath + "/Item[@Name='Address']";
            tbTel._XPath = RootPath + "/Item[@Name='Tel']";
            ucDateTimePicker1._XPath = RootPath + "/Item[@Name='Birth_Date']";
            
            

            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbEmpID);
            ucMappingControls1.AddControl(tbNameEmp);
            ucMappingControls1.AddControl(tbAdd);
            ucMappingControls1.AddControl(tbTel);
            ucMappingControls1.AddControl(ucDateTimePicker1);
        }


        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("ID_EMP", tbEmpID._Value));
                NCS.Add(new NextwaverDB.NColumn("NAME_EMP", tbNameEmp._Value));
                NCS.Add(new NextwaverDB.NColumn("ADDRESS", tbAdd._Value));
                NCS.Add(new NextwaverDB.NColumn("TEL", tbTel._Value));
                NCS.Add(new NextwaverDB.NColumn("BIRTH_DATE", ucDateTimePicker1._Day.ToString() + "/" + ucDateTimePicker1._Month.ToString() + "/" + ucDateTimePicker1._Year.ToString()));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);


                if (Command == "New")
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Employee", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Employee", NCS, NWS, strDoc))
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
