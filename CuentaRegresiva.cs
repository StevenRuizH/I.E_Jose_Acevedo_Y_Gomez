/******************************************************************************

Autor:       Steven Ruiz - Juan Pablo Zuluaga -Sheyra Cuevas - Yeferson Nieto

Fecha:       26-08-2024

Descripcion: Cuenta regresiva del 99 al 1 usando el comando PARA.

*******************************************************************************/
using System; 

class CuentaRegresiva
{
    static void Main()
    {
        int Num;
        for (Num=99; Num>=1;Num=Num-1)
        {
            Console.WriteLine(Num);
        }
    }
}
