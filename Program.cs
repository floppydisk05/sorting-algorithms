using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Reflection;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sorting_algorithms {
    class Program {
        static void Main(string[] args) {
            List<int> nums = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            nums.ForEach(Console.WriteLine);
            Random random = new Random();
            for (int i = nums.Count - 1; i > 0; i--) {
                int randomIndex = random.Next(0, i + 1);

                int temp = nums[i];
                nums[i] = nums[randomIndex];
                nums[randomIndex] = temp;
            }
            Console.WriteLine("\n");
            nums.ForEach(Console.WriteLine);
        }

        /*
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list) {
            int n = list.Count();
            while (n > 1) {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }*/
    }
}
