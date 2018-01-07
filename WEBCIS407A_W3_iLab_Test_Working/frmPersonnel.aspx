<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmPersonnel.aspx.cs" Inherits="frmPersonnel" %>
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
    <p align="center">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/frmMain.aspx"><font color="black" size="2"><strong><font color="blue" face="Comic Sans MS" 
            size="4">Cool</font><font color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font 
            face="Comic Sans MS" size="4"> <font color="#993366">Productions</font>, 
        Inc.</font></strong> </font></asp:HyperLink>
        
    </p>
    <div align="center">
    
        <asp:Panel ID="Panel1" runat="server" Height="250px" HorizontalAlign="Left" 
            style="text-align: left" Width="300px">
            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name:" width="71px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Pay Rate:" width="71px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Start Date:" width="71px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server" 
                ></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="End Date:" width="71px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server" 
                ></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_ClickEventHandler"  />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                PostBackUrl="~/frmMain.aspx" />
                <br />
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
