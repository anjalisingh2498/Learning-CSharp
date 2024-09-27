// See https://aka.ms/new-console-template for more information
namespace Calculator
{
    class Program{

        static void Main(String[] args){
            int num1;
            int num2;
            int result=0;
            String answer;
            Console.WriteLine("Hello , Welcome to the calculator Program");
            Console.WriteLine("Please Enter the First Number: - ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Second Number: - ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division");

            answer = Console.ReadLine();
           
            if(answer == "a"){
                result = num1 + num2 ;
            }else if( answer == "s"){
                result = num1 - num2 ;
            }else if ( answer == "m"){
                result = num1 * num2 ;
            }else if ( answer == "d"){
                result = num1 / num2 ;
            }else{
                Console.WriteLine("Invalid");
            }
           Console.WriteLine("The result is " + result);
           Console.WriteLine("Thank you for using the calculator program");
        } 
    }
}
