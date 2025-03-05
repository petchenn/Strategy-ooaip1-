using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooaip1
{
    class PolsSort
    {
        
        private int[] array;
        private bool org;
        private Sort sort;
        public PolsSort(string filename, int sw, bool _org)
        {
            ArrayRead(filename);
            org = _org;
            switch (sw)
            {
                case 1:
                    BubbleSort bsort = new BubbleSort();
                    sort = new Sort(bsort);
                    break;
                case 2:
                    ChooseSort chsort = new ChooseSort();
                    sort = new Sort(chsort);
                    break;
                case 3:
                    QuickSort qsort = new QuickSort();
                    sort = new Sort(qsort);
                    break;
                default:
                    break;
            }

        }
        public void ArraySort()
        {
            array = sort.Ssort(array, org);
            printArray();
        }

        private void ArrayRead(string _filePath)
        {
            string filePath = _filePath;

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                string allNumbers = string.Join(" ", lines);
                array = allNumbers.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(int.Parse)
                                           .ToArray();

                Console.WriteLine("Считанные числа из файла:");
                printArray();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ошибка формата данных: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
       public void printArray()
        {
            foreach (var s in array)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
