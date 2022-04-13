using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class AbstratChatRoom
    {
        public abstract void SendMessage(string from, string to, string message);
        public abstract void Register(Participant participant);
    }
}
