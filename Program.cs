namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to be tested for being a palindrome");

            string userNums = Console.ReadLine(); 

            bool isPalindrome = IsPalindrome(userNums);

            Console.WriteLine(isPalindrome ? "true" : "false");

        }

        static bool IsPalindrome(string number)
        {
            int length = number.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (number[i] != number[length - 1 - i])
                {
                    return false;

                }
            }
            return true;
        }
         
    }
}
