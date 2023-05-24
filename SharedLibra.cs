using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibra
{
    public class Singleton
    {
       private static Singleton instance; //моё приватное статическое поле класса 
        private string data;//поле, хранит данные экземпляра класса

        public static Singleton Instance //публичное статическое свойство класса 
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton(); //создание нового экземпляра
                }
                return instance;
            }
        }

        public string GetData()
        {
            return data;
        }

        public void SetData(string newData)
        {
            data = newData;
        }
    }
}
