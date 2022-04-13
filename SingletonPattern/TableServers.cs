using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();

        private List<string> _servers = new List<string>();

        private int balance = 0;

        private int index = 0;
        private TableServers()
        {
            _servers.Add("Bestami");
            _servers.Add("Ali");
            _servers.Add("Veli");
            _servers.Add("Burak");
            _servers.Add("Hale");
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = _servers[index];

            index += 1;

            if (index >= _servers.Count)
                index = 0;

            return output;
        }

        public void DepositCrypto(int value)
        {
            balance += value;
        }

        public void WithdrawCrypto(int value)
        {
            balance -= value;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
