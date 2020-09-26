// In c# classes can have fields, functions, properties, events, nested classes.
// Data of the class is called fields.
// Operations of the class is called Functions or member functions.
//Properties are smart functions with get/set blocks.
// Fields are usually hidde members(Private)
//To access fields we use properties: get/set

//Since class is a UDT, we need a definition of the class. The actual variable of the class is created using new operator in C#. This variable is called object in OOP.
using System;
using System.Security.Principal;

class Employee
{
    int id;
    string name, address;
    long phone;

    public int EmployeeID
    {
        get { return id; }
        set { id = value; }
    }

    public string EmpName
    {
        get { return name; }
        set { name = value; }
    }

    public string EmpAddress
    {
        get { return address; }
        set { address = value; }
    }
    public long EmpPhone
    {
        get { return phone; }
        set { phone = value; }
    }
}
 class ClassesDemo
{
    static void Main(string[] args)
    {
        Employee e = new Employee();
        e.EmployeeID = 99002521;
        e.EmpName = "JuNNu";
        e.EmpAddress = "Mysore";
        e.EmpPhone = 9122528559;
        Console.WriteLine($"The name of employee is {e.EmpName}. The employee iD is {e.EmployeeID}. Place of residence is {e.EmpAddress}, and the contact number is: {e.EmpPhone}."); //New syntax $, no need to use {0},{1}
    }

}