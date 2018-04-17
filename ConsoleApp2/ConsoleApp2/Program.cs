using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            using (Py.GIL())
            {

                dynamic tf = Py.Import("tensorflow");
                string V = "Hello,tensorflow";

                dynamic hello = tf.constant(V);
                dynamic sess = tf.Session();
                Console.WriteLine(sess.run(hello));
               
                Console.ReadKey();
            }

        }
    }
}
