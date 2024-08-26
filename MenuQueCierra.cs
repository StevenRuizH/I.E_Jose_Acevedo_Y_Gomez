/******************************************************************************

Autor:       Steven Ruiz - Juan Pablo Zuluaga

Fecha:       21-08-2024

Descripcion: Menu que cierra cuando el usuario lo elige
*******************************************************************************/
using System;

class CloseMenu
{
    static void Main()
    {
        int opcion = 0;
        while (opcion != 3)
        {
            Console.WriteLine("Bienvenido al Menu de lectura");
            Console.WriteLine("1. Ingresar a la libreria");
            Console.WriteLine("2. Perfil");
            Console.WriteLine("3. Salir");
            Console.Write("Elegir numero de opcion: ");

            opcion = Int32.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("\t\t\t   LIBRERIA");

                Console.WriteLine("             .--.           .---.        .-.              ");
                Console.WriteLine("         .---|--|   .-.     | A |  .---. |~|    .--.      ");
                Console.WriteLine("      .--|===|Ch|---|_|--.__| S |--|:::| |~|-==-|==|---.  ");
                Console.WriteLine("      |%%|NT2|oc|===| |~~|%%| C |--|   |_|~|CATS|  |___|-.");
                Console.WriteLine("      |  |   |ah|===| |==|  | I |  |:::|=| |    |GB|---|=|");
                Console.WriteLine("      |  |   |ol|   |_|__|  | I |__|   | | |    |  |___| |");
                Console.WriteLine("      |~~|===|--|===|~|~~|%%|~~~|--|:::|=|~|----|==|---|=|");
                Console.WriteLine("      ^--^---'--^---^-^--^--^---'--^---^-^-^-==-^--^---^-'");
                Console.WriteLine("");
            }

            if (opcion == 2)
            {
                Console.WriteLine("Mi Perfil");
                Console.WriteLine("");
            }

            if (opcion == 3)
            {
                Console.WriteLine("Vuelve pronto...");
            }

            if (opcion > 3)
            {
                Console.WriteLine("Valor incorrecto, volver a intentar...");
            }
        }
    }
}
