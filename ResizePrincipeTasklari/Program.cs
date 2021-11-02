using System;
using System.Linq;
namespace ResizePrincipeTasklari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ardicilliq();
            //task();
            //Cap();
            //Chap();
        }
        #region Task2
        static void Ardicilliq()
        {
           int[] array = {1,2,3,4,5,6,7,8,9,10 };
            if (array.Length == 10)
            {
                Array.Sort(array);
                Array.Reverse(array);
            }
            else
            {
                Array.Resize(ref array, 10);
                Array.Sort(array);
                Array.Reverse(array);
            }
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(array[i]);
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
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

        }

        #endregion

        #region Task4
        static void Cap()
        {
            byte[] array = { 1, 2, 3, 4, 5 };
            Array.Sort(array);
            Console.WriteLine( "min: "+array[0] +"max: "+array[array.Length - 1]);
            
        }
        #endregion

        #region Task5
        static string Chap() { 
        byte[] array = {1,2,3,4,5,6,7,8,9,10 };
            byte[] cut = new byte[0];
            byte[] tek = new byte[0];
            
            for(int i = 0; i<array.Length; i++) {
                if (array[i] % 2 == 0) {
                    Array.Resize(ref cut, cut.Length+1);
                    cut[cut.Length-1] = array[i];
                }
                else
                {
                     Array.Resize(ref tek, tek.Length + 1);
                    tek[tek.Length - 1] = array[i];
                }
            }
            Console.WriteLine("Cut ededler:");
            for(int i =0; i<cut.Length; i++)
            {
                Console.WriteLine(cut[i]);
            }
            Console.WriteLine("Tek ededler:");
            for (int i = 0; i < tek.Length; i++)
            {
                Console.WriteLine(tek[i]);
            }
        }
        #endregion
    }
}
