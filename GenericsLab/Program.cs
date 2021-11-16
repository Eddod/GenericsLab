using System;
using System.Collections.Generic;
namespace GenericsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee E1 = new Employee(100, "Edwin", "Male", 20000);
            Employee E2 = new Employee(101, "Olle", "Male", 22000);
            Employee E3 = new Employee(102, "Anna", "Female", 25000);
            Employee E4 = new Employee(103, "Sara", "Female", 40000);
            Employee E5 = new Employee(104, "Harry", "Male", 25000);


            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(E1);
            EmpStack.Push(E2);
            EmpStack.Push(E3);
            EmpStack.Push(E4);
            EmpStack.Push(E5);



            foreach (var item in EmpStack)
            {


                Console.WriteLine("ID : {0}\nName : {1}\nGender : {2}\nSalary : {3}", item._ID, item._name, item._gender, item._salary);
                Console.WriteLine("Items left in stack : " + EmpStack.Count);
                Console.WriteLine("------------------------------------------");

            }


            //POP för att ta bort varje item
            Employee e1 = EmpStack.Pop();
            Console.WriteLine("Popped! : " + e1._ID + " " + e1._name + " " + e1._gender + " " + e1._salary);
            Console.WriteLine("Items left : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");
            Employee e2 = EmpStack.Pop();
            Console.WriteLine("Popped! : " + e2._ID + " " + e2._name + " " + e2._gender + " " + e2._salary);
            Console.WriteLine("Items left : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");
            Employee e3 = EmpStack.Pop();
            Console.WriteLine("Popped : " + e3._ID + " " + e3._name + " " + e3._gender + " " + e3._salary);
            Console.WriteLine("Items left : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");
            Employee e4 = EmpStack.Pop();
            Console.WriteLine("Popped! : " + e4._ID + " " + e4._name + " " + e4._gender + " " + e4._salary);
            Console.WriteLine("Items left : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");
            Employee e5 = EmpStack.Pop();
            Console.WriteLine("Popped! : " + e5._ID + " " + e5._name + " " + e5._gender + " " + e5._salary);
            Console.WriteLine("Items left : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            //Push för att lägga till igen
            EmpStack.Push(e1);
            Console.WriteLine("Peeking ");
            Employee s1 = EmpStack.Peek();
            Console.WriteLine(s1._ID + " " + s1._name);
            Console.WriteLine("Items in stack : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            EmpStack.Push(e2);
            Console.WriteLine("Peeking ");
            Employee s2 = EmpStack.Peek();
            Console.WriteLine(s2._ID + " " + s2._name);
            Console.WriteLine("Items in stack : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            EmpStack.Push(e3);
            Console.WriteLine("Peeking ");
            Employee s3 = EmpStack.Peek();
            Console.WriteLine(s3._ID + " " + s3._name);
            Console.WriteLine("Items in stack : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            EmpStack.Push(e4);
            Console.WriteLine("Peeking ");
            Employee s4 = EmpStack.Peek();
            Console.WriteLine(s4._ID + " " + s4._name);
            Console.WriteLine("Items in stack : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            EmpStack.Push(e5);
            Console.WriteLine("Peeking ");
            Employee s5 = EmpStack.Peek();
            Console.WriteLine(s5._ID + " " + s5._name);
            Console.WriteLine("Items in stack : " + EmpStack.Count);
            Console.WriteLine("------------------------------------------");

            if (EmpStack.Contains(e3))
            {
                Console.WriteLine("Item is in stack");
            }
            else
            {
                Console.WriteLine("Item is not in stack");
            }

            List<Employee> EmpList = new List<Employee>();
            Employee S1 = new Employee(100, "Edwin", "Male", 20000);
            Employee S2 = new Employee(101, "Olle", "Male", 22000);
            Employee S3 = new Employee(102, "Anna", "Female", 25000);
            Employee S4 = new Employee(103, "Sara", "Female", 40000);
            Employee S5 = new Employee(104, "Harry", "Male", 25000);
            EmpList.Add(S1);
            EmpList.Add(S2);
            EmpList.Add(S3);
            EmpList.Add(S4);
            EmpList.Add(S5);

            if (EmpList.Contains(S2))
            {
                Console.WriteLine("Employee object2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee object does not exist in the list");
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Find first object with gender Male");

            Employee em = EmpList.Find(x => x._gender == "Male");
            Console.WriteLine(em._ID + " " + em._name);
            Console.WriteLine("--------------------------------------");

            List<Employee> Genders = EmpList.FindAll(x => x._gender == "Male");
            Console.WriteLine("There are {0} ",Genders.Count + " objects with a male gender in the stack");














        }
    }
}
