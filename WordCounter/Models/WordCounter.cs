using System;
using System.Collections.Generic;



namespace WordCounter
{
  public class RepeatCounter
  {
    private string _str;
    private string _word;

    public RepeatCounter(string str, string word)
    {
      _str = str;
      _word = word.ToString();
    }

    public string GetStr()
    {
      return _str;
    }
    public string GetWord()
    {
      return _word;
    }

    public int CountRepeats()
    {
      var score = 0;
      string[] newString = _str.Split();
      foreach(string str in newString)
      {
          if(_word == str.ToString())
          {
            score += 1;
          }
      }
      return score;
    }
  }
}
