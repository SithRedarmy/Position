using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using NextProcess;
using System.Xml;
using AppTranferPosition;

namespace AppTranferPosition
{
    public class cMain
    {
        public static string strConnect;
        public static string user;
        public static string OfficeSpaceId;

        public bool NewPosition(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmPosition form = new fmPosition();
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
        public bool EditPosition(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmPosition form = new fmPosition();
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
        public bool ReportPosition(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            

            return false;
        }

        public bool NewEmp(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmEmp form = new fmEmp();
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
        public bool EditEmp(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmEmp form = new fmEmp();
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
        public bool ReportEmp(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            
            return false;
        }

        public bool NewBoard(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmBoard form = new fmBoard();
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
        public bool EditBoard(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmBoard form = new fmBoard();
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
        public bool ReportBoard(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {

            return false;
        }

        public bool NewCull(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmCull form = new fmCull();
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
        public bool EditCull(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;

            fmCull form = new fmCull();
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
        public bool ReportCull(string istrConnect, string iuser, string iOfficeSpaceId, DataTable dt, int currentIndex)
        {

            return false;
        }
    }
}
