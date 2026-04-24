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

    }

}
