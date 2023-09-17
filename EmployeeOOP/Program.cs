using EmployeeOOP.Classes;
using System.Runtime.InteropServices;

try
{
    //Declaración de variables
    int day, month, year;
    string firstName, lastName;
    decimal salary;

    Console.WriteLine("OOP APPLICATION");
    Console.WriteLine("---------------");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    //Inicialización de la clase Date
    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());

    Console.Write("\nIngresar Nombres: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar Apellidos: ");
    lastName = Console.ReadLine();

    Console.Write("Ingresar Salario: ");
    salary = decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        LastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,

    };
    Console.WriteLine(salaryEmployee.ToString());


    HourlyEmployee hourlyEmployee = new HourlyEmployee();

    Console.Write("\nIngresar Identificacion: ");
    hourlyEmployee.Id =int.Parse(Console.ReadLine());

    Console.Write("Ingresar Nombres: ");
    hourlyEmployee.FirstName = Console.ReadLine();

    Console.Write("Ingresar Apellidos: ");
    hourlyEmployee.LastName = Console.ReadLine();

    hourlyEmployee.IsActive = true;

    Console.Write("Ingresar Las Horas Trabajadas: ");
    hourlyEmployee.Hours = int.Parse(Console.ReadLine());

    Console.Write("Ingresar Valor Por Hora: ");
    hourlyEmployee.HoursValue = decimal.Parse(Console.ReadLine());

    Console.WriteLine(hourlyEmployee.ToString());


    CommissionEmployee commissionEmployee = new CommissionEmployee();

    Console.Write("\nIngresar Identificacion: ");
    commissionEmployee.Id = int.Parse(Console.ReadLine());

    Console.Write("Ingresar Nombres: ");
    commissionEmployee.FirstName = Console.ReadLine();

    Console.Write("Ingresar Apellidos: ");
    commissionEmployee.LastName = Console.ReadLine();

    commissionEmployee.IsActive = true;

    Console.Write("Ingresar Porcentaje de Comision: ");
    commissionEmployee.CommisionPercentaje = int.Parse(Console.ReadLine());

    Console.Write("Ingresar Valor De Venta: ");
    commissionEmployee.Sales = decimal.Parse(Console.ReadLine());

    Console.WriteLine(commissionEmployee.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);	
}




