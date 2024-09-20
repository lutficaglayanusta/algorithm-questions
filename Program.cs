using System;

class Program
{
  static void Main(string[] args)
  {
    
    Console.Write("Please enter the valid number:");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<number;i++){
      Console.Write("Please enter the number:");
      int number1=Convert.ToInt32(Console.ReadLine());
      if(number1%2==0){
        Console.WriteLine($" This number is even {number1}");
      }
    }
    Console.WriteLine("-----------------------------");
    Console.Write("Please enter the valid number:");
    int loopNumnber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the  number:");
    int validNumber = Convert.ToInt32(Console.ReadLine());

    for(int i=0;i<loopNumnber;i++){
      Console.Write("Please enter the chooce number:");
      int userInput=Convert.ToInt32(Console.ReadLine());
      if(userInput == validNumber || userInput % validNumber==0){
        Console.WriteLine(userInput);
      }
    }

    Console.WriteLine("-----------------------------");
    
    Console.Write("Please enter the positive number");
    int wordNumber = Convert.ToInt32(Console.ReadLine());

    string[] words = new string[wordNumber];

    for(int i=0;i<wordNumber;i++){
      Console.Write("Please enter the word");
      string word = Console.ReadLine();
      words[i]=word;
    }
    Array.Reverse(words);
    for(int i=0;i<words.Length;i++){
      Console.WriteLine(words[i]);
    }

    Console.WriteLine("-----------------------------");
    Console.Write("Please write the sentence: ");
    string sentence = Console.ReadLine();
    

    string newSentence = sentence.Replace(" ", "");
    
    Console.WriteLine($" Total letter number: {newSentence.Length}");

    string[] arraySentence = sentence.Split(" ");
    Console.WriteLine($" Total word number: {arraySentence.Length}");
  }
}