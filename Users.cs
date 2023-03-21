using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Users
{
    string name;
    string surname;
    string email;
    string password;
    string phone;

    public Users(string name, string surname, string email, string password, string phone)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.password = password;
        this.phone = phone;
    }
}

