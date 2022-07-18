using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Guess
    {   
        public string letter_guessed = "";
        public string random_word = "";

        public Guess()
        {}

        
        public bool byLetter()
            {
                bool exists = random_word.IndexOf(letter_guessed, StringComparison.CurrentCultureIgnoreCase) > -1;
                return exists;
            }
        
        




    
        
    }

}