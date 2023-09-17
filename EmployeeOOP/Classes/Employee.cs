namespace EmployeeOOP.Classes
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; } //Signo de interrogacion (?) significa que puede tener dato o no

        public Date? BirthDate { get; set; }

        public Date? HiringDate { get; set; }

        public bool? IsActive { get; set; }
        #endregion

        #region Methods
        public Employee()
        { 
        
        }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"\nINFORMACION EMPLEADO \n\t " +
                $"ID: {Id}\n\t" +
                $"Nombres: {FirstName}\n\t" +
                $"Apellidos: {LastName}\n\t" +
                $"Fecha de Cumpleaños: {BirthDate}\n\t" +
                $"Fecha de Contratacion: {HiringDate}\n\t" +
                $"¿Empleado Activo?: {IsActive}\n\t";
        }

        #endregion
    }
}
