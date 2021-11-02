using System;
using System.Linq;
namespace ResizePrincipeTasklari
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        #region Task2
        static void Ardicilliq()
        {
           int[] array = {1,2,3,4,5,6,7,8,9,10 };
            if (array.Length == 10)
            {
                Array.Sort(array);
            }
            else
            {
                Array.Resize(ref array, 10);
                Array.Sort(array);
            }
            for (int i = 0; i < 10; i++) {
                //Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Task3

        static void task() {
            byte[] arr1 = { 1, 5, 3 };
            byte[] arr2 = { 4, 2, 6 };
            if(arr1.Length == arr2.Length)
            {
               arr1 = arr1.Concat(arr2).ToArray();
            }
            Array.Sort(arr1);
            for (int i = 0; i < arr1.Length * 2; i++)
            {
                //Console.WriteLine(arr1[i]);
            }

        }

        #endregion

        #region Task4
        static string Cap()
        {
            byte[] array = { 1, 2, 3, 4, 5 };
            Array.Sort(array);
            return $"min: { array[0]} max {array[array.Length - 1]}";
            
        }
        #endregion

        #region Task5
        static string Chap() { 
        byte[] array = {1,2,3,4,5,6,7,8,9,10 };
            byte[] cut = new byte[5];
            byte[] tek = new byte[5];
            int b = 0;
            for(int i = 0; i<array.Length; i++) {
                if (array[i] % 2 == 0) {
                    cut[b] = array[i];
                    b++;
                }
                else
                {
                    tek[b] = array[i];
                    b++;
                }
            }
            return $"tek ededler arrayi: {tek[0]} {tek[1]} {tek[2]} " +
                $"{tek[3]} {tek[4]}. cut ededler arrayi: {cut[0]} {cut[1]} {cut[2]} {cut[3]} {cut[4]} ";
        }
        #endregion
    }
}
