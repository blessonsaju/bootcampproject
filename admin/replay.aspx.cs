using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace complaintProject.admin
{
    
    public partial class replay : System.Web.UI.Page
    {
        BAL.CBAL obj = new BAL.CBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //obj.Quid = Convert.ToInt32(Request.QueryString["id"]);
            obj.Replay = TextBox1.Text;
            int i = obj.giveReplay();
            if (i == 1)
            {
                Response.Write("<script>alert('Replied')</script>");
                Response.Redirect("ViewQuery.aspx");
            }
        }
    }
}