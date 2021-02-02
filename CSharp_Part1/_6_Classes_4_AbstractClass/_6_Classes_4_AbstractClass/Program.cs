using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Classes_4_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseDataBase dataBase = new SqlServerDataBase();
            dataBase.add();
            dataBase.delete();

            BaseDataBase dataBase2 = new OracleDataBase();
            dataBase2.add();
            dataBase2.delete();

            Console.Read();
        }
    }

    abstract class BaseDataBase
    {
        public void add()
        {
            Console.WriteLine("Added by default.");
        }

        public abstract void delete();
    }

    class SqlServerDataBase:BaseDataBase
    {
        public override void delete()
        {
            Console.WriteLine("Deleted by SqlServer.");      
        }

    }

    class OracleDataBase:BaseDataBase
    {
        public override void delete()
        {
            Console.WriteLine("Deleted by Oracle.");
        }
    }
}
