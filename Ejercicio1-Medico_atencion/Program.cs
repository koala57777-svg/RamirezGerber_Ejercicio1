Console.WriteLine("Ingrese el tipo de atención requerida (Número): ");
Console.WriteLine("");
Console.WriteLine("1. Emergencia");
Console.WriteLine("2. Consulta");
Console.WriteLine("3. Pediatría");
Console.WriteLine("4. Traumatología");
Console.WriteLine("");
int atencion=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la edad del paciente: ");
int edad=int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la temperatura del paciente (°C): ");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la saturación de oxígeno del paciente (%): ");
double saturacionoxigeno = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese el nivel de dolor del paciente (0-10): ");
int niveldolor = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese la presión sistólica del paciente (mmHg): ");
int presionsistolica = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("(Las prioridades de cada tipo de atención son diferentes entre si)");

if (edad >= 0 && presionsistolica >=0 && presionsistolica<=200 && niveldolor >= 0 && niveldolor<=10&& temperatura >= 0 && temperatura<=50 && saturacionoxigeno >= 0 && saturacionoxigeno<=100)
{
    switch(atencion)
    {
        case 1:
            if (presionsistolica < 140 || niveldolor <= 5 || temperatura <= 35 || saturacionoxigeno >=94)
            {
                Console.WriteLine("Prioridad Baja");
                Console.WriteLine("Acción sugerida: Consulta normal");
            }
            else if (presionsistolica < 160 || niveldolor <= 7 || temperatura <= 39 || saturacionoxigeno >=90)
            {
                Console.WriteLine("Prioridad Media");
                Console.WriteLine("Acción sugerida: Observación");
            }
            else if (presionsistolica >= 160 || niveldolor > 7 || temperatura > 39 || saturacionoxigeno < 90)
            {
                Console.WriteLine("Prioridad Alta");
                Console.WriteLine("Acción sugerida: Reanimación");
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;

        case 2:
            if (niveldolor <= 4)
            {
                Console.WriteLine("Prioridad Baja");
                Console.WriteLine("Consuta normal");
            }
            else if (niveldolor <= 7)
            {
                Console.WriteLine("Prioridad Media");
                Console.WriteLine("Observación");
            }
            else if (niveldolor>7)
            {
                Console.WriteLine("Prioridad Alta");
                Console.WriteLine("Reanimar");
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;

        case 3:
            if (edad < 18)
            {
                if (temperatura < 37 || niveldolor < 4)
                {
                    Console.WriteLine("Prioridad Baja");
                    Console.WriteLine("Consuta normal");
                }
                else if (temperatura < 39 || niveldolor < 7)
                {
                    Console.WriteLine("Prioridad Media");
                    Console.WriteLine("Observación");
                }
                else if (temperatura >=39 || niveldolor >= 7)
                {
                    Console.WriteLine("Prioridad Alta");
                    Console.WriteLine("Reanimar");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;

        case 4:
            if (niveldolor >=4)
            {
                if (niveldolor == 4)
                {
                    Console.WriteLine("Prioridad Baja");
                    Console.WriteLine("Consuta normal");
                }
                else if (niveldolor<7)
                {
                    Console.WriteLine("Prioridad Media");
                    Console.WriteLine("Observación");
                }
                else if (niveldolor >=7)
                {
                    Console.WriteLine("Prioridad Alta");
                    Console.WriteLine("Reanimar");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            break;

        default:
            Console.WriteLine("Tipo de atención no válido. Por favor, ingrese un número entre 1 y 4.");
            break;
    }
}
else
{
    Console.WriteLine("Datos ingresados no válidos. Por favor, ingrese valores válidos.");
}

