using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000.5;

//variabless -->camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Kaan ");
}
else
{
    Console.WriteLine("Sisteme giriş yap");
}

string[] loans = {"Kredi 1","Kredi 2","Kredi 3","Kredi 4", "Kredi 5", "Kredi 6" };//db'den gelicek
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";
        
      //start    condition        increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}


Console.WriteLine("kod bitti");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345687910";
customer1.FirstName = "Kaan";
customer1.LastName = "Demirtaş";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "456789461231";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorparateCustomer customer3 = new CorparateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "4567894561230";

CorparateCustomer customer4 = new CorparateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654987";
customer4.TaxNumber = "4567894561278";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}