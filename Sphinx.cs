using System;
using System.Collections.Generic; // Might not need this if we don't use a dictionary

class Sphinx
{
  static void Main()
  {
    // List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
    // string[] questions = new string["", "", "", ""];
    // string[] answers = new string["", "", "", ""];
    
    // Dictionary option
    // If userInput = answerKey[1])

    // random number generator = randomNumber(4)
    // Console.WriteLine(questions[randomNumber])
    // Console.ReadLine()
    // if (readline == answer[randomNumber]) {
        // Correct response
        // if user wants to continue: y or n
        // if (y) {
          // run the main function again
          // possible validation to make sure we don't do the same question again
          // end case when all the questions are gone
        // } else quit
    // } else get eaten


    Console.WriteLine("Hello, I am the Sphinx. To pass my test, you must correctly answer my riddles. If you fail, you are eaten.");
    Console.WriteLine("Question 1: What goes on four feet in the morning, two feet at noon, and three feet in the evening?");
    // string answer1 = "person";
    string response = Console.ReadLine().ToLower();
    if (response.Contains("person") || response.Contains("man")) {
      Console.WriteLine("Correct.");
      Console.WriteLine("Question 2: I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?.");
      bool response2 = Console.ReadLine().ToLower().Contains("fire");
      if (response2) {
        Console.WriteLine("Correct.");
      } else {
        Console.WriteLine("Wrong. You will now be eaten.");
      }
    } else {
      Console.WriteLine("Wrong. You will now be eaten.");
    }
  }
}