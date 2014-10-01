using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        // Definierar och initierar variabler.
        public const int MaxNumberOfGuesses = 7;
        private int _count;
        private int _number;


        public void Initialize()
        {
            _count = 0;

            // Slumpar fram ett heltal mellan '1' och '100'. 
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            _number = randomNumber; 
        }

        public bool MakeGuess(int number)
        {
            // Matar användaren in ett värde utanför intervallet ges denne ny chans.
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Skriver ut passande meddelanden till användaren beroende på vad denne gissat.
            if (_count < MaxNumberOfGuesses)
            {   
                _count++; // Ser till att värdet ökas i takt med användarens antal gissningar.

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

                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Det hemliga talet är {0}.", _number);
                }
            }

            // Ser till att nytt värde slumpas fram efter de maximalt sju gissningar som givits användaren. 
            else
            {
                throw new ApplicationException();
            }

            return false;
        }

        public SecretNumber()
        {
            Initialize();
        }

    }
}
