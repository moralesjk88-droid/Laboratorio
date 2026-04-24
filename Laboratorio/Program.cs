// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;

public class Prestamo
{
    private string codigo;
    private string estudiante;
    private string carnet;
    private string carrera;
    private string equipo;
    private int cantidad;
    private string estado;

    public Prestamo (string codigo, string estudiante, string carnet, string carrera, string equipo, int cantidad, string estado)
    {
        this.codigo = codigo;
        this.estudiante = estudiante;
        this.carnet = carnet;
        this.carrera = carrera;
        this.equipo = equipo;
        this.cantidad = cantidad;
        this.estado = estado;
    }

    public string ObtenerDatos()
    {
        return "Codigo: " + codigo + Environment.NewLine +
                "Nombre: " + estudiante + Environment.NewLine +
                "carnet: " + carnet + Environment.NewLine +
                "carrera: " + carrera + Environment.NewLine +
                "Equipo: " + equipo + Environment.NewLine +
                "cantidad: " + cantidad + Environment.NewLine +
                "Estado: " + estado + Environment.NewLine +
                "----------------------------" + Environment.NewLine;

            }

    public void GuardarEnArchivo(string ruta)
    {
        File.AppendAllText(ruta, ObtenerDatos());
    }

    public string Codigo
    {
        get { return codigo; }
    }

    public string ResumenConsola()
    {
        return "Codigo: " + codigo + " | Estudiante: " + estudiante + " | Equipo: " + equipo;
    }
}

class Program
{
    static void Main()
    {
        string ruta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "prestamo.txt");
       

        Dictionary<string,Prestamo>prestamo= new Dictionary<string,Prestamo>();
        int opcion = 0;
        

        do
        {
            Console.WriteLine("\n **Sistema de precios**");
            Console.WriteLine("1. Registrar prestamo");
            Console.WriteLine("2. Buscar Codigo");
            Console.WriteLine("3. Mostrar todos los registros");
            Console.WriteLine("4. Eliminar");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opcion");
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese un valor valido");
                Console.ReadKey();
                continue;
            }
            
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("\n--- REGISTRO DE DATOS ---");
                    Console.Write("Código: "); 
                    string codigo = Console.ReadLine();
                    Console.Write("Nombre: ");
                    string estudiante = Console.ReadLine();
                    Console.Write("Carnet: ");
                    string carnet = Console.ReadLine();
                    Console.Write("Carrera: ");
                    string carrera = Console.ReadLine();
                    Console.Write("Equipo: "); 
                    string equipo = Console.ReadLine();
                    Console.Write("Cantidad: ");
                    int cantidad;
                    while (!int.TryParse(Console.ReadLine(), out cantidad))
                    {
                        Console.WriteLine("Ingrese un número para la cntidad");
                    }     
                    Console.Write("Estado: "); 
                    string estado = Console.ReadLine();

                    Prestamo p=new Prestamo(codigo,estudiante, carnet, carrera,equipo,cantidad,estado);

                    prestamo.Add(p.Codigo, p);
                    p.GuardarEnArchivo(ruta);
                    Console.WriteLine("\n Cuardado correctamente");
                   Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("\n Ingrese cosigo a buscar ");
                        string buscar= Console.ReadLine();
                    if (prestamo.ContainsKey(buscar))
                    {
                        Console.WriteLine("\n Resultado");
                        Console.WriteLine(prestamo[buscar].ResumenConsola());
                    }
                    else
                    {
                        Console.WriteLine("codigo no encontrado");
                    }
                    Console.ReadKey();
                    break;
                    case 3:
                    Console.WriteLine("\n Listado de memoria");
                    if (prestamo.Count==0)
                    {
                        Console.WriteLine("No hay datos registrados");
                    }
                    else
                    {
                        foreach (Prestamo item in prestamo.Values)
                        {
                            Console.WriteLine(item.ResumenConsola());
                        }
                    }
                    Console.ReadKey ();
                    break;
                    case 4:
                    Console.WriteLine("Codigo a eliminar");
                    string eliminar= Console.ReadLine();
                    if (prestamo.Remove(eliminar))
                    {
                        Console.WriteLine("Eliminado");
                    }
                    else
                    {
                        Console.WriteLine("Codigo no encontrado");
                    }
                    Console.ReadKey();
                    break;
                    case 5:
                    Console.WriteLine("Saliendo del programa");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    Console.ReadKey();
                    break;
            }




        }
        while (opcion!=5);

    }

}
