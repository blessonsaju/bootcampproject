using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace complaintProject.admin
{
    public partial class viewcomplaint : System.Web.UI.Page
    {
        BAL.CBAL obj = new BAL.CBAL();

        DataSet ds = new DataSet();
        DataSet dss = new DataSet();
        DataSet dsss = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            ds = obj.gridcomplaint();
            GridView2.DataSource = ds;
            GridView2.DataBind();

            dss = obj.compPros();
            GridView1.DataSource= dss;
            GridView1.DataBind();

            dsss = obj.compcomplete();
            GridView3.DataSource = dsss;
            GridView3.DataBind();

        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string ve = id.ToString();

            obj.compdown(ve);

            GridView2.EditIndex = -1;
            ds = obj.gridcomplaint();
            GridView2.DataSource = ds;
            GridView2.DataBind();

            dss = obj.compPros();
            GridView1.DataSource = dss;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string ve = id.ToString();
            obj.compclosed(ve);


            dss = obj.compPros();
            GridView1.DataSource = dss;
            GridView1.DataBind();


            dsss=obj.compcomplete();
            GridView3.DataSource = dsss;
            GridView3.DataBind();



        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}