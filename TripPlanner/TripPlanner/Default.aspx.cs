using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TripPlanner
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource_Selected(object sender, SqlDataSourceStatusEventArgs e)
        {
            int tripcounts = e.AffectedRows;
            lblTripCount.Text = string.Format("You have a total of {0} trips.", tripcounts);
        }
    }
}