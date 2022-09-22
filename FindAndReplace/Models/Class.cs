//business file

//user is inputting 3 strings, a long one, a word to replace, and its replacement
// we split the first one into an array using .Split(' ');
// we for loop each item in the array to change it using the 2md and 3rd variables

// for the second part we might have to do some form of .Includes(), if it exists
using System;
using System.Collections.Generic;


namespace Class.Models
{
  public class Replacer
  {
    public string changer(string phrase, string oldWord, string newWord)
    {
      string[] outputarray = phrase.Split(' ');
      string outputstring = "";
      for (int i = 0; i < outputarray.Length; i++)
      {
        if (outputarray[i] == oldWord)
        {
          outputarray[i] = newWord;
        }
        outputstring += outputarray[i];
        if (i + 1 != outputarray.Length)
        {
          outputstring += " ";
        }
      }
      return outputstring;
    }
    public string funnyChanger(string phrase, string oldWord, string newWord)
    {
      string[] outputarray = phrase.Split(' ');
      string outputstring = "";
      for (int i = 0; i < outputarray.Length; i++)
      {
        if (outputarray[i].Contains(oldWord))
        {
          outputarray[i] = outputarray[i].Replace(oldWord, newWord);
        }
        outputstring += outputarray[i];
        if (i + 1 != outputarray.Length)
        {
          outputstring += " ";
        }
      }
      return outputstring;
    }
  }
}