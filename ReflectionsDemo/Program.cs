using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type type = "".GetType();
            // Type type2 = typeof(string);
            // Console.WriteLine(Producer.GetSurprise().Surname);
            /*var result = Producer.GetSurprise();
            Type type = result.GetType();
            Console.WriteLine(type.Name);*/

            /* 1 */

            /* // Print All Public Fields
            Console.WriteLine("Print All Public Fields:");
            foreach (var fieldInfo in type.GetFields())
            {
                Console.WriteLine(fieldInfo.Name + " = " + fieldInfo.GetValue(result));
            }

            // ... Then Other Fields
            Console.WriteLine("Then Other Fields:");
            foreach (var fieldInfo in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(fieldInfo.Name + " = " + fieldInfo.GetValue(result));
            }

            // Properties:
            Console.WriteLine("Then Other Props:");
            foreach (var propInfo in type.GetProperties())
            {
                Console.WriteLine(propInfo.Name + " = " + propInfo.GetValue(result));
            } */

            /* 2 */
            /* Console.WriteLine("Read 1");
            foreach (var fieldInfo in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(fieldInfo.Name + " = " + fieldInfo.GetValue(result));
                if (fieldInfo.Name == "id")
                {
                    fieldInfo.SetValue(result, 55);
                }
            }
            Console.WriteLine("Read 2");
            foreach (var fieldInfo in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(fieldInfo.Name + " = " + fieldInfo.GetValue(result));
            } */

            /* 3 */
            /* Console.WriteLine("Methods:");
           foreach (var methodInfo in type.GetMethods())
           {
               Console.WriteLine(methodInfo.Name);
               if (methodInfo.GetParameters().Length == 0)
               {
                   methodInfo.Invoke(result, null);
               }
               else {
                   if (methodInfo.ReturnType.Name != "void")
                   {
                       Console.WriteLine(methodInfo.Invoke(result, new object[1]));
                   }
                   else {
                       methodInfo.Invoke(result, new object[1]);
                   }
               }

           } */

            /* 4 */
            /* Console.WriteLine("Methods:");
            Type objType = typeof(object);
            List<string> objectMethodsNames = new List<string>();
            foreach (var method in objType.GetMethods())
            {
                objectMethodsNames.Add(method.Name);
            }
            foreach (var methodInfo in type.GetMethods())
            {
                if (!objectMethodsNames.Contains(methodInfo.Name))
                {
                    Console.WriteLine(methodInfo.Name);
                }
            } */

            /* 5 */
            /* foreach (var methodInfo in type.GetMethods())
            {
                if (methodInfo.Name == "Say")
                {
                    methodInfo.Invoke(result, new object[1] { "Hi" });
                }
                if (methodInfo.Name == "Say" && methodInfo.GetParameters()[0].ParameterType.Name.ToLower() != "string")
                {
                    methodInfo.Invoke(result, new object[1] { 999 });
                }
            } */

            /* 6 */
            Type pType = Type.GetType("ReflectionsDemo.Person");
            var o1 = pType.GetConstructor(Type.EmptyTypes).Invoke(null);
            Console.WriteLine(o1);
        }
    }
}
