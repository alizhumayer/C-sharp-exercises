using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HSGradSolutions
{
    class Program
    {
        public static string BasePath { get; private set; }

        static void Main(string[] args)
        {
            if (args.Length != 2)
                args = new string[] { "2019", "10" };

            var main = Initialize(args);


            if (main == null)
            {
                Console.WriteLine("Nem található érettségi feladat.");
            }
            else
            {
                main.Invoke(null, new object[] { args });
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("A kilépéshez nyomjon ENTER-t");
            Console.ReadLine();
        }

        #region setup

        private static MethodInfo Initialize(string[] args)
        {
            var year = int.Parse(args[0]);
            var month = int.Parse(args[1]);

            var gradType = typeof(Program).Assembly.GetTypes().FirstOrDefault(t =>
              {
                  var attr = t.GetCustomAttributes(typeof(ErettsegiAttribute), false).FirstOrDefault() as ErettsegiAttribute;
                  return attr?.Year == year && attr?.Month == month;
              });
            if (gradType != null)
            {
                Program.BasePath = $"data\\{year}{month:00}\\";
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(BasePath, "megoldas"));
                return gradType.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);
            }
            return null;
        }
        #endregion
    }
}
