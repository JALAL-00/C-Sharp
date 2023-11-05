jusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        internal class Program
    {
        //******** Problem-01 ********//
        // public class Animal{
        //     string name;
        //     string catagory;
        //     int age;
        //     int id;
            
        //     public void setName(string name){
        //         this.name = name;
        //     }
        //     public string getName(){
        //         return this.name;
        //     }
            
        //     public void setCatagory(string catagory){
        //         this.catagory = catagory;
        //     }
        //     public string getCatagory(){
        //         return this.catagory;
        //     }
            
        //     public void setAge(int age){
        //         this.age = age;
        //     }
        //     public int getAge(){
        //         return this.age;
        //     }
            
        //     public void setId(int id){
        //         this.id = id;
        //     }
        //     public int getId(){
        //         return this.id;
        //     }
            
        //     public static void Main(String[] args){
        //         Animal A1 = new Animal();
        //         A1.setName("Tiger");
        //         A1.setCatagory("Mammal");
        //         A1.setAge(50);
        //         A1.setId(101);
        //         Console.WriteLine(A1.getName());
        //         Console.WriteLine(A1.getCatagory());
        //         Console.WriteLine(A1.getAge());
        //         Console.WriteLine(A1.getId());
        //     }
        // }


        public class student
        {
            int id;
            string name;
            int age;
            int Class;

            public void setStudent(int id, string name, int age, int Class)
            {
                this.id = id;
                this.name = name;
                this.age = age;
                this.Class = Class;
            }
            public void getStudent()
            {
                Console.WriteLine("Your id is: "+ id);
                Console.WriteLine("Your name is: " + name);
                Console.WriteLine("Your age is: " + age);
                Console.WriteLine("Your Class is: " + Class);
            }
        }
        static void Main(string[] args)
        {

            //student jalal = new student();
            //jalal.setStudent(22, "JALAL", 23, 10);
            //jalal.getStudent();

            // User input

            Console.WriteLine("Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Class: ");
            int Class = int.Parse(Console.ReadLine());

            student jalal = new student();
            jalal.setStudent(id, name, age, Class);
            jalal.getStudent();

        }
    }
}
