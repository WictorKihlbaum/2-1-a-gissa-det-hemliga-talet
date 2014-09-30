using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;
        private int _count;
        private int _number;


        public void Initialize()
        {
            _count = 0;

            Random random = new Random();
            int randomNumber = random.Next(1, 100);

            randomNumber = _number; 

        }

        public bool MakeGuess(int number)
        {
            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (7 - _count));
            }

            if (number > _number)
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (7 - _count));
            }

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count);

                return true;
            }

            return false;
        }

        public SecretNumber()

        { 
        
        }

    }
}
