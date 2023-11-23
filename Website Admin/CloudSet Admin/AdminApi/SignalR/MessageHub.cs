using AdminApi.Repository;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AdminApi.SignalR
{
    public class MessageHub:Hub
    {
        private readonly IMessageRepo _messageRepo;
        public MessageHub(IMessageRepo messageRep) {
            _messageRepo = messageRep;
        }

       
    }
}
