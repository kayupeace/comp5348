using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliveryCo.Services.Interfaces;
using System.ServiceModel;

namespace DeliveryCo.Business.Components
{
    public class SubmitDeliveryFactory
    {
        public static IDeliveryService GetSubmitDeliveryService(String pAddress)
        {
            NetMsmqBinding netMsmqBinding = new NetMsmqBinding(NetMsmqSecurityMode.None) { Durable = true, ExactlyOnce = false };
            netMsmqBinding.Security.Mode = 0;
            EndpointAddress address = new EndpointAddress(pAddress);
            return new ChannelFactory<IDeliveryService>(netMsmqBinding, address).CreateChannel();            
        }
    }
}
