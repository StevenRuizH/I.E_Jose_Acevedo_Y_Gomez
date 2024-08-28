/******************************************************************************

Autor:       Steven Ruiz - Simon Gallego - Samuel CastaC1o - Jeronimo Pulgarin
             Juan Jose Tapasco - David Becerra

Fecha:       28-08-2024

Descripcion: Programa que genera unos corredores y cumple ciertos criterios
*******************************************************************************/
using System;

class Carrera
{
	static void Main()
	{
		for (int i = 1; i <= 7; i++)
		{
			Console.WriteLine(i +":");

			if (i == 1)
			{
				Console.WriteLine("Eres el campeon seC1or uno");
			}

			if (i == 3)
			{
				Console.WriteLine("el pueblo esta contigo tres");
			}

			if (i > 1)
			{
				Console.WriteLine("Animo, Animo, Animo");
			}

			if (i > 3)
			{
				Console.WriteLine("Tu puedes, Tu puedes");
			}
		}
	}
}
