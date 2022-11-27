using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace complaintProject.BAL
{
    public class CBAL
    {
        DAL.CDAL obj1 = new DAL.CDAL();

        private string _name;
        private string _age;
        private string _email;
        private string _user;
        private string _pass;
        private string _namee;
        private string quer;
        public string replay;


        public string Replay
        {
            get
            {
                return replay;
            }
            set
            {
                replay = value;
            }
        }
        public string Quid
        {
            get { return quer; }
            set { quer = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string pass
        {
            get { return _pass; }
            set
            {
                _pass = value;
            }

        }
        public string User
        {
            get { return _user; }
            set
            {
                _user = value;
            }
        }

        public int insertdetails()
        {
            return obj1.cinsert(this);
        }


        public string product
        {
            get { return _namee; }
            set
            {
                _namee = value;
            }
        }
        public int insertpdetails()
        {
            return obj1.pinsert(this);
        }
        
        public DataTable userlogin()
        {
            return obj1.logincheck(this);
        }
        public DataSet productview()
        {
            return obj1.viewproduct();
        }
        public void deletegrid()
        {
            obj1.griddelete(this);
        }
        public DataSet gridview()
        {
             return obj1.viewgrid();
        }
        public void updategrid(string v)
        {
            obj1.gridupdate(v);
        }
        public void compreg()
        {
            obj1.regcomp(this);
        }
        public void qreg()
        {
            obj1.regq(this);
        } 

        public DataSet gridcomplaint()
        {
            return obj1.complaintviewgrid();
        }

        public DataSet gridquery()
        {
            return obj1.querygrid();
        }

        public DataSet listgrid()
        {
            return obj1.gridlist();
        }
   

        public DataSet compPros()
        {
            return obj1.prosComp();
        }

        public void compdown(string ve)
        {
            obj1.downcomp(ve);
        }

        public void compclosed(string ve)
        {
            obj1.closedcomp(ve);
        }
        public DataSet compcomplete()
        {
            return obj1.completecomp();
        }
        public int giveReplay()
        {
            return obj1.GiveReplay(this);
        }
    }

    

    
   
}
