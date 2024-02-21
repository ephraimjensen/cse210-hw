using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    List<Word> words = new List<Word>();
    Random randInt = new Random();


    public void HideWords(int howManyTimes = 5)
    {
        for (int x = 1; x <= howManyTimes; x += 1)
        {
            int hideAtThisIndex = randInt.Next(words.Count);
            words[hideAtThisIndex].Hide();

        }
    }
    public Scripture(string scripture)
    {
        words = new List<Word>();

        string[] scriptureList = scripture.Split(" ");
        foreach (string word in scriptureList)
        {
            Word tempWord = new Word(word);
            words.Add(tempWord);
        }


    }

    public void Display()
    {
        foreach (Word word in words)
        {
            Console.Write($"{word.Display()} ");
        }
    }

    public bool CheckIfDone()
    {
        int counter = 0;
        int hiddenCounter = 0;

        foreach (Word word in words)
        {
            counter += 1;
            if (word.CheckIfVisible() == false)
            {
                hiddenCounter += 1;
            }
        }
        if (hiddenCounter == counter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}