using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * Source: DeVry University :: Lab 3 Partial Solution :: January 25th, 2012
 * Professor:   Richard Martin :: rmartin@devry.edu
 * Comments:
 */
public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSubmit_ClickEventHandler(object sender, EventArgs e)
    {

        // Add your comments here
        if (Session["SecurityLevel"] == "A")
        {

            btnSubmit.Visible = true;

            //Add your comments here 
        }
        else
        {

            btnSubmit.Visible = false;
        }

        string strErrorMesssage = "";
        bool blnIsValid = true;
        if (Request["txtFirstName"].ToString().Trim() == "")
        {
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            strErrorMesssage = strErrorMesssage + "First Name may not be empty.";
            blnIsValid = false;
        }
        else
        {
            txtFirstName.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtLastName"].ToString().Trim() == "")
        {
            txtLastName.BackColor = System.Drawing.Color.Yellow;
            strErrorMesssage = strErrorMesssage + "Last Name may not be empty.";
            blnIsValid = false;
        }
        else
        {
            txtLastName.BackColor = System.Drawing.Color.White;
        }

        if (Request["txtPayRate"].ToString().Trim() == "")
        {
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
            strErrorMesssage = strErrorMesssage + "Pay Rate may not be empty.";
            blnIsValid = false;
        }
        else
        {
            txtPayRate.BackColor = System.Drawing.Color.White;
        }
        
        if (Request["txtStartDate"].ToString().Trim() == "")
        {
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
            strErrorMesssage = strErrorMesssage + "Start Date may not be empty.";
            blnIsValid = false;
        }
        else
        {
            txtStartDate.BackColor = System.Drawing.Color.White;
        }
        
        if (Request["txtEndDate"].ToString().Trim() == "")
        {
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
            strErrorMesssage = strErrorMesssage + "End Date may not be empty.";
            blnIsValid = false;
        }
        else
        {
            txtEndDate.BackColor = System.Drawing.Color.White;
        }

        if (blnIsValid)
        {
            DateTime startDate = DateTime.Parse(Request["txtStartDate"]);
            DateTime endDate = DateTime.Parse(Request["txtEndDate"]);

            if (DateTime.Compare(startDate, endDate) > 0)
            {
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                strErrorMesssage = strErrorMesssage + "The end date must be a later date than the start date.";
                blnIsValid = false;
            }
            else
            {
                txtStartDate.BackColor = System.Drawing.Color.White;
                txtEndDate.BackColor = System.Drawing.Color.White;
            }

        }

        if (blnIsValid)
        {
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;
            Response.Redirect("frmPersonnelVerified.aspx");
        }
        else
        {
            lblErrorMessage.Text = strErrorMesssage;
        }
    }
}
