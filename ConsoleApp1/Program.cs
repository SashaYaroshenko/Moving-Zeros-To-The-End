using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
        }
    }

    public class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            int count = arr.Count(i=>i==0);
            arr = arr.Where(i=>i!=0).ToArray();
            string arr1 = String.Join("", arr).PadRight(arr.Length + count, '0');
            List<int> list = new List<int>();
            foreach(char i in arr1)
                list.Add(int.Parse(i.ToString()));
           return list.ToArray();
        }
    }
}
