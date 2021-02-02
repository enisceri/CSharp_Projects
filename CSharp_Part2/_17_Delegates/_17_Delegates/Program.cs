using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Delegates
{
    public delegate void MyDelegate();
    public delegate void MyStringDelegate(string text);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage("Hello");
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.ShowAlert;
            myDelegate();

            MyStringDelegate myStringDelegate = customerManager.SendMessage;
            myStringDelegate("Hello Enis Ceri");

            Console.Read();
        }
    }

    public class CustomerManager
    {
        public void SendMessage(string text)
        {
            Console.WriteLine(text);
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful !");
        }
    }
}
