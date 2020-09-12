using System;

namespace Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Creamos la celda
            Celda c1 = new Celda(2,3);

            //Creamos la pieza
            Pieza p1 = new Pieza(false,false,c1);

            Celda posicion = p1.GetPosicion();
            Console.WriteLine("La pieza se encuentra en la posicion X: " + p1.GetPosicion().GetPosicionX().ToString());
            Console.WriteLine("La pieza se encuentra en la posicion Y: " + posicion.GetPosicionY().ToString());

            //seteamos el ocupante
            c1.SetOcupante(p1);
            Console.WriteLine("La celda tiene el ocupante" + c1.GetOcupante().ToString());

            //Otro cambio desde el vs code
        }
    }
}
