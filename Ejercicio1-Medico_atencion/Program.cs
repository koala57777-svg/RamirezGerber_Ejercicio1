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
Console.WriteLine("Ingrese la temperatura del paciente (℃): ");
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

if (edad >= 0 && presionsistolica >=0 && presionsistolica<=200 && niveldolor >= 0 && niveldolor<=10&& temperatura >= 0 && temperatura<=50 && saturacionoxigeno >= 0 && saturacionoxigeno<=100)
{

}
else
{
    Console.WriteLine("Datos ingresados no válidos. Por favor, ingrese valores válidos.");
}

