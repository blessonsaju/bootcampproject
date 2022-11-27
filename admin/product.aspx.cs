using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Data;

namespace complaintProject.admin
{

    public partial class product : System.Web.UI.Page
    {
        BAL.CBAL obj = new BAL.CBAL();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = obj.productview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void ssub_Click(object sender, EventArgs e)
        {
            obj.product = pname.Text;
            int i = obj.insertpdetails();
            ds=obj.productview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            obj.Name = id;
            obj.deletegrid();
            ds = obj.productview();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}