using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmSalaryCalculator : System.Web.UI.Page
{
    //public string  calculateSalary;

    protected void Page_Load(object sender, EventArgs e)
    {
        //double SalaryTotal = 0;                                       //I thought that I would have need to initialize some variables here.
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        double annualHours = Convert.ToDouble(txtAnnualHours.Text);
        double rate = Convert.ToDouble(txtRate.Text);                            //I was going to try more object calls for the variables that I needed.
        //double SalaryTotal = Convert.ToDouble(txtSalaryTotal.Text);

        double total = annualHours * rate;

        lblSalary.Text = "$" + total.ToString();

    }                                                                        
}