using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace complaintProject.admin
{
    public partial class viewquery : System.Web.UI.Page
    {

        BAL.CBAL obj = new BAL.CBAL();

        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = obj.gridquery();
            GridView1.DataSource=ds;
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}