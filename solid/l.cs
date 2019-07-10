using System;
using System.Collections.Generic;

interface IDiscount {
    double getDiscount(double TotalSales);
}

interface IDatabase {
    void Add();
}

class Customer : IDiscount, IDatabase {
    public virtual void Add() {
        Console.WriteLine("Database updated");
    }

    public virtual double getDiscount(double TotalSales) {
        return TotalSales;
    }
}

class SilverCustomer : Customer {
    public override void Add() {
        Console.WriteLine("Silver updated");
    }
}

class GoldCustomer : Customer {
    public override void Add() {
        Console.WriteLine("Gold updated");
    }
}

class Enquiry : IDiscount {
    public double getDiscount(double TotalSales) {
        return TotalSales - 5;
    }
}

public class Liskov {
    public static void Main(string[] args) {
        List<Customer> Customers = new List<Customer>();
        Customers.Add(new SilverCustomer());
        Customers.Add(new GoldCustomer());
        // Customers.Add(new Enquiry()); // throws an error

        foreach(Customer o in Customers) {
            o.Add(); // throw exception for Enquiry
        }
    }
}
