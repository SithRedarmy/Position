using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using NextProcess;
using System.Xml;
using CompanyData;

namespace AppRegister
{
    public class cMain
    {
        public static string strConnect;
        public static string user;
        public static string OfficeSpaceId;

        public bool New(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            Form1 form = new Form1();
            form.Command = "New";
            form.funLoad();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
            
            return false;
        }

        public bool Edit(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            Form1 form = new Form1();

            form.Command = "Edit";
            
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            
            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return true;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }

            return false;
        }
        
        public bool NewSub(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            Form2 form2 = new Form2();
            form2.Command = "New";
            form2.funLoad();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (!form2.IsDisposed)
                {
                    form2.Close();
                    form2.Dispose();
                }
                return true;
            }
            if (!form2.IsDisposed)
            {
                form2.Close();
                form2.Dispose();
            }

            return false;
        }

        public bool EditSub(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            Form2 form2 = new Form2();

            form2.Command = "Edit";

            form2.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form2.funLoad();

            if (form2.ShowDialog() == DialogResult.OK)
            {
                if (!form2.IsDisposed)
                {
                    form2.Close();
                    form2.Dispose();
                }
                return true;
            }
            if (!form2.IsDisposed)
            {
                form2.Close();
                form2.Dispose();
            }

            return false;
        }

        public bool ReportSub(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            XmlDocument xConfig = new XmlDocument();

            xConfig.Load(Application.StartupPath + "/Config_Process.xml");

            string ID = "Sub";
            if (XmlProcess.Transform(xConfig, ID))
            {
                Form3 frWh = new Form3();
                frWh.Show();
            }
            else
            {
                MessageBox.Show(XmlProcess.ErrMsg);
            }

            return false;
        }
        
        public bool Report(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            XmlDocument xConfig = new XmlDocument();

            xConfig.Load(Application.StartupPath + "/Config_Process.xml");

            string ID = "RESub";
            if (XmlProcess.Transform(xConfig, ID))
            {
                Form4 frWh = new Form4();
                frWh.Show();
            }
            else
            {
                MessageBox.Show(XmlProcess.ErrMsg);
            }

            return false;
        }

    }
}
