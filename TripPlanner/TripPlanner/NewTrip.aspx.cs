using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TripPlanner
{
    public partial class NewTrip : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbxFullName.Text;
            string gender = rblGender.SelectedValue.ToString();
            string passportNumber = tbxPassport.Text;
            string date = tbxDate.Text;
            string airportFrom = airportFromList.SelectedValue.ToString();
            string airportTo = airportToList.SelectedValue.ToString();

            //FIXME validation

            try
            {
                //SqlDataSource.InsertCommand = "INSERT INTO Trips VALUES (@Name, 'L', @Passport, @Date, @From, @To)";
                SqlDataSource.InsertCommand = "INSERT INTO Trips VALUES (@Name, @Gender, @Passport, @Date, @From, @To)";
                SqlDataSource.InsertParameters.Add("Name", name);
                SqlDataSource.InsertParameters.Add("Gender", gender);
                SqlDataSource.InsertParameters.Add("Passport", passportNumber);
                SqlDataSource.InsertParameters.Add("Date", date);
                SqlDataSource.InsertParameters.Add("From", airportFrom);
                SqlDataSource.InsertParameters.Add("To", airportTo);
                SqlDataSource.Insert();
            }
            catch (SqlException ex)
            {
                Response.Write("<script>alert('Failed inserting record in the database. " + ex.Message + "');</script>)");
                Response.Redirect("/Default.aspx");//Will directly go to other page without showing alert...
            }
            catch (InvalidOperationException)
            {
                //This one is the one to use...
                Response.Write("<script>"
                             + "alert('Failed inserting record in the database.'); "
                             + "document.location = '/Default.aspx'; </script>");                
            }
        }
    }
}