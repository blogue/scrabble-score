using System;

namespace ScrabbleScore
{
  public class ScoreCalculator
  {
    private char[] tileScores= {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T',
                                'D', 'G',
                                'B', 'C', 'M', 'P',
                                'F', 'H', 'V', 'W', 'Y',
                                'K',
                                'J', 'X',
                                'Q', 'Z'};
    public int calculateScore(string word)
    {
      int Score = 0;
      char[] wordArray = word.ToCharArray();
      for(int i=0; i< wordArray.Length; i++) {
        int index = Array.IndexOf(tileScores, wordArray[i]);
        if(index <= 9)
        {
          Score+=1;
        }
        else if (index <= 11){
          Score+= 2;
        }
        else if (index <= 15) {
          Score+=3;
        }
        else if(index <= 20) {
          Score+=4;
        }
        else if(index <= 21) {
          Score+=5;
        }
        else if(index <= 23){
          Score+=8;
        }
        else if (index <=25){
          Score+=10;
        }
      }
      return Score;
    }
  }
}
