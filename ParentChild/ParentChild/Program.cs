using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChild
{

    abstract class Parent1
    {
        public int x, y, z;
        public Parent1()
        {
            x = 10; y = 20; y = 5;
        }
        public abstract int sum();

    }

    abstract class Child1 : Parent1
    {
        public new int z;
        public new int y;
        public Child1()
        {
            y = 30; z = 50;
        }
        public override int sum()
        {
            return x + y + z;
        }

    }

    class Parent
    {
        public int x;   // доступен для наследования и для внешнего кода   protected int y; // дост. для наследования и производных классов
        public int y; // дост. для наследования и производных классов
        private int z;  // не доступен для наследования и произв. класса
        int a;     // то же, что и private
        public Parent()
        {
            x = 10; y = 20; z = 100; a = x;
        }
        public virtual string MyString(string s)
        {
            return "MyString " +s;
        }
    }

    sealed class SealedParent
    {
        public int x;   // доступен для наследования и для внешнего кода   protected int y; // дост. для наследования и производных классов
        protected int y; // дост. для наследования и производных классов
        private int z;  // не доступен для наследования и произв. класса
        int a;     // то же, что и private
        public SealedParent()
        {
            x = 10; y = 20; z = 100; a = x;
        }
    }

    class Child : Parent
    {
        public int z;
        public new int y; 
        public Child()
        { 
            y = 30; z = 50; 
        }
        public override string MyString(string s)
        {
            return "Overrided string " + s;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child c = new Child();
            Console.WriteLine("Parent x, y: {0} {1}", p.x, p.y);
            Console.WriteLine("Child x, y, z: {0} {1} {2}", c.x, c.y, c.z);
            Console.ReadLine();
        }
    }
}

