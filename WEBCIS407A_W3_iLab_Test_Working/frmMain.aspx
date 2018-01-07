<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmMain.aspx.cs" Inherits="frmMain" %>
<!--
 * Source: DeVry University :: Lab 3 Partial Solution :: January 25th, 2012
 * Professor:   Richard Martin :: rmartin@devry.edu
 * Comments:
 -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <strong><font face="Comic Sans MS" color="blue" size="4">Cool</font><font face="Comic Sans MS" color=#ff6600 size=4>Biz</font><font face="Comic Sans MS" size=4> <font color=#993366>Productions</font>, Inc.</font></strong>
    </div>
    <br />
    <div align="center">
    <asp:LinkButton ID="LinkButton1" runat="server" 
            PostBackUrl="~/frmSalaryCalculator.aspx">Annual Salary Calculator</asp:LinkButton>
    <asp:ImageButton ID="ImageButton1" runat="server" 
        ImageUrl="~/images/calculator.jpg" Width="50px" BorderColor="White" 
            BorderWidth="10px" ImageAlign="Middle" 
            PostBackUrl="~/frmSalaryCalculator.aspx" />
    </div>
    <br />
    <div align="center">
    <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/frmPersonnel.aspx">Add New Employee</asp:LinkButton>
    <asp:ImageButton ID="ImageButton2" runat="server" 
        ImageUrl="~/images/newemployee.jpg" Width="50px" BorderColor="White" 
            BorderWidth="10px" ImageAlign="Middle" PostBackUrl="~/frmPersonnel.aspx" />
    </div>
    <br />
    <div align="center">
    <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/frmUserActivity.aspx">View User Activity</asp:LinkButton>
    <asp:ImageButton ID="ImageButton3" runat="server" 
        ImageUrl="~/images/userActivity.jpg" Width="50px" BorderColor="White" 
            BorderWidth="10px" ImageAlign="Middle" 
            PostBackUrl="~/frmUserActivity.aspx" />
    </div>
    </form>
</body>
</html>
