using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1: Employee Details
            Console.WriteLine("Assignment 1: Employee Details");
            A1Q1 obj1 = new A1Q1();
            obj1.Assignment1();
            Console.ReadLine();

            // Assignment 2: Bank Account Operations
            Console.WriteLine("Assignment 2: Bank Account Operations");
            A1Q2 obj2 = new A1Q2();
            obj2.Assignment2();
            Console.ReadLine();

            // Assignment 3: MathHelper (Static class for calculating average)
            Console.WriteLine("Assignment 3: MathHelper - Calculate Average");
            int[] values = { 10, 20, 30, 40, 50 };
            double average = MathHelper.CalculateAverage(values);
            Console.WriteLine($"The average is: {average}");
            Console.ReadLine();

            // Assignment 4: Logger (Static class for logging messages)
            Console.WriteLine("Assignment 4: Logger");
            Logger.LogMessage("This is a log message.");
            Console.ReadLine();

            // Assignment 5: Partial Class (Person)
            Console.WriteLine("Assignment 5: Partial Class - Person");
            Person person = new Person { FirstName = "John", LastName = "Doe" };
            person.PrintFullName();
            Console.ReadLine();

            // Assignment 6: Partial Class (Employee with salary calculation)
            Console.WriteLine("Assignment 6: Partial Class - Employee Salary");
            Employee employee = new Employee { Name = "Jane", HoursWorked = 40, HourlyRate = 50m };
            Console.WriteLine($"Employee {employee.Name} earned: ${employee.CalculateSalary():F2}");
            Console.ReadLine();

            // Assignment 7: Abstract Class (Shape: Circle and Rectangle)
            Console.WriteLine("Assignment 7: Abstract Class - Shapes");
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(10, 20);
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.ReadLine();

            // Assignment 8: Abstract Class (Animal: Dog and Cat)
            Console.WriteLine("Assignment 8: Abstract Class - Animals");
            Animal dog = new Dog { Name = "Buddy", Age = 3 };
            Animal cat = new Cat { Name = "Whiskers", Age = 2 };
            dog.MakeSound();
            cat.MakeSound();
            Console.ReadLine();

            // Assignment 9: Sealed Class (Car inherits from Vehicle)
            Console.WriteLine("Assignment 9: Sealed Class - Car");
            Vehicle car = new Car();
            car.StartEngine();
            car.StopEngine();
            Console.ReadLine();

            /*// Assignment 10: Sealed Class (SavingsAccount with interest calculation)
            Console.WriteLine("Assignment 10: Sealed Class - Savings Account");
            SavingsAccount savings = new SavingsAccount("12345", 1000m, 0.05m);
            savings.CalculateInterest();
            Console.ReadLine();*/
        }
    }

    // Assignment 1: Employee Class
    class A1Q1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public double EmployeeNumber { get; set; }

        public A1Q1()
        {
            Name = "Alice";
            Age = 30;
            Salary = 75000m;
            EmployeeNumber = 9973410677;
        }

        public void Assignment1()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: ${Salary:F2}");
            Console.WriteLine($"Employee Number: {EmployeeNumber:F2}");
        }
    }

    // Assignment 2: Bank Account Class
    class A1Q2
    {
        public void Assignment2()
        {
            BankAccount account = new BankAccount("123456789", "John Doe", 1000m);
            account.DisplayAccountDetails();

            account.Deposit(500m);
            account.DisplayAccountDetails();

            account.Withdraw(200m);
            account.DisplayAccountDetails();

            account.Withdraw(1500m);
            account.DisplayAccountDetails();
        }
    }

    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0) Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance) Balance -= amount;
            else if (amount > Balance) Console.WriteLine("Insufficient funds.");
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: ${Balance:F2}");
        }
    }

    // Assignment 3: MathHelper (Static class)
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) throw new ArgumentException("Array cannot be null or empty.");
            int sum = 0;
            foreach (int number in numbers) sum += number;
            return (double)sum / numbers.Length;
        }
    }

    // Assignment 4: Logger (Static class)
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    // Assignment 5: Partial Class Person
    public partial class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public partial class Person
    {
        public void PrintFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
    }

    // Assignment 6: Partial Class Employee
    public partial class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
    }

    public partial class Employee
    {
        public decimal CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }

    // Assignment 7: Abstract Class Shape
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    // Assignment 8: Abstract Class Animal
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows!");
        }
    }

    // Assignment 9: Sealed Class Car
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    public sealed class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }

}

// Assignment 10: Sealed Class SavingsAccount
/* public sealed class SavingsAccount : BankAccount
 {
     public decimal InterestRate { get; set; }

     public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
         : base(accountNumber, initialBalance)
     {
         InterestRate = interestRate;
     }

     public void CalculateInterest()
     {
         decimal interest = Balance * InterestRate;
         Balance += interest;
         Console.WriteLine($"Interest added: ${interest:F2}");
     }
 }
}
*/
