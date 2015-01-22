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
    public partial class fmBoard : Form
    {
        public fmBoard()
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
                xDoc.Load(Application.StartupPath + "//TempDoc/Board.xml");
            }
            else
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.user);
                string strDoc = cConn.getLastDoc(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Board", int.Parse(ID_TEMP));
                xDoc.LoadXml(strDoc);
            }

            string RootPath = "//Document/Data/Section[@ID='1']/Items[@Name='Board']";
            tbID_Board._XPath = RootPath + "/Item[@Name='ID_Board']";
            tbNameBoard._XPath = RootPath + "/Item[@Name='Name_Board']";
            tbPositoinInBoard._XPath = RootPath + "/Item[@Name='Board_Position']";
            

            //คำสั่งในการ Map Control กับ Xml
            ucMappingControls1._XmlDocument = xDoc;
            ucMappingControls1.AddControl(tbID_Board);
            ucMappingControls1.AddControl(tbNameBoard);
            ucMappingControls1.AddControl(tbPositoinInBoard);
        }


        public void funSave()
        {
            if (ucMappingControls1.funSaveXml())
            {
                string strDoc = xDoc.OuterXml;
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("ID_BOARD", tbID_Board._Value));
                NCS.Add(new NextwaverDB.NColumn("NAME_BOARD", tbNameBoard._Value));
                NCS.Add(new NextwaverDB.NColumn("BOARD_POSITION", tbPositoinInBoard._Value));

                ConnectServer.cConection cCon = new ConnectServer.cConection(cMain.user);


                if (Command == "New")
                {

                    if (cCon.InsertData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Board", NCS, strDoc))
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

                    if (cCon.UpdateData(cMain.strConnect, cMain.OfficeSpaceId, "TransferPosition", "Board", NCS, NWS, strDoc))
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
