﻿using System;

namespace AddressBookService_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book linq problem!");
            AddressBook addressBook = new AddressBook();
            DataTable dataTable = addressBook.AddressBookDataTable();
            //addressBook.GetAllContacts(dataTable);
            //addressBook.EditContact(dataTable);
            //addressBook.DeleteContact(dataTable);
            //addressBook.RetrieveContactByState(dataTable);
            // addressBook.GetSizeByCity(dataTable);
            //addressBook.SortContacts(dataTable);
            addressBook.GetCountByType(dataTable);
            Console.ReadLine();
        }
    }
}