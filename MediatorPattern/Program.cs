// See https://www.dofactory.com/net/mediator-design-pattern for more information


// Create chatroom
using MediatorPattern;

ChatRoom chatroom = new ChatRoom();
// Create participants and register them
Participant George = new CommonParticipant("George");
Participant Paul = new ExclusiveParticipant("Paul");
Participant Ringo = new ExclusiveParticipant("Ringo");
Participant John = new CommonParticipant("John");
Participant Yoko = new ExclusiveParticipant("Yoko");
chatroom.Register(George);
chatroom.Register(Paul);
chatroom.Register(Ringo);
chatroom.Register(John);
chatroom.Register(Yoko);
// Chatting participants
Yoko.Send("John", "Hi John!");
Paul.Send("Ringo", "All you need is love");
Ringo.Send("George", "My sweet Lord");
Paul.Send("John", "Can't buy me love");
John.Send("Yoko", "My sweet love");
// Wait for user
Console.ReadKey();