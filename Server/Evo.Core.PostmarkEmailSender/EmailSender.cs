using System;
using PostmarkDotNet;
using PostmarkDotNet.Model;
using System.IO;
using Evo.Core.EmailSenderContracts;

namespace Evo.Core.PostmarkEmailSender
{
    public class EmailSender : IEmailSender
    {               
        public async void SendEmail(string to) {

            var mailHeader = new MailHeader("X-CUSTOM-HEADER", "Header content");
            
            var headers = new HeaderCollection();

            headers.Add(mailHeader);

            var message = new PostmarkMessage()
            {
                To = to,
                From = "psobhy@integrant.com",
                TrackOpens = true,
                Subject = "A complex email",
                TextBody = "Plain Text Body",
                HtmlBody = "<html><body><img src=\"cid:embed_name.jpg\"/></body></html>",
                Tag = "New Year's Email Campaign",
                Headers = headers
            };

            var imageContent = File.ReadAllBytes("test.jpg");
            message.AddAttachment(imageContent, "test.jpg", "image/jpg", "cid:embed_name.jpg");

            var client = new PostmarkClient("6cce5c93-a59e-4f32-b37d-c71525956b6b");
            var sendResult = await client.SendMessageAsync(message);

            if (sendResult.Status == PostmarkStatus.Success) { /* Handle success */ }
            else { /* Resolve issue.*/ }
        }

        public async void SendEmail(string to, EmailTemplates emailTemplate)
        {
            throw new NotImplementedException();
        }

        public async void SendEmail(string to, EmailTemplates emailTemplate, object emailParameters)
        {
            throw new NotImplementedException();
        }
    }
}
