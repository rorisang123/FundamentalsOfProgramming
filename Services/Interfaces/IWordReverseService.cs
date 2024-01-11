using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IWordReverseService
    {
        public string GenerateReverseWord(string inputSentence);
    }
}
