
// This class is only responsible for creating an employee
internal class CreateEmployee
{
    public string? Name { get; set; }
    public double Salary { get; set; }


    public bool SaveNewEmployee(Employee employee)
    {
        // Save employee
        return true;
    }
}