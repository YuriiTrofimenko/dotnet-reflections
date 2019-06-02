using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsDemo
{
    class Producer
    {
        public static dynamic GetSurprise() {

            dynamic result = null;
            switch (new Random().Next(1, 4))
            {
                case 1:
                    {
                        // result = new Person() { id = 12, Name = "John" };
                        result = new Person(12, "John");
                        break;
                    }
                case 2:
                    {
                        result = new { id = 15, Name = "Ivan", Surname = "Ivanov" };
                        break;
                    }
                case 3:
                    {
                        result = new { id = 20, Data = new Person(20, "Vasilii") };
                        break;
                    }
                default:
                    break;
            }
            return result;
        }
    }
}
