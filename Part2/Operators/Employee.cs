using System;

// Define the Employee class
public class Employee
{
    // Public property for the employee's ID
    public int Id { get; set; }

    // Public property for the employee's first name
    public string FirstName { get; set; }

    // Public property for the employee's last name
    public string LastName { get; set; }

    // Overload the '==' operator to compare employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, return true
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If either is null, return false
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare the Ids
        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator, required when overloading '=='
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // Reuse the '==' logic
    }

    // Override Equals (recommended when overloading ==)
    public override bool Equals(object obj)
    {
        var other = obj as Employee;
        if (other == null)
            return false;

        return this.Id == other.Id;
    }

    // Override GetHashCode (also recommended)
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
