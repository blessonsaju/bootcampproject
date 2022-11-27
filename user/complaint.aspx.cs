using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace complaintProject.user
{
    public partial class complaint : System.Web.UI.Page
    {
        BAL.CBAL obj = new BAL.CBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = String.Format("{0}", Session["user"]);
            Label2.Text=String.Format("{0}", Session["uid"]);

            
        }

        protected void lbutton_Click(object sender, EventArgs e)
        {
            obj.Name = TextBox1.Text;
            obj.pass = Label2.Text;
            obj.Email = drop.SelectedItem.Value;
            obj.compreg();

        }
    }
}