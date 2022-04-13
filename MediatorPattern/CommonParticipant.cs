using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class CommonParticipant : Participant
    {
        public CommonParticipant(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Common participant...");
            base.Receive(from, message);
        }
    }
}
