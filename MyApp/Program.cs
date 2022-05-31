Console.WriteLine("========== Ejercicio 2 ==========");

Empleado[] empleados = new Empleado[3];

// Carga empleados
empleados[0] = new Empleado("Enzo", "Martinez", new DateTime(1978, 2, 15), 'C', 'M', new DateTime(2012, 6 , 10), 80000, CargoEnum.Ingeniero);
empleados[1] = new Empleado("Luis", "Sanchez", new DateTime(1991, 10, 1), 'S', 'M', new DateTime(2015, 11 , 16), 72000, CargoEnum.Especialista);
empleados[2] = new Empleado("Clara", "Fernandez", new DateTime(1989, 6, 30), 'S', 'F', new DateTime(2018, 2 , 22), 65000, CargoEnum.Administrativo);

// Mostrar empleados
mostrarTodosLosEmpleados(empleados);

// Total salarios
Console.WriteLine("\nEl monto total de los salarios es: $" + totalSalarios(empleados));

// Datos empleado más proximo a jubilarse
Console.WriteLine("\nEl empleado más proximo a jubilarse es: ");
Empleado empleadoMasAntiguo = obtenerEmpleadoMasAntiguo(empleados);
empleadoMasAntiguo.MostrarEmpleado();

// Funciones
void mostrarTodosLosEmpleados(Empleado[] empleados) {
    for (int i = 0; i < empleados.Length; i++) {
        Console.WriteLine($"----- Empleado { i + 1 } -----");
        empleados[i].MostrarEmpleado();   
        Console.WriteLine("");
    };
};

double totalSalarios(Empleado[] empleados) {
    double total = 0;

    foreach (Empleado empleado in empleados) {
        total += empleado.Salario();
    };

    return total;
};

Empleado obtenerEmpleadoMasAntiguo(Empleado[] empleados) {
    Empleado empleado = empleados[0];

    for (int i = 1; i < empleados.Length; i++) {
        if (empleados[i].Antiguedad() > empleado.Antiguedad()) {
           empleado = empleados[i]; 
        };
    };

    return empleado;
};