using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//из файла подаётся массив целых. Три различных сортировки по возрастанию и убыванию каждый

namespace ooaip1
{
    class Program
    {
        static void Main(string[] args)
        {
            PolsSort sort = new PolsSort("C:\\Users\\PS\\source\\repos\\ooaip1\\ooaip1\\Test.txt", 2, true);
            sort.ArraySort();
        }
    }
}
