public class Empleado {
    private string Nombre;
    private string Apellido;
    private DateTime FechaNac;
    private char EstadoCivil;
    private char Genero;
    private DateTime FechaIngreso = new DateTime();
    private double SueldoBasico;
    private CargoEnum Cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNac, char estadoCivil, char genero, DateTime fechaIngreso, double sueldoBasico, CargoEnum cargo) {
        Nombre = nombre;
        Apellido = apellido;
        FechaNac = fechaNac;
        EstadoCivil = estadoCivil;
        Genero = genero;
        FechaIngreso = fechaIngreso;
        SueldoBasico = sueldoBasico;
        Cargo = cargo;
    }

    public int Antiguedad() {
        int antiguedad = DateTime.Now.Year - FechaIngreso.Year;

        if (DateTime.Now.Month <= FechaIngreso.Month && DateTime.Now.Day <= FechaIngreso.Day) {
            antiguedad--;
        }

        return antiguedad;
    }

    public int Edad() {
        int edad = DateTime.Now.Year - FechaNac.Year;

        if (DateTime.Now.Month <= FechaNac.Month && DateTime.Now.Day <= FechaNac.Day) {
            edad--;
        }

        return edad;
    }

    public int Jubilacion() {

        int edadAJubilarse = 0;

        if (Genero == 'M') {
            edadAJubilarse = 65;            
        };

        if (Genero == 'F') {
            edadAJubilarse = 60;
        };

        int tiempoRestante = edadAJubilarse - Edad();

        return tiempoRestante;
    }

    public double Salario() {
        double adicional = 0;

        if (Antiguedad() <= 20) {
            adicional = SueldoBasico * 0.01 * Antiguedad();
        } else {
            adicional = SueldoBasico * 0.25;
        };
        
        if (Cargo == CargoEnum.Ingeniero || Cargo == CargoEnum.Especialista) {
            adicional *= .5;
        };

        if (EstadoCivil == 'C') {
            adicional += 15000;
        };

        return SueldoBasico + adicional;
    }

    public void MostrarEmpleado() {
        Console.WriteLine($"Empleado: { this.Apellido }, { this.Nombre }");
        Console.WriteLine("Fecha de nacimiento: " + FechaNac.ToShortDateString());
        Console.WriteLine("Edad: " + Edad() + " años");
        Console.WriteLine("Estado Civil: " + EstadoCivil);
        Console.WriteLine("Género: " + Genero);
        Console.WriteLine("Fecha de ingreso: " + FechaIngreso.ToShortDateString());
        Console.WriteLine("Antiguedad: " + Antiguedad() + " años");
        Console.WriteLine("Sueldo básico: $" + SueldoBasico);
        Console.WriteLine("Salario: $" + Salario());
    }

};
