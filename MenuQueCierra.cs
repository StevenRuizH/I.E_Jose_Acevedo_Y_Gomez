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
		while (opcion !=3)
		{
			Console.WriteLine("Bienvenido al Menu de lectura");
			Console.WriteLine("1. Ingresar a la libreria");
			Console.WriteLine("2. Perfil");
			Console.WriteLine("3. Salir");
			Console.Write("Elegir nC:mero de opciC3n: ");

			opcion = Int32.Parse(Console.ReadLine());

			if(opcion == 1)
			{
				Console.WriteLine("LIBRERIA");


			}

			if(opcion == 2)
			{
				Console.WriteLine("Mi Perfil");
			}

			if(opcion == 3)
			{
				Console.WriteLine("Vuelve pronto...");
			}

			if(opcion>3)
			{
				Console.WriteLine("Valor incorrecto, volver a intentar...");
			}
		}
	}
}
