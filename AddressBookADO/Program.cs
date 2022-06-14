// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBookADO
{
    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddressbookRepo repo = new AddressbookRepo();
            repo.GetAllData();
        }
    }
}