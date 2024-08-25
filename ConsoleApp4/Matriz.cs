using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Matriz
    {
        private Node[,] matrix;

        public Matriz(int rows, int cols)
        {
            matrix = new Node[rows, cols];
            //Inicializa la matriz con sus nodos.
            for (int i = 0; i < rows; i++) //Bucle que itera sobre cada fila
            {
                for (int j = 0; j < cols; j++)//En cada fila itera sobre toda la columna.
                {
                    matrix[i, j] = new Node();//Crea un nodo en cada ubicacion.
                }
            }
            //Connecta los nodos en las 4 direcciones.
            for (int i = 0; i < rows; i++)//itera igual por toda la matriz
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i > 0) matrix[i, j].Up = matrix[i - 1, j]; //si el nodo no esta en la primera fila,Entonces tiene un Nodo arriba,al que se le asigna una referencia desde el actual al de arriba.
                    if (i < rows - 1) matrix[i, j].Down = matrix[i + 1, j];//Si el nodo no esta en la ultima fila,Significa que tiene un nodo debajo,le asigna una referencia.
                    if (j > 0) matrix[i, j].Left = matrix[i, j - 1];//si el nodo no esta en la primera columna,significa que tiene un nodo a la izquierda,al que le asigna una referencia desde el actual al de la izquierda
                    if (j < cols - 1) matrix[i, j].Right = matrix[i, j + 1];//Si el nodo no esta en la ultima columna,Significa que tiene un nodo a la derecha.le asigna referencia.
                }
            }
        }

        //Metodo para obtener un nodo especifico de la matriz
        public Node GetNode(int row, int col)
        {
            return matrix[row, col];
        }
        //Metodo que actualiza la clase matriz para mostrarlo en pantalla.
        public void DisplayMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].Data.PadRight(5)); //Ajustar padding
                }
                Console.WriteLine();
            }
        }
    }
}
