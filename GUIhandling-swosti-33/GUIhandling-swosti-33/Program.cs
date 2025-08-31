using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIhandling_swosti_33
{

    public delegate void DelEventHandler();
    class Program:Form
    {
        public event DelEventHandler add;
        public Program()
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Hit Me";
            btn.Location = new Point(100, 100);

            btn.Click += new EventHandler(onClick);
            add += new DelEventHandler(Initiate);
            add();
        }
        public void Initiate()
        {
            Console.WriteLine("Event Initiated");
        }

        public void onClick(object sender,EventArgs e)
        {
            MessageBox.Show("You clicked me.");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
            Console.WriteLine();
        }
    }
}
