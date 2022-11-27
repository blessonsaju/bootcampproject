using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace complaintProject.guest
{
    public partial class login : System.Web.UI.Page
    {
        BAL.CBAL obj=new BAL.CBAL();
        DataTable dt=new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbutton_Click(object sender, EventArgs e)
        {
            
                obj.User=luser.Text;
            obj.pass= lpass.Text;
            DataTable dt = obj.userlogin();
            if(dt.Rows.Count > 0)
            {
                Session["user"] = luser.Text;
                Session["uid"] = dt.Rows[0][0];


                Response.Write("valid user");
                Response.Redirect("../user/query.aspx");

            }
            else
            {
                Response.Write("invalid user");
            }


        }

       
    }
}