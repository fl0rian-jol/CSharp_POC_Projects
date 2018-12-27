using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace BasicTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DNSLookup("www.google.com");
        }

        private static void showResult()
        {
            IList<int> listRand = new List<int>();

            Random rnd = new Random();

            while (listRand.Count < 7)
            {
                int randToAdd = rnd.Next(1, 50);

                if (!listRand.Contains(randToAdd))
                    listRand.Add(randToAdd);
            }

            Console.ReadKey();

            foreach (var rand in listRand)
            {
                Console.WriteLine($"Le numéro aléatoire a la valeur : {rand}");
            }
        }

        private static void NullIntoListTest()
        {
            IList<ExampleClass> list = new List<ExampleClass>();

            ExampleClass ec1 = new ExampleClass()
            {
                Nom = "JOLIVET",
                Prenom = "Florian",
                Age = 23,
            };

            ExampleClass ec2 = new ExampleClass()
            {
                Nom = "PERILLAT",
                Prenom = "Charline",
                Age = 21,
            };

            ExampleClass ec3 = null;

            list.Add(ec1);
            list.Add(ec3);
            list.Add(ec2);
        }

        private static void GenerateGuidTest()
        {
            Guid g = Guid.NewGuid();
            string test = g.ToString();
        }

        private static void DeleteFolderFromPathTest()
        {
            string folderPathToDelete = @"D:\Users\florian.jolivet\Desktop\test";
            if (!Directory.Exists(folderPathToDelete))
            {
                throw new DirectoryNotFoundException();
            }
            else
            {
                Directory.Delete(folderPathToDelete, true);
            }
        }

        private static void GetTypeByVar<TSource>()
        {
            var a = "test";
            var b = 123;

            var typeA = a.GetType();
            var typeB = b.GetType();
        }
        
        private static void GetEnumValueNameString()
        {
            string value = Enum.GetName(typeof(ExampleClass.EnumExample), ExampleClass.EnumExample.Chien);
        }

        private static void DNSLookup(string url)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(url);
            Console.WriteLine("  Host Name: {0}", hostEntry.HostName);

            IPAddress[] ips = hostEntry.AddressList;
            foreach (IPAddress ip in ips)
            {
                Console.WriteLine("  Adresse IP: {0}", ip);
            }

            Console.WriteLine();
        }
    }
}
