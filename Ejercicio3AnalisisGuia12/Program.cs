using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3AnalisisGuia12
{
class Program
{
struct ejemplo
{
public String Placa;
public String Color;
public Double Año;
public String Marca;
public String Modelo;
public String Propietario;
public void Registrar(string p, string c, Double a, string ma, string mo, string pr)
{
Placa = p;
Color = c;
Año = a;
Marca = ma;
Modelo = mo;
Propietario = pr;
}
}
static void Main(string[] args)
{
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Registro de vehículos.";

int tan;

Console.WriteLine("Digite el número de vehículos a registrar: ");
tan = int.Parse(Console.ReadLine());
ejemplo[] E = new ejemplo[tan];

Console.WriteLine();


for (int i = 0; i < tan; i++)
{
Console.Write("Ingrese número de placa: ");
String p = Console.ReadLine();
Console.Write("Ingrese color: ");
String c = Console.ReadLine();
Console.Write("Ingrese año del vehículo: ");
Double a = Double.Parse(Console.ReadLine());
Console.Write("Ingrese marca: ");
String ma = Console.ReadLine();
Console.Write("Ingrese modelo: ");
String mo = Console.ReadLine();
Console.Write("Ingrese propietario del vehículo: ");
String pr = Console.ReadLine();

Console.WriteLine();

E[i].Registrar(p, c, a, ma, mo, pr);
}

Console.Clear();
Console.WriteLine("Información ingresada:");
Console.WriteLine("------------------------");

for (int i = 0; i < tan; i++)
{
Console.WriteLine("Placa: " + E[i].Placa);
Console.WriteLine("Color: " + E[i].Color);
Console.WriteLine("Año: " + E[i].Año);
Console.WriteLine("Marca: " + E[i].Marca);
Console.WriteLine("Modelo: " + E[i].Modelo);
Console.WriteLine("Propietario: " + E[i].Propietario);
Console.WriteLine("----------------------");
}

Console.ReadKey();
}
}
}
