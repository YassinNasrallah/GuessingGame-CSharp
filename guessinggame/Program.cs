using System.ComponentModel.Design;

class Program {
    static void Main(String[] args)
    {
        string secretWord = "lion";

        string [] help = 
          {
            "It is a member of the cat family",
            "It lives mostly in Africa, try again !",
            "It has a powerful roar, try again !",
            "Male ones usually have a large mane, try again !",
            "It is known as the king of the jungle, try again !",
            "its a lion stupid "
          };
            
           
            Console.WriteLine(help[0]);
            WinCondition(secretWord, help );
    }

    static string Playeranswer()
    {
        Console.Write("enter your answer : ");
        string useranswer = Console.ReadLine();

        return useranswer;
    }

    static void WinCondition(string secretWord, string[] help)
    {
        
        for(int i = 1; i<help.Length; i++)
        {
            
            string answer = Playeranswer();
            if(answer == secretWord)
            {
                Console.WriteLine("correct");
                return;

            }
            else
            {
                Console.WriteLine(help[i]);
                
            }
        }
        Console.WriteLine("you lost");
    }
}
