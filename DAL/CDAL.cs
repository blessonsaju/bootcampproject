using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace complaintProject.DAL
{
    public class CDAL
    {
        public SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmm = new SqlCommand();
        SqlCommand cmdd = new SqlCommand();


        public CDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rrr"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
            cmm.Connection = con;
            cmdd.Connection = con;

        }
        public SqlConnection Getcon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public int cinsert(BAL.CBAL obj)
        {
            string sts = "not confirmed";
            string ut = "Customer";
            string qq = "insert into tbllogin values('" + obj.User + "','" + obj.pass + "','" + sts + "','" + ut + "')";
            SqlCommand cmd = new SqlCommand(qq, Getcon());
            cmd.ExecuteNonQuery();
            cmm.CommandType = CommandType.Text;
            String sql = "select max(Id) from tbllogin";
            cmm.CommandText = sql;
            Getcon();
            object ob = cmm.ExecuteScalar();
            string x = ob.ToString();
            string qry = "insert into tblreg values('" + obj.Name + "','" + obj.Age + "','" + obj.Email + "','" + obj.User + "','" + obj.pass + "','" + ob + "')";

            SqlCommand cmdd = new SqlCommand(qry, Getcon());

            return cmdd.ExecuteNonQuery();



        }
        public int pinsert(BAL.CBAL obj)
        {
            string qryy = "insert into tblproduct values('" + obj.product + "')";

            SqlCommand cmddd = new SqlCommand(qryy, Getcon());

            return cmddd.ExecuteNonQuery();



        }
        public DataTable logincheck(BAL.CBAL obj)
        {
            string quu = "Select  * From tbllogin Where username='" + obj.User + "' AND  password= '" + obj.pass + "'";

            SqlCommand cmd = new SqlCommand(quu, Getcon());

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;




        }
        public DataSet viewproduct()
        {
            string qq = "select * from tblproduct";
            SqlCommand cmd = new SqlCommand(qq, Getcon());
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }
        public void griddelete(BAL.CBAL obj)
        {
            string q = "delete from tblproduct where product_id='" + obj.Name + "'";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            cmd.ExecuteNonQuery();
        }
        public DataSet viewgrid()
        {
            string sts = "not confirmed";
            string s = "select * from tbllogin where status='" + sts + "'";

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand(s, Getcon());
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }
        public void gridupdate(string v)

        {
            string k = "confirmed";
            string qup = "update tbllogin set status='" + k + "' where Id='" + v + "'";
            SqlCommand cmd = new SqlCommand(qup, Getcon());
            cmd.ExecuteNonQuery();
        }
        public void regcomp(BAL.CBAL obj)
        {
            string q = "select product_id from tblproduct where product_name='" + obj.Email + "'";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            object ob = cmd.ExecuteScalar();


            var datee = DateTime.Now.ToString("yyyy-MM-dd");

            string e = "pending";
            string que = "insert into tblcomplaint values('" + obj.Name + "','" + ob + "','" + obj.pass + "','" + e + "','" + datee + "')";
            SqlCommand cmm = new SqlCommand(que, Getcon());
            cmm.ExecuteNonQuery();


        }
        public void regq(BAL.CBAL obj)
        {
            string q = "select product_id from tblproduct where product_name='" + obj.Email + "'";
            SqlCommand cmd = new SqlCommand(q, Getcon());
            object ob = cmd.ExecuteScalar();

            var datee = DateTime.Now.ToString("yyyy-MM-dd");
            string que = "insert into tblquery(product_id,user_id,date,query) values('" + ob + "','" + obj.Quid + "','" + datee + "','" + obj.Name + "')";
            SqlCommand cmm = new SqlCommand(que, Getcon());
            cmm.ExecuteNonQuery();
        }

        public DataSet complaintviewgrid()
        {
            string s = "select tblcomplaint.copmaint_id,tblreg.user_id,tblcomplaint.complaint,tblproduct.product_name,tblreg.name,tblcomplaint.date from tblcomplaint INNER JOIN tblreg ON tblcomplaint.user_id=tblreg.lid INNER JOIN tblproduct on tblcomplaint.product_id=tblproduct.product_id WHERE tblcomplaint.status='pending'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }

        public DataSet gridlist()
        {
            string s = "select* from tbllogin where status='confirmed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;

        }

        public DataSet querygrid()
        {
            string que = "select tblquery.query_id,tblreg.username,tblreg.Email,tblproduct.product_name,tblquery.query from tblquery inner join tblreg on tblquery.user_id=tblreg.user_id inner join tblproduct on tblquery.product_id=tblproduct.product_id ";
            SqlCommand cmd = new SqlCommand(que, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet db = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(db);
            return db;
        }
        /*public  DataSet processinggrid()
       {
           string s = "select tblcomplaint.copmaint_id,tblreg.user_id,tblcomplaint.complaint,tblproduct.product_name,tblreg.name,tblcomplaint.date from tblcomplaint INNER JOIN tblreg ON tblcomplaint.user_id=tblreg.lid INNER JOIN tblproduct on tblcomplaint.product_id=tblproduct.product_id WHERE tblcomplaint.status='processing'";
           SqlCommand cmd = new SqlCommand(s, Getcon());
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           DataSet ds = new DataSet();
           da.SelectCommand = cmd;
           da.Fill(ds);
           return ds;
       }

       public DataSet listgridupdate()
       {
           string k = "processing";
           string qup = "update tblcomplaint set status='" + k + "' where Id='" + v + "'";
           SqlCommand cmd = new SqlCommand(qup, Getcon());
           cmd.ExecuteNonQuery();

       }*/


        public void downcomp(string ve)
        {
            string k = "processing";
            string qup = "update tblcomplaint set status='" + k + "' where copmaint_id='" + ve + "'";
            SqlCommand cmd = new SqlCommand(qup, Getcon());
            cmd.ExecuteNonQuery();
        }
        public DataSet prosComp()
        {
            string s = "select tblcomplaint.copmaint_id,tblreg.user_id,tblcomplaint.complaint,tblproduct.product_name,tblreg.name,tblcomplaint.date from tblcomplaint INNER JOIN tblreg ON tblcomplaint.user_id=tblreg.lid INNER JOIN tblproduct on tblcomplaint.product_id=tblproduct.product_id WHERE tblcomplaint.status='processing'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;
        }

        public void closedcomp(string ve)
        {
            string k = "closed";
            string qup = "update tblcomplaint set status='" + k + "' where copmaint_id='" + ve + "'";
            SqlCommand cmd = new SqlCommand(qup, Getcon());
            cmd.ExecuteNonQuery();
        }


        public DataSet completecomp()
        {
            string s = "select tblcomplaint.copmaint_id,tblreg.user_id,tblcomplaint.complaint,tblproduct.product_name,tblreg.name,tblcomplaint.date from tblcomplaint INNER JOIN tblreg ON tblcomplaint.user_id=tblreg.lid INNER JOIN tblproduct on tblcomplaint.product_id=tblproduct.product_id WHERE tblcomplaint.status='closed'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            return ds;



        }


        public int GiveReplay(BAL.CBAL obj)
        {
            string s = "UPDATE Query SET Replay='" + obj.Replay + "' WHERE qId='" + obj.Quid + "'";
            SqlCommand cmd = new SqlCommand(s, GetCon());
            return cmd.ExecuteNonQuery();
        }

        private SqlConnection GetCon()
        {
            throw new NotImplementedException();
        }
    }
}