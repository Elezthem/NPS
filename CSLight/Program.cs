using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NonePlayerCharcter[] charcters =
            {
                new NonePlayerCharcter(),
                new Farmer(),
                new Knight(),
                new Child()
            };

            foreach (var charcter in charcters)
            {
                charcter.ShowDescription();
                Console.WriteLine(new String('-', 40));
            }
        }
    }

    class NonePlayerCharcter
    {
        public virtual void ShowDescription()
        {
            Console.WriteLine("Я ничего не делаю, потому-что я простой NPS");
        }
    }

    class Farmer : NonePlayerCharcter
    {
        public override void ShowDescription()
        {
            base.ShowDescription();
            Console.WriteLine("Я фермер и я умею работать на поле.");
        }
    }

    class Knight : NonePlayerCharcter
    {
        public override void ShowDescription()
        {
            Console.WriteLine("Я рыцарь! Моё дело сражаться и защищать!");
        }
    }

    class Child : NonePlayerCharcter
    {

    }
}