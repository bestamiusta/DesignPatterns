namespace MediatorPattern
{
    public class Participant
    {
        private string _name;
       
        public Participant(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }
        public ChatRoom ChatRoom { get; internal set; }

        public void Send(string to, string message)
        { 
            this.ChatRoom.SendMessage(this.Name ,to,message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine("from {0} to {1} message received . Meesage :{2} ", from, this.Name, message);
        }
    }
}