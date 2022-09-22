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
      string output = phrase.Replace(oldWord, newWord);
      return output;
    }
  }
}