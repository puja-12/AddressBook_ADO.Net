﻿// See https://aka.ms/new-console-template for more information
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
            AddressbookRepo repo = new AddressbookRepo();
            AddressBookModel model = new AddressBookModel();

            Console.WriteLine("Select option\n1)Retrieve database\n2)Update existing data\n3)retrieve contact by state/city");
            int option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //repo.GetAllData();
                    break;
                case 2:


                    model.Firstname = "Radha";
                    model.Lastname = "Tyagi";
                    model.Address = "Chandpur";
                    model.City = "Bijnor";
                    model.State = "UP";
                    model.Zip = 567489;
                    model.Email = "radha@gmail.com";
                    model.phone = 7869054321;
                    model.Type = "Friend";

                    repo.UpdateContact(model);
                    break;
                case 3:
                    repo.GetAllContactByState();
                    repo.GetAllContactByCity();
                    break;




            }
        }
    }
}