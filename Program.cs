// See https://aka.ms/new-console-template for more information
namespace SwitchcaseExample{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Enter your GRADE:");
            string grade= Console.ReadLine();
            switch(grade){
                case "A":
                    Console.WriteLine("Excellent");
                    break;
                case "B":
                    Console.WriteLine("Good");
                    break;
                case "C": 
                    Console.WriteLine("You can Improve");
                    break;
                case "D":
                    Console.WriteLine("Fail");
                    break;
            }
            Console.WriteLine("Your grade is  {0}", grade);
        }
    }
}
