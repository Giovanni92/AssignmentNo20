using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssignmentNo20
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi hi = new SayHi(); string name = "Adele"; int count = 2;
            List<Thread> listOfThreads = new List<Thread>();

            listOfThreads.Add(new Thread(new ThreadStart(() => hi.SayHiEnglish(name, count))));
           
        }
    }

    class SayHi
    {

        public void SayHiEnglish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hi " + name);
            }
        }

        public void SayHiKorean(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Annyeong " + name);
            }
        }
        public void SayHiFrench(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Salut " + name);
            }
        }

        public void SayHiGreek(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Geia " + name);
            }
        }

        public void SayHiHindi(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Namaste " + name);
            }
        }

        public void SayHiRussian(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Zdravstvuy " + name);
            }
        }

        public void SayHiSwedish(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Hej " + name);
            }
        }


    }
}
