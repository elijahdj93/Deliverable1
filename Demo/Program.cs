using System;

namespace Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//User types in 2 numbers
			Console.WriteLine("Enter your first number: ");
			String userNumber1 = Console.ReadLine();
            int Number1 = int.Parse(userNumber1);


			Console.WriteLine("Enter your second number: ");
			String userNumber2 = Console.ReadLine();
            int Number2 = int.Parse(userNumber2);
            
			//Accept 2 numbers from user with the same number of digits
            bool validateDigits(int Num1, int Num2){
                int Num1Len = Num1.ToString().Length;
                int Num2Len = Num2.ToString().Length;
                if (Num1Len == Num2Len){
                    return true;
                }else {
                    return false;
                }
            }

            bool NumDigits = validateDigits(Number1, Number2);

            if(NumDigits == true){
                Console.WriteLine("Your numbers are of the same digits long.");
            }else {
                Console.WriteLine("Your numbers are NOT the same digits long.");
            }

            bool ValidateNumbers(bool digitLen, int num1, int num2){
                string userNum1 = num1.ToString();
                string userNum2 = num2.ToString();

                int sum1 = userNum1[0] + userNum2[0];
                int sum2 = userNum1[1] + userNum2[1];
                int sum3 = userNum1[2] + userNum2[2];

                if(digitLen == true){
					if (sum1 == sum2 && sum2 == sum3)
					{
						Console.WriteLine("True!");
						return true;
					}
					else
					{
						Console.WriteLine("False!");
						return false;
					}
                }else {
                    Console.WriteLine("Error, your digits are not the same length. Please try again.");
                    return false;
                }
            }

            ValidateNumbers(NumDigits, Number1, Number2);

            Console.ReadLine();
		}
    }
}
