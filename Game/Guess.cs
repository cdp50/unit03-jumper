using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    /// <summary>
    /// <para>
    /// The responsibility of Guess is to decide if the guess was right or not
    /// </para>
    /// </summary>   
    public class Guess
    {   
        public string letter_guessed = "";
        public string random_word = "";

        public Guess()
        {}

        /// <summary>
        /// <para>
        /// The responsibility of byLetter is to return true if the guess was right
        /// </para>
        /// </summary>   
        public bool byLetter()
            {
                bool exists = random_word.IndexOf(letter_guessed, StringComparison.CurrentCultureIgnoreCase) > -1;
                return exists;
            }
        
        




    
        
    }

}