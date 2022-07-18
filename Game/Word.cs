using System;

using System.Collections.Generic;

namespace unit03_jumper
{
    public class Word
    {
        
        
        /// <summary>
        /// <para>The random word.</para>
        /// <para>
        /// The responsibility of word is to select and output a random word
        /// </para>
        /// </summary>        
        public Word()
        {
        }
        
        /// <summary>
        /// <para>
        /// The responsibility of get_random_word is to create a list of words, 
        /// select and output a random word
        /// </para>
        /// </summary>   
        public string get_random_word()
        {
            var random = new Random();
            
            List<string> words = new List<string>();
            words.Add("phone");
            words.Add("keyboard");
            words.Add("mouse");
            words.Add("sing");
            words.Add("water");
            words.Add("rock");
            words.Add("gospel");
            words.Add("love");
            words.Add("clap");

            int index = random.Next(words.Count);
            string random_word = words[index];
            return random_word;
        }



    }
}