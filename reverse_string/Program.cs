using System;

namespace reverse_string
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Reverse String"); 
            
            Console.WriteLine("Please enter text:");
            string userText = Console.ReadLine().ToLower();

            string reversedText = "";
            
            for (int i = userText.Length - 1; i >= 0; i--)
            {
                reversedText += userText[i];
            }
            Console.WriteLine("The reversed text is: " +reversedText);
            
            bool checkPalindrome = true;
            for (int i = 0; i < userText.Length / 2; i++)
            {
                if (userText[i] != userText[userText.Length - 1 - i])
                {
                    checkPalindrome = false;
                }
            }

            if (checkPalindrome)
            {
                Console.WriteLine("This string is a palindrome.");
            }
            else
            {
                Console.WriteLine("This string is not a palindrome.");
            }
        }
    }
}