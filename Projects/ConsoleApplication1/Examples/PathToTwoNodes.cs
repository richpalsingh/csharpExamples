using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    

    /// <summary>
    /// Given a directed graph, design an algorithm to find out whether there is a route between two nodes.
    /// </summary>
    public class PathToTwoNodes
    {
       

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int matrix_i = 0; matrix_i < n; matrix_i++)
            {
                string[] matrix_temp = Console.ReadLine().Split(' ');
                matrix[matrix_i] = Array.ConvertAll(matrix_temp, Int32.Parse);
            }
           // int result = ConnectedCell(matrix);
          //  Console.WriteLine(result);
        }


    }
}
