using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz1Customers
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //collecting data
            string name = tbxName.Text;
            string postalcode = tbxPostalCode.Text;
            string province = ddlProvince.SelectedValue.ToString();
            string email = tbxEmail.Text;
            string gender = rblGender.SelectedValue.ToString();

            //Validating data
            if (name.Length < 2 || name.Length > 100)
            {
                tbxName.Text = "";
                return;
            }

            //Inserting data in SQL
            try
            {                
                SqlDataSource1.InsertCommand = "INSERT INTO Customers VALUES (@Name, @PostalCode, @Province, @Email, @Gender)";
                SqlDataSource1.InsertParameters.Add("Name", name);
                SqlDataSource1.InsertParameters.Add("PostalCode", postalcode);
                SqlDataSource1.InsertParameters.Add("Province", province);
                SqlDataSource1.InsertParameters.Add("Email", email);
                SqlDataSource1.InsertParameters.Add("Gender", gender);
                
                SqlDataSource1.Insert();
            }
            catch (SqlException ex)
            {
                Response.Write("<script>"
                             + "alert('Failed inserting record in the database.'); "
                             + "document.location = '/Default.aspx'; </script>");               
            }
            catch (InvalidOperationException)
            {                
                Response.Write("<script>"
                             + "alert('You tried to miss with something, eh?'); "
                             + "document.location = '/Default.aspx'; </script>");
            }
        }
    }
}