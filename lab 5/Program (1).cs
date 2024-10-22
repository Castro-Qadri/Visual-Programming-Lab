/*
using System;

public enum Department
{
    CSE,
    CS,
    ME
}

public class Person
{
    private string name;

    public Person()
    {
        this.name = null;
    }

    public Person(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

public class Student : Person
{
    private string regNo;
    private int age;
    private Department program;

    public Student()
    {
        this.regNo = null;
        this.age = 0;
        this.program = Department.CSE;
    }

    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Department Program
    {
        get { return program; }
        set { program = value; }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Muhammad Ahmad Ijaz");


        Student student = new Student("Muhammad Ahmad Ijaz", "233566", 20, Department.CS);


        Console.WriteLine("Person Details:");
        Console.WriteLine("Name: " + person.Name);

        Console.WriteLine("\nStudent Details:");
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("RegNo: " + student.RegNo);
        Console.WriteLine("Age: " + student.Age);
        Console.WriteLine("Program: " + student.Program);
    }
}
*/


using System;
using System.Collections.Generic;

public class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class CorporateCustomer : Customer
{
    public string CompanyName { get; set; }
    public string BillingAccountNo { get; set; }
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

public class RetailCustomer : Customer
{
    public int FrequentFlyerPts { get; set; }
}

public class Flight
{
    public int FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public TimeSpan DepartureTime { get; set; }
    public TimeSpan ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }
}

public class Seat
{
    public string SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public Customer Customer { get; set; }
    public Flight Flight { get; set; }
    public Seat Seat { get; set; }
    public DateTime Date { get; set; }
}

class Program
{
    static void Main()
    {
        // Example usage:
        CorporateCustomer corpCustomer = new CorporateCustomer
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Doe",
            CompanyName = "ABC Corp",
            BillingAccountNo = "123456",
            CreditCardType = "Visa",
            CreditCardNo = "4111111111111111"
        };

        Flight flight = new Flight
        {
            FlightId = 101,
            Date = DateTime.Now,
            Origin = "New York",
            Destination = "Los Angeles",
            DepartureTime = new TimeSpan(10, 30, 0),
            ArrivalTime = new TimeSpan(13, 45, 0),
            SeatingCapacity = 150
        };

        Seat seat = new Seat
        {
            SeatNo = "1A",
            Price = 500.00m,
            Status = "Reserved"
        };

        Reservation reservation = new Reservation
        {
            ReservationNo = 1001,
            Customer = corpCustomer,
            Flight = flight,
            Seat = seat,
            Date = DateTime.Now
        };

        Console.WriteLine($"Reservation Details:\nReservation No: {reservation.ReservationNo}\nCustomer: {reservation.Customer.FirstName} {reservation.Customer.LastName}\nFlight: {reservation.Flight.Origin} to {reservation.Flight.Destination}\nSeat: {reservation.Seat.SeatNo}\nPrice: {reservation.Seat.Price:C}");
    }
}
