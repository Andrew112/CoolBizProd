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
public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Your comments here
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnell");
    }
}
