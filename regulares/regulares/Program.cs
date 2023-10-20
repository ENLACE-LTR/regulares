using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Expresión regular para validar una URL simple
        string patron = @"^(https?://)?([a-zA-Z0-9.-]+)\.([a-zA-Z]{2,6})(:[0-9]+)?(/[\w.-]*)*(\?\S*)?$";

        string url = "https://www.ejemplo.com";

        if (Regex.IsMatch(url, patron))
        {
            Console.WriteLine("La URL es válida.");
        }
        else
        {
            Console.WriteLine("La URL no es válida.");
        }
        string patroncorreo = @"^([a-zA-Z0-9.-]+)\@([a-zA-Z]+)\.([a-zA-Z]{2,3})$";
        Console.WriteLine("Escribe un correo: ");
        string correo=Console.ReadLine();


        if (Regex.IsMatch(correo, patroncorreo))
        {
            Console.WriteLine("Correo valido.");
        }
        else
        {
            Console.WriteLine("Correo invalido.");
        }
        string patronCURP= @"^([A-Z]{4})([0-9]{6})([H|M])([A-Z]{2})([A-Z]{3})([0-9]{2})$";
        Console.WriteLine("Escribe una CURP: ");
        string CURP = Console.ReadLine();
        if (Regex.IsMatch(CURP, patronCURP))
        {
            Console.WriteLine("CURP valido.");
        }
        else
        {
            Console.WriteLine("CURP invalido.");
        }
    }
}
//Este código utiliza la clase Regex del espacio de nombres System.Text.RegularExpressions 
//para realizar una coincidencia de patrones con la URL proporcionada. 
//La expresión regular patron en este ejemplo valida una URL que 
//comienza con "http://" o "https://", seguido de un dominio, una posible port, y una posible ruta.

//Puedes ajustar esta expresión regular según tus necesidades específicas de validación de URL.




