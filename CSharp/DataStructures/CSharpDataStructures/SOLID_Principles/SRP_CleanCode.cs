
// This class is only responsible for creating an employee
internal class TheEmployee
{
    public string? Name { get; set; }
    public double Salary { get; set; }


    public bool SaveNewEmployee(Employee employee)
    {
        // Save employee
        return true;
    }

    public string GetEmployeeDetails()
    {
        return "Employee Name: " + Name + " Salary: " + Salary;
    }
}

internal class SalaryCalculator
{
    public bool CalculateSalary(int numberOfHoursWorked, int ratePerDay)
    {
        // Calculate salary
        // Note: This class can be abstracted more, here its just showing one responsibility
        return true;
    }
}