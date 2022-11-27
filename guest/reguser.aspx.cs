using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace complaintProject.guest
{
    public partial class reguser1 : System.Web.UI.Page
    {
        BAL.CBAL obj = new BAL.CBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ssub_Click(object sender, EventArgs e)
        {
            obj.Name = cname.Text;
            obj.Email = cemail.Text;
            obj.Age = cage.Text;
            obj.User = cuser.Text;
            obj.pass = cpass.Text;
            int i = obj.insertdetails();
        }
    }
}