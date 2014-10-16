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

        // Definierar fält.
        private int _count;
        private int _number;

        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
            _count = 0;

            // Slumpar fram ett heltal mellan '1' och '100'. 
            Random random = new Random();
            _number = random.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }
                
            // Matar användaren in ett värde utanför intervallet ges denne ny chans.
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Skriver ut passande meddelanden till användaren beroende på vad denne gissat.
            _count++; // Ser till att värdet ökas i takt med användarens antal gissningar.

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök.", _count);

                return true;
            }

            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, (7 - _count));
            }
            else
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, (7 - _count));
            }


            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är {0}.", _number);
            }

            return false;
        }
    }
}
