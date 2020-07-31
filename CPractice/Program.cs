using System;

namespace CSharpPractice
{
    class Program
    {

        string firstName;
        string lastName;
        int age;

        static void Main(string[] args)
        {
            // data types
            //string phrase = "This is a phrase";
            //char grade = 'a';
            //short num = 1;
            //byte num2 = 10;
            //int num3 = 10;
            //float num4 = 1.2f;
            //double num5 = 3.14159;
            //long num6 = 1L;
            //bool conditional = true;
            //bool coditional2 = false;

            Program newProgram = new Program("Valeria", "Meza", 24);
            Console.WriteLine(newProgram.GetFirstName());
            Console.WriteLine(newProgram.GetLastName());

            Console.ReadLine();
        }

        public Program(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
    }
}
