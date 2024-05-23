namespace ChallengeLabsWeek3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = GetWordFromUser();
            bool isPal = isPalindrome(word);
            PrintResult(isPal, word);
        }

        static string GetWordFromUser()
        {
            string userInput = "";

            do
            {
                Console.WriteLine("Please enter a word.");
                userInput = Console.ReadLine();
            } while (userInput == "");
            return userInput;
        }

        static bool isPalindrome(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                } 
            }
           return true;

        }

        static void PrintResult(bool isPalindrome, string word) 
        {
            if (isPalindrome) 
            {
                Console.WriteLine($"{word} is a palindrome.");
            }
            else if(!isPalindrome) 
            {
                Console.WriteLine($"{word} is not a palindrome");
            }
        }

    }
}
