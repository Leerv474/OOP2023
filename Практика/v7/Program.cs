using System;
using System.Collections.Generic;
class Employee
{
    public string Name { get; set; }
    public Employee(string name)
    {
        Name = name;
    }
    public virtual double PayCheck()
    {
        return 0;
    }
}
class HourlyEmployee : Employee
{
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }
    public HourlyEmployee(string name, double hourlyRate, double hoursWorked)
    : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }
    public override double PayCheck()
    {
        double payment = HourlyRate * HoursWorked;
        return payment;
    }
}
class SalariedEmployee : Employee
{
    public double YearSalary { get; set; }
    public SalariedEmployee(string name, double salary)
    : base(name)
    {
        YearSalary = salary;
    }
    public override double PayCheck()
    {
        double payment = YearSalary / 12;
        return payment;
    }
}
class CommissionEmployee : Employee
{
    public double Sales { get; set; }
    public double CommissionRate { get; set; }
    public CommissionEmployee(string name, double sales, double commissionRate)
    : base(name)
    {
        Sales = sales;
        CommissionRate = commissionRate / 100;
    }
    public override double PayCheck()
    {
        double payment = Sales * CommissionRate;
        return payment;
    }
}
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Console.WriteLine("Введите сколько часов работал работник с почасовой оплатой ");
        int hours = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите сколько оплата за час ");
        int paymentHOUR = int.Parse(Console.ReadLine());
        employees.Add(new HourlyEmployee("Почасовой работник: ", hours, paymentHOUR));
        Console.WriteLine("Введите годовую оплату работника с фиксированной зарплатой");
        int paymentYEAR = int.Parse(Console.ReadLine());
        employees.Add(new SalariedEmployee("Работник с фиксированной зарплатой: ", paymentYEAR));
        Console.WriteLine("Введите сумму продаж");
        int sales = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите процент от продаж для работника ");
        int percent = int.Parse(Console.ReadLine());
        employees.Add(new CommissionEmployee("Работник с процентом от продаж: ", sales,
       percent));
        double totalPay = Payroll(employees);
        Console.WriteLine("Общая зарплата сотрудников: " + totalPay);
        PaySotr(employees);
    }
    static double Payroll(List<Employee> employees)
    {
        double totalPay = 0.0;
        foreach (Employee employee in employees)
        {
            totalPay += employee.PayCheck();
        }
        return totalPay;
    }
    static void PaySotr(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.Name + employee.PayCheck());
        }
    }
}
