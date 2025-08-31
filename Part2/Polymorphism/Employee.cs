using System;

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Employee's ID
    public int Id { get; set; }

    // Employee's first name
    public string FirstName { get; set; }

    // Employee's last name
    public string LastName { get; set; }

    // Implementation of the Quit() method from IQuittable
    public void Quit()
    {
        // Example implementation: print a quitting message
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
    }

    // Overload '==' operator to compare by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2)) return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null)) return false;
        return emp1.Id == emp2.Id;
    }

    // Overload '!=' operator
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() for consistency with '=='
    public override bool Equals(object obj)
    {
        var other = obj as Employee;
        if (other == null) return false;
        return this.Id == other.Id;
    }

    // Override GetHashCode()
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
