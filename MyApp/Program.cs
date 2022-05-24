int operacion, ejecucion = 1;
double numero;

Calculadora calculadora = new Calculadora(0);

do
{
    do
    {
        Console.Write("Elija una operación a realizar: (1: Sumar | 2: Restar | 3: Multiplicación | 4: División | 5: Limpiar): ");
        operacion = Convert.ToInt32(Console.ReadLine());
    } while (operacion < 1 || operacion > 5);

    Console.Write("Ingrese un número: ");
    numero = Convert.ToDouble(Console.ReadLine());

    switch (operacion)
    {
        case 1:
            calculadora.Sumar(numero);
            Console.WriteLine($"El resultado de sumar { numero } es: { calculadora.Resultado }");
            break;
        case 2:
            calculadora.Restar(numero);
            Console.WriteLine($"El resultado de restar { numero } es: { calculadora.Resultado }");
            break;
        case 3:
            calculadora.Multiplicar(numero);
            Console.WriteLine($"El resultado de multiplicar { numero } es: { calculadora.Resultado }");
            break;
        case 4:
            calculadora.Dividir(numero);
            Console.WriteLine($"El resultado de dividir { numero } es: { calculadora.Resultado }");
            break;
        case 5:
            calculadora.Limpiar();
            Console.WriteLine($"El resultado de limpiar es: { calculadora.Resultado }");
            break;
        default:
            break;
    };

    Console.WriteLine("Quiere seguir operando? (1: Si | 0: No)");
    ejecucion = Convert.ToInt32(Console.ReadLine());
} while (ejecucion == 1);