using System.Collections.Generic;
using System;
using ConsoleApp4;

class Program
{
    static void Main(string[] args)
    {
        Matriz linkedList = new Matriz(20, 20); //Crea la matriz tamaño (Alto, ancho)
        Bike bike = new Bike(linkedList.GetNode(2, 2)); //Crea la moto en una posicion inicial de 2,2

        linkedList.DisplayMatrix(); //Llama el metodo para representar la matriz

        ConsoleKeyInfo key;
        do
        {
            key = Console.ReadKey(true); //Lector de eventos de teclado
            switch (key.Key)
            {
                case ConsoleKey.W:
                    bike.MoveUp();
                    break;
                case ConsoleKey.S:
                    bike.MoveDown();
                    break;
                case ConsoleKey.A:
                    bike.MoveLeft();
                    break;
                case ConsoleKey.D:
                    bike.MoveRight();
                    break;
            }

            Console.Clear(); //Limpia la matriz antes de mostrar la nueva matriz actualizada
            linkedList.DisplayMatrix(); //Muestra la matriz actualizada

        } while (key.Key != ConsoleKey.Escape); //Cierra el programa. Sale del loop al apretar escape
    }
}
