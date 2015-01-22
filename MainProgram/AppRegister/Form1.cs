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
    public partial class Form1 : Form
    {
        public Form1()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/TestRegister.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "RegisterSubjectTable", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='TestRegister']";
            tbID._XPath = RootPath + "/Item[@Name='StudentID']";
            tbName._XPath = RootPath + "/Item[@Name='StudentName']";
            tbMajor._XPath = RootPath + "/Item[@Name='Major']";
            tbFaculty._XPath = RootPath + "/Item[@Name='Faculty']";
            tbClassYear._XPath = RootPath + "/Item[@Name='ClassYear']";


            ucDataGridView1._XPath = "//Document/Data/Section[@ID='2']/Items[@Name='Subject']";
            

            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbID);
            ucMappingControls1.AddControl(tbName);
            ucMappingControls1.AddControl(tbMajor);
            ucMappingControls1.AddControl(tbFaculty);
            ucMappingControls1.AddControl(tbClassYear);


            ucMappingControls1.AddControl(ucDataGridView1);
        }

        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("STUDENTID", tbID._Value));
                NCS.Add(new NextwaverDB.NColumn("STUDENTNAME", tbName._Value));
                NCS.Add(new NextwaverDB.NColumn("CLASSYEAR", tbClassYear._Value));
                NCS.Add(new NextwaverDB.NColumn("EDUCATION", tbMajor._Value));
                NCS.Add(new NextwaverDB.NColumn("FACULTY", tbFaculty._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);

                
                if (Command == "New") 
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "RegisterSubjectTable", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "RegisterSubject", "RegisterSubjectTable", NCS, NWS, strDoc))
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
