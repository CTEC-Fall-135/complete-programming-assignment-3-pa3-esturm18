
/*Name : Emma Sturm
  Date : 10/13/2024
  Assignment PA3
  Purpose : Write a program that practices using fields, constructors, and methods*/

namespace ClassDemo
{
    //Class Student
    class Student
    {
        //Field for name
        private string name;

        //Property for address
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        //Automatic property for the address
        public int ID { get; set; }

        //Default Constructor
        public Student(): this("Unknown name", "Unknown address", 0)
        {
            //Empty
        }

        //Constructor that just takes the student name
       public Student(string name): this(name, "Unknown address", 0)
        {
        }

        //Primary Constructor that takes all the information
        public Student(string name, string address, int id)
        {
            this.name = name;
            this.address = address;
            this.ID = id;
        }

        //Getter for the name field
        public string GetName()
        {
            return name; 
        }

        //Setter for the name field
       public void SetName(string value)
        {
            name = value; 
        } 

        //Method to print the state of the object
        public void PrintState()
        {
            Console.WriteLine($"Name: {name}, Address: {Address}, ID {ID}");
        }


    } //End of class Student

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project worked?");

            //Instance with primary constructor
            Student student1 = new Student("SpongeBob Squarepants", "Pineapple in Bikini Bottom", 500);
            student1.PrintState();

            //Instance with only the name parameter
            Student student2 = new Student("Patrick Star");
            student2.PrintState();
            
            //Instance created with Default Constructor
            Student student3 = new Student();
            student3.PrintState();
        }
    }
}
