public class Empleado {
    public string Nombre = "";
    public string Apellido = "";
    public DateTime FechaNac;
    public char EstadoCivil;
    public char Genero;
    public DateTime FechaIngreso = new DateTime();
    public double SueldoBasico;
    public CargoEnum Cargo;

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
}