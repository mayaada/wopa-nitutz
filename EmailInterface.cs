// using System;
// using System.Net;
// using System.Net.Mail;

// namespace nitutz
// {

//     public class EmailSender
//     {
//         public void SendEmail(string senderEmail, string recipientEmail, string subject, string body)
//         {
//             // Create a new MailMessage object
//             MailMessage mail = new MailMessage(senderEmail, recipientEmail);

//             // Set the subject and body of the email
//             mail.Subject = subject;
//             mail.Body = body;

//             // Create a new SmtpClient object
//             SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);


//             // Enable SSL/TLS encryption
//             smtpClient.EnableSsl = true;

//             try
//             {
//                 // Send the email
//                 smtpClient.Send(mail);
//                 Console.WriteLine("Email sent successfully.");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Failed to send email. Error message: " + ex.Message);
//             }
//         }
//     }
// }






