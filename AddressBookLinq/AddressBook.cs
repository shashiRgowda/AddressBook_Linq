using System;
using System.Collections.Generic;
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
    }
}
