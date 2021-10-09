using System;
using System.Linq;
using System.Collections.Generic;

using Serilog;
namespace sorting_algorithms {
    class Program {
        static void Main(string[] args) {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            // Define a list
            List<int> nums = new List<int>() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine("Original List:");
            nums.ForEach(Console.WriteLine);

            // Shuffle the list
            Console.WriteLine("\n\nShuffled List");
            Log.Information("List Shuffled");
            shuffleList(nums).ForEach(Console.WriteLine);
            Log.Information("Running Bubble Sort");
            bubbleSort(nums).ForEach(Console.WriteLine);
            Log.Information("Running Selection Sort");
            selectionSort(nums).ForEach(Console.WriteLine);
            Log.Information("Running Insertion Sort");
            insertionSort(nums).ForEach(Console.WriteLine);

            Log.CloseAndFlush();

        }

        public static List<int> shuffleList(List<int> list) {
            Random random = new Random();
            for (int i = list.Count - 1; i > 0; i--) {
                int randomIndex = random.Next(0, i + 1);

                int temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
            return list;
        }

        public static List<int> bubbleSort(List<int> list) {
            for (int i = 0; i < list.Count(); i++) {
                for (int j = 0; j < list.Count() - i - 1; j++) {
                    if (list[j] > list[j + 1]) {
                        int temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }        
            return list;    
        }
        
        public static List<int> selectionSort(List<int> list) {
            int temp, smallest;
            int n = list.Count();
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (list[j] < list[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = list[smallest];
                list[smallest] = list[i];
                list[i] = temp;
            }
            return list;
        }

        public static List<int> insertionSort(List<int> list) {
            for (int step = 1; step < list.Count(); step ++) {
                int key = list[step];
                int j = step - 1;
                while (j >= 0 && key < list[j]) {
                    list[j + 1] = list[j];
                    j -= 1;
                }
                list[j + 1] = key;
            }
            return list;
        }
    }
}
