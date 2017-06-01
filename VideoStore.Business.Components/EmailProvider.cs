using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoStore.Business.Components.Interfaces;
using System.Messaging;

namespace VideoStore.Business.Components
{
    public class EmailProvider : IEmailProvider
    {
       // private static readonly String sPublishQueuePath = ".\\private$\\EmailMessageQueueTransacted";
        public void SendMessage(EmailMessage pMessage)
        {
            //if (!MessageQueue.Exists(sPublishQueuePath))
            //    MessageQueue.Create(sPublishQueuePath);
            ExternalServiceFactory.Instance.EmailService.SendEmail
                (

                    new global::EmailService.MessageTypes.EmailMessage()
                    {
                        Message = pMessage.Message,
                        ToAddresses = pMessage.ToAddress,
                        Date = DateTime.Now
                    }
                );
        }
    }
}
