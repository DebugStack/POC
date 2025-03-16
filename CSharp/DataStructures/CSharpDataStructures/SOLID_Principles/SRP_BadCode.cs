//Here, a single class is doing too much - its breaking SINGLE RESPONSIBILITY PRINCIPLE.
internal class Employee
{
    public string? Name { get; set; }
    public double Salary { get; set; }
    public bool CalculateSalary(int numberOfHoursWorked, int ratePerDay)
    {
        // Calculate salary
        return true;
    }

    public bool SaveNewEmployee(Employee employee)
    {
        // Save employee
        return true;
    }

     // You may add, leaves, benefits, etc. here too & it will become a Acident prone zone!
}