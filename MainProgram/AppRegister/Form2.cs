using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ToolsDocument;

namespace AppRegister
{
    public partial class Form2 : Form
    {
        public Form2()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/SubTest.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "SubjectTable", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Subject']";

            tbSubID._XPath = RootPath + "/Item[@Name='SubID']";
            tbSubName._XPath = RootPath + "/Item[@Name='SubName']";
            tbTime._XPath = RootPath + "/Item[@Name='Time']";
            tbDay._XPath = RootPath + "/Item[@Name='Day']";
            tbTeacher._XPath = RootPath + "/Item[@Name='Teacher']";
            tbClass._XPath = RootPath + "/Item[@Name='Class']";


            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbSubID);
            ucMappingControls1.AddControl(tbSubName);
            ucMappingControls1.AddControl(tbTime);
            ucMappingControls1.AddControl(tbDay);
            ucMappingControls1.AddControl(tbTeacher);
            ucMappingControls1.AddControl(tbClass);
        }




        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("SUBID", tbSubID._Value));
                NCS.Add(new NextwaverDB.NColumn("SUBNAME", tbSubName._Value));
                NCS.Add(new NextwaverDB.NColumn("TIME", tbTime._Value));
                NCS.Add(new NextwaverDB.NColumn("DAY", tbDay._Value));
                NCS.Add(new NextwaverDB.NColumn("TEACHER", tbTeacher._Value));
                NCS.Add(new NextwaverDB.NColumn("CLASS", tbClass._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);


                if (Command == "New")
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "SubjectTable", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "SubjectTable", NCS, NWS, strDoc))
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

        private void button1_Click(object sender, EventArgs e)
        {
            funSave();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
