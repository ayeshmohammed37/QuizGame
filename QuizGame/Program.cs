namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[20]
            {
                "What is the capital of France?",
                "What is 5 + 7?",
                "Who wrote 'Romeo and Juliet'?",
                "What is the largest planet in our solar system?",
                "Which element has the chemical symbol 'O'?",
                "What is the fastest land animal?",
                "Who painted the Mona Lisa?",
                "What is the smallest prime number?",
                "What is the boiling point of water in Celsius?",
                "Which country is known as the Land of the Rising Sun?",
                "What is the square root of 64?",
                "What is the main language spoken in Brazil?",
                "Which ocean is the deepest?",
                "Who discovered gravity?",
                "What color do you get when you mix red and white?",
                "What year did World War II end?",
                "What is the tallest mountain in the world?",
                "What is the chemical formula of water?",
                "Which planet is known as the Red Planet?",
                "Who is known as the father of computers?"
            };

            string[] answers = new string[20]
            {
                "Paris",
                "12",
                "William Shakespeare",
                "Jupiter",
                "Oxygen",
                "Cheetah",
                "Leonardo da Vinci",
                "2",
                "100",
                "Japan",
                "8",
                "Portuguese",
                "Pacific Ocean",
                "Isaac Newton",
                "Pink",
                "1945",
                "Mount Everest",
                "H2O",
                "Mars",
                "Charles Babbage"
            };

            Console.WriteLine("Welcome to the game");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please Answer the following questions: ");

            int score = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{i+1}. {questions[i]}");

                string userAns = Console.ReadLine();

                try
                {
                    if (CheckAns(answers[i], userAns))
                    {
                        Console.WriteLine("True");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine($"False. the right answer is: {answers[i]}");
                    }
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    //Console.WriteLine("Enter the Answer: ");
                    //userAns = Console.ReadLine();

                    //if (CheckAns(answers[i], userAns))
                    //{
                    //    Console.WriteLine("True");
                    //}
                    //else
                    //{
                    //    Console.WriteLine($"False. the right answer is: {answers[i]}");
                    //}
                    //Console.WriteLine();
                }

                
            }

            Console.WriteLine($"you answred({score}/20)");
            Console.WriteLine("Game is ended. back again (^_^)");

        }

        private static bool CheckAns(string ans, string userAns)
        {
            if (string.IsNullOrEmpty(userAns))
            {
                throw new Exception("Answer can't be Empty");
            }

            if (ans == userAns)
            {
                return true;
            }
            return false;
        }
    }
}
