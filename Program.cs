using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());

            if(age  > 17){
                Console.WriteLine("Legally adult age");
            }else{
                Console.WriteLine("Legally not adult age");
            }
        }   
    }
}
