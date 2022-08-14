using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WorkersDetailes
{
    int row = 0;
    int flag;
    string id, name, lastName, email, phoneNumber, address, salary;
    double tax;
    WorkersDetailes w;
    Random rnd = new Random();
    List<string> maleNames = new List<string>() { "Yogev", "Ilai", "Alon", "Amit", "Moshiko", "Adam", "Yaron", "David", "Ronen", "Ron","Yam" };
    List<string> femaleNames = new List<string>() { "Ester", "Avigail", "Daniel", "Ariel","Yael","Yafit","Yafa", "Mazal","Or","Orit","Ora" };
    List<string> lastNames = new List<string>() { "Cohen", "Levi", "Vitzman", "Swisa", "Gadot" };
     String SALTCHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
    StringBuilder salt = new StringBuilder();



    public WorkersDetailes()
    {
        id = rnd.Next(10000000, 99999999).ToString();
        if (rnd.Next(1, 2) == 1)
        {
            name = maleNames[rnd.Next(0, maleNames.Count() - 1)];
        }
        else
        {
            name = femaleNames[rnd.Next(0, femaleNames.Count() - 1)];
        }
        lastName = maleNames[rnd.Next(0, lastNames.Count() - 1)];
        email = string.Format("qa{0:0000}@test.com", rnd.Next(10000));
        phoneNumber = "0255845";
        address = "fvffv";
        salary = rnd.Next(3000, 50000).ToString();
    }

    public WorkersDetailes(string id, string name, string salary)
    {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }

    public string getID() { return id; }
    public string getName() { return name; }
    public string getSalary() { return salary; }
   



}     

   