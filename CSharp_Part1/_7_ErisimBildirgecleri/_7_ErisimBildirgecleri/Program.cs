/*
    Attribute/Properties/Fields DEFAULT olarak private'tir.
    Class'in DEFAULT'U INTERNAL'dir !!!!!!!!!
    internal o proje icinde istedigimiz yerde cagirabilecegimiz anlamina gelir.
    public ve internal farki sudur: internalda sadece o proje icinde gecerlidir.
    public de ise diger projelerden de erisileibilir. Ama ilk once References kismindan projeyi eklemek
    ve diger projede kutuphaneye bu projeyi eklemek gerekir.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ErisimBildirgecleri
{  
    class Program
    {
        static void Main(string[] args)
        {
          

            Console.Read();

        }
    }

    class Customer
    {
        public string name;

        private string surname { get; set; }

        protected int age;

    }

    class Student:Customer
    {
        public void save()
        {
            Customer customer = new Customer();
            
           
            
        }

    }

    public class ABCDEF
    {

    }

    
  
}
