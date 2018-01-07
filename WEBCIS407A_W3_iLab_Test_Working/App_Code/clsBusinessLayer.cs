using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// **** Add the following at the top of the class file, 
// This allows us to send mail...
using System.Net.Mail;


/// <summary>
/// Summary description for clsBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    //**** Add the following code inside the body of public class clsBusinessLayer ****

public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
string Subject, string Body)
{
try {

// This creates a new object from the mail method class!
MailMessage MyMailMessage = new MailMessage();
// Sender message from e-mail.
MyMailMessage.From = new MailAddress(Sender);
// Recipient message from e-mail.
MyMailMessage.To.Add(new MailAddress(Recipient));
// Carbon copy and blind carbon copy message from e-mail..
if (bcc != null && bcc != string.Empty) {
// Blind carbon copy constructor from e-mail message.
MyMailMessage.Bcc.Add(new MailAddress(bcc));
}
// Selection statements from carbon copy e-mail message.
if (cc != null && cc != string.Empty) {
// Carbon copy constructor for e-mail message.
MyMailMessage.CC.Add(new MailAddress(cc));
}
// 
MyMailMessage.Subject = Subject;
// The subject attributes.
MyMailMessage.Body = Body;
// The e-mail body attributes...
MyMailMessage.IsBodyHtml = true;
// Html attributes for message...
MyMailMessage.Priority = MailPriority.Normal;
// E-mail message attributes for priority.
SmtpClient MySmtpClient = new SmtpClient();
// Message transfer protocol for client constructor."Call for the smtp client"
MySmtpClient.Port = 25;
MySmtpClient.Host = "127.0.0.1";
// Host ISP address for e-mail...
MySmtpClient.Send(MyMailMessage);
// Request  code for e-mail message from client to host....
return true;
}
catch (Exception ex)
{
    // Add your comments here
    return false;
}

}

	public clsBusinessLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}