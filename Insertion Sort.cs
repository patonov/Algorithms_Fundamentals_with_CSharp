﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            InsertionSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));

        }
        private static void InsertionSort(int[] numbers)
        {

            for (int i = 1; i < numbers.Length; i++)
            {
                var j = i;
                while (j > 0 && numbers[j - 1] > numbers[j])
                {
                    Swap(numbers, j, j - 1);
                    j -= 1;

                }
            }

        }
        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;

        }
    }
  }
