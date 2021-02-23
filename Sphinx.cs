using System;
using System.Collections.Generic; // Might not need this if we don't use a dictionary
using System.Linq;

public class Riddle
{
  public string Question;
  public string Answer;

  public Riddle(string question, string answer)
  {
    Question = question;
    Answer = answer;
  }

  public bool AnswerIsCorrect(string answer, string userInput) {
    if (userInput == answer) {
      return true;
    } else {
      return false;
    }
  }
}

public class Program
{
  public static void Main()
  {
    Dictionary<string, string> prompts = new Dictionary<string, string>() { {"What goes on four feet in the morning, two feet at noon, and three feet in the evening?", "person"}, {"I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "fire"}, {"What kind of ear cannot hear?", "an ear of corn"}, {"You must keep it after giving it.", "your word"} };

    bool correct = true;
    while(correct) {
      Random rand = new Random();
      prompts = prompts.OrderBy(x => rand.Next())
        .ToDictionary(item => item.Key, item => item.Value);

      Console.WriteLine("I am Sphinx hear me roar");
      int index = rand.Next(prompts.Count);

      KeyValuePair<string, string> pair = prompts.ElementAt(index);

      Console.WriteLine(pair.Key);
      string response = Console.ReadLine().ToLower();
      if (response != pair.Value) {
        correct = false;
      }
    }
  }
}