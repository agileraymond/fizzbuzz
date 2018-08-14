using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface IFizzBuzz
    {
        List<string> Run(int minNumber, int maxNumber);
        List<string> Run(string minNumber, string maxNumber);
        string CheckNumber(int number);                
    }
}
