using System;
using System.IO;

class Program_Ficheros
{
    static void Main(string[] args)
    {
        string ruta = "C:/campions.txt";
        string himno = "HIMNO DE TU EQUIPO FAVORITO";

        // Comprobar si el archivo existe
        if (File.Exists(ruta))
        {
            Console.WriteLine("HIMNO YA AÑADIDO");
        }
        else
        {
            // Crear el archivo y añadir el himno
            File.WriteAllText(ruta, himno);
            Console.WriteLine("Archivo creado y himno añadido.");
        }

        Console.ReadLine();
    }
}