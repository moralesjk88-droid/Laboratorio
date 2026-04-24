// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

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
        return "Cod: " + codigo + " | Estudiante: " + estudiante + " | Equipo: " + equipo + " | Estado: " + estado;
    }
}
