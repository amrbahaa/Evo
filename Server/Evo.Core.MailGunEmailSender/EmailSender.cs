using Evo.Core.EmailSenderContracts;
using RestSharp;
using RestSharp.Authenticators;
using System;
using Microsoft.Extensions.Configuration;

namespace Evo.Core.MailGunEmailSender
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public IRestResponse SendSimpleMessage()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(Configuration.GetSection("Mailgun:Url").Value);
            client.Authenticator = new HttpBasicAuthenticator("api", Configuration.GetSection("Mailgun:Key").Value);
            RestRequest request = new RestRequest();
            request.AddParameter("domain", Configuration.GetSection("Mailgun:Domain").Value, ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Excited User <hello@smartevoapp.com>");
            request.AddParameter("to", "psobhy@integrant.com");
            request.AddParameter("to", "abahaa@integrant.com");
            request.AddParameter("subject", "Hello");
            request.AddParameter("text", "Testing some Mailgun awesomness!");
            request.Method = Method.POST;
            return client.Execute(request);
        }

        public void SendEmail(string to)
        {
            IRestResponse resp = SendSimpleMessage();

            Console.WriteLine(resp.Content);
        }

        public void SendEmail(string to, EmailTemplates emailTemplate)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(string to, EmailTemplates emailTemplate, object emailParameters)
        {
            throw new NotImplementedException();
        }
    }
}
