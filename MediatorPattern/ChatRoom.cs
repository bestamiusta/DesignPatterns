using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ChatRoom : AbstratChatRoom
    {
        private Dictionary<string, Participant> _participantList = new Dictionary<string, Participant>();

        public override void Register(Participant participant)
        {
            if (!_participantList.ContainsKey(participant.Name))
            { 
                _participantList[participant.Name] = participant;
            }

            participant.ChatRoom = this;
        }

        public override void SendMessage(string from, string to, string message)
        {
            if (_participantList[to] != null)
            {
                _participantList[to].Receive(from, message);
            }
        }
    }
}
