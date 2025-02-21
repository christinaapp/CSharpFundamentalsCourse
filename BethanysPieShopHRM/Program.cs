

using BethanysPieShopHRM;
using System.Text;
using System;

//int a = 42;
//int aCopy = a;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");

//aCopy = 100;
//Console.WriteLine($"Value of a: {a} and value of copy of a: {aCopy}");


Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

string bethanyAsJson = bethany.ConvertToJson();
Console.WriteLine(bethanyAsJson);

string name = "Bethany";
string anotherName = name;
name += " Smith";

Console.WriteLine("Name: " + name);
Console.WriteLine("Another name: " + anotherName);

string indexes = string.Empty;

for (int i = 0; i < 2500; i++)
{
    indexes += i.ToString();
}

string firstName = "Bethany";
string lastName = "Smith";

StringBuilder builder = new StringBuilder();

builder.Append("Last name: ");
builder.AppendLine(lastName);
builder.Append("First name: ");
builder.Append(firstName);
string result = builder.ToString();

StringBuilder builder2 = new StringBuilder();

for (int i = 0; i < 2500; i++)
{
    builder2.Append(i);
    builder2.Append(" ");
}
string list = builder2.ToString();

Employee testEmployee = bethany;
testEmployee.firstName = "Gill"; //this changes the name for the bethany object not just the testEmployee variable

testEmployee.DisplayEmployeeDetails();
bethany.DisplayEmployeeDetails();

bethany.PerformWork(25);

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");


bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

bethany.firstName = "John";
bethany.hourlyRate = 10;

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

string fn = bethany.firstName;

double receiveWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receiveWageBethany}");

Console.WriteLine("Creating an employee");
Console.WriteLine("---------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);

WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();
