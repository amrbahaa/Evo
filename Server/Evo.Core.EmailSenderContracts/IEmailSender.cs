using System;

namespace Evo.Core.EmailSenderContracts
{
    public interface IEmailSender
    {
        void SendEmail(string to);

        void SendEmail(string to, EmailTemplates emailTemplate);

        void SendEmail(string to, EmailTemplates emailTemplate, object emailParameters);

    }
}
