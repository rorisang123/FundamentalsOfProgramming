using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Services.Services
{
    public class FactorialService: IFactorialService
    {

        public int GenerateFactorial(int userNumber)
        {
            if (userNumber == 0)
            {
                return 1;
            }

            return userNumber * GenerateFactorial(userNumber - 1);
        }
    }
}
