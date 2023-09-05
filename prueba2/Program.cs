using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Que categoria le gustaria");
        Console.WriteLine("1. De 3 estrellas");
        Console.WriteLine("2. De 5 estrellas");
        Console.Write("Seleccione una opción (1/2): ");


        string categoriadetexto = Console.ReadLine();
        int opcion = int.Parse(categoriadetexto);

        Console.WriteLine("Dias de estadia :");

        string diasdeestadiatxt = Console.ReadLine();
        int DiasDeEstadia = int.Parse(diasdeestadiatxt);


        float costodedesayuno = 7f;
        float costopordia = 0f;

        switch (categoriadetexto)
        {
            case "1":

                if (DiasDeEstadia <= 5)
                {
                    costopordia = 100f + costodedesayuno * DiasDeEstadia;
                }
                else

               if (DiasDeEstadia >= 6 - 10)
                {
                    costopordia = 85f + costodedesayuno * DiasDeEstadia;
                }
                
                
                if (DiasDeEstadia >= 11)
                {
                    costopordia = 70f + costodedesayuno * DiasDeEstadia;
                }

                Console.WriteLine("El costo complewto sale : " + costopordia);

                break;
            case "2":
                Console.WriteLine("Ha seleccionado categoria de 5 estrellas:");

                if (DiasDeEstadia <= 5)
                {
                    costopordia = 300f + costodedesayuno * DiasDeEstadia;
                }else
              
                if (DiasDeEstadia >= 6 - 10)
                {
                    costopordia = 270f + costodedesayuno * DiasDeEstadia;
                }
               
                if (DiasDeEstadia >= 11)
                {
                    costopordia = 250f + costodedesayuno * DiasDeEstadia;
                }
                Console.WriteLine("El costo complewto sale : " + costopordia);
                break;
                default:
                {
                    Console.WriteLine("opcion no disponible");
                }
                break;
                
            
        }
        Console.ReadKey();
        Console.Read();
    }
}

 