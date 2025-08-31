using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void DelEventHandler();

    class Program
    {
      
        
            public event DelEventHandler add;
            public Program()
            {
                add = new DelEventHandler(Initiate);
                add();
            }

        public void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }

    

    static void Main(string[] args)
        {
            new Program();
            Console.ReadLine();
        }
    }
}
