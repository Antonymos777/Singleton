using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharedLibra;

namespace Wruter
{
    class Wruter
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance; //возвращаю единственный экземпляр класса
            Console.WriteLine("Введите информацию для записи в файл:");
            string input = Console.ReadLine();  //запись информации в файл
            singleton.SetData(input); 

            // создание файла
            string filePath = "example.txt";
            using (StreamWriter writer = new StreamWriter(filePath)) //запись символьных данных в файл
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Информация успешно записана в файл.");
            Console.ReadLine();
        }

    }
}
