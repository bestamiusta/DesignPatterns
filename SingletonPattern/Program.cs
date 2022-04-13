using SingletonPattern;

var servers1 =  TableServers.GetTableServers();
var servers2 =  TableServers.GetTableServers();
var servers3 =  TableServers.GetTableServers();

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("The next server is " + servers1.GetNextServer());
//    Console.WriteLine("The next server is " + servers2.GetNextServer());

//}


servers1.DepositCrypto(10);

servers2.DepositCrypto(15);

Console.WriteLine("Balance is : " + servers3.GetBalance());

servers1.DepositCrypto(5);


Console.WriteLine("Balance is : " + servers3.GetBalance());

servers2.WithdrawCrypto(5);

Console.WriteLine("Balance is : " + servers3.GetBalance());

Console.ReadLine();

