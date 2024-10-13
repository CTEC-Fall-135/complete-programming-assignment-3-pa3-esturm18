
using System.IO;
using System; 


/* Name: Emma Sturm
   Date: 10/13/2024
   Assignment: PA3
   Purpose: This project is testing out different exception states, i.e. the case of diving something by zero.*/

namespace DemoException
{ 
    internal class Program
    {
        //Main function
        static void Main(string[] args)
        {
            int output = something(5); //Call function that will divide some number by 0. I chose 5 for this case
            Console.WriteLine(output);//Print out output if all good  
        }

        public static int something(int data){
            int x = 0; //declared x variable to set outside of the try/catch so it has a larger scope
            try
            {
                x = data / 0; //Divide data by zero
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); //Throw error message since diving by zero is a no-no
            }

            return x; //return x
        }
    }
}
