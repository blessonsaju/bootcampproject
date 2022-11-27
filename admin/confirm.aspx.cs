using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace complaintProject.admin
{
    public partial class confirm : System.Web.UI.Page
    {
        BAL.CBAL obj=new BAL.CBAL();

        DataSet ds=new DataSet();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ds = obj.gridview();
                GridView1.DataSource = ds;
                GridView1.DataBind();

                ds = obj.listgrid();
                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
            

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int cr = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string v = cr.ToString();
            obj.updategrid(v);

            ds = obj.gridview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

            ds = obj.listgrid();
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }
    }
}