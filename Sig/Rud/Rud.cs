using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SharedLibra;

namespace Rud
{
    class Rud
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;

            // Чтение информации из файла
            string filePath = "C:\\Users\\Anton\\Source\\Repos\\Sig\\Wruter\\bin\\Debug\\example.txt";
            string content = string.Empty; //пустая строка
            if (File.Exists(filePath)) //проверка на существование
            {
                content = File.ReadAllText(filePath);
            }

            singleton.SetData(content); //добавляю

            Console.WriteLine("Прочитанная информация из файла: " + singleton.GetData());
            Console.ReadLine();
        }
    }
}
