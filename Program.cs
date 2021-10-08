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
            // Define a list
            List<int> nums = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            nums.ForEach(Console.WriteLine);

            // Shuffle the list
            Random random = new Random();
            for (int i = nums.Count - 1; i > 0; i--) {
                int randomIndex = random.Next(0, i + 1);

                int temp = nums[i];
                nums[i] = nums[randomIndex];
                nums[randomIndex] = temp;
            }
            
            bubbleSort(nums);
        }

        public static void bubbleSort(List<int> list) {
            Console.WriteLine("\n\n\n");
            bool ordered = false;
            while (ordered == false) {
                for (int x = 0; x < list.Count(); x++) {
                    // If this is the first item in the list, do nothing
                    if (x == 0) { continue; }
                    else {

                    }
                }
            }
        }
    }
}
