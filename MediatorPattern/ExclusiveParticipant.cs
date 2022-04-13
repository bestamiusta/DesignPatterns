using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    internal class ExclusiveParticipant : Participant
    {
        public ExclusiveParticipant(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Exclusive participant...");
            base.Receive(from, message);
        }
    }
}
