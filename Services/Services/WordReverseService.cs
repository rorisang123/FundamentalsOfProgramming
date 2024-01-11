using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class WordReverseService : IWordReverseService
    {
        public string GenerateReverseWord(string inputSentence)
        {
            string[] inputSentenceArray = inputSentence.Split(' ');
            string reversedSentence = "";

            for (int i = inputSentenceArray.Length - 1; i >= 0; i--)
            {
                reversedSentence += inputSentenceArray[i] + " ";
            }

            return reversedSentence;
        }
    }
}
