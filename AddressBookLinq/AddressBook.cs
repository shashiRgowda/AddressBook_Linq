using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookService_Linq
{
    class AddressBook
    {
        public DataTable AddressBookDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("Shashi", "kumar", "shanthinagar", "Kolar", "Karnataka", "563101", "8884540867", "shashi@gmail.com");
            table.Rows.Add("Sharath", "Gowdru", "RT nagar", "Hasan", "Karnatka", "563102", "8660907461", "sharath@gmail.com");
            table.Rows.Add("Nandan", "Kumar", "HSR layout", "chennai", "AndraPradesh", "563103", "8197505915", "nandan@gmail.com");
            table.Rows.Add("Shalini", "Reddy", "Indhirangar", "Banglore", "Karnataka", "560057", "8710897106", "shalini@gmail.com");
            return table;
        }

        public void GetAllContacts(DataTable table)
        {
            foreach (DataRow dr in table.AsEnumerable())
            {
                Console.WriteLine("\n");
                Console.WriteLine("FirstName:- " + dr.Field<string>("FirstName"));
                Console.WriteLine("lastName:- " + dr.Field<string>("LastName"));
                Console.WriteLine("Address:- " + dr.Field<string>("Address"));
                Console.WriteLine("City:- " + dr.Field<string>("City"));
                Console.WriteLine("State:- " + dr.Field<string>("State"));
                Console.WriteLine("zip:- " + dr.Field<string>("Zip"));
                Console.WriteLine("phoneNumber:- " + dr.Field<string>("phoneNumber"));
                Console.WriteLine("eMail:- " + dr.Field<string>("Email"));
            }

        }
        public void EditContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Sharath");
            foreach (var contact in contacts)
            {
                contact.SetField("LastName", "Gowdru");
                contact.SetField("City", "Hasan");
                contact.SetField("State", "Karnataka");
            }

            Console.WriteLine("The Contact is updated succesfully!\n");
            GetAllContacts(contacts.CopyToDataTable());
        }
        public void DeleteContact(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("FirstName") == "Nandan");
            foreach (var row in contacts.ToList())
            {
                row.Delete();
            }
            Console.WriteLine("The Contact is deleted succesfully!\n");
            GetAllContacts(table);
        }
        public void RetrieveContactByState(DataTable table)
        {
            var contacts = table.AsEnumerable().Where(x => x.Field<string>("State") == "Karnataka");
            foreach (var contact in contacts)
            {
                Console.Write("First Name : " + contact.Field<string>("FirstName") + " " + "Last Name : " + contact.Field<string>("LastName") + " " + "Address : " + contact.Field<string>("Address") + " " + "City : " + contact.Field<string>("City") + " " + "State : " + contact.Field<string>("State")
                     + " " + "Zip : " + contact.Field<string>("Zip") + " " + "Phone Number : " + contact.Field<string>("PhoneNumber") + " " + "Email : " + contact.Field<string>("Email") + " ");
                Console.WriteLine("\n");
            }
        }
    }
}
    

    

