using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    /// <summary>
    /// <para>the board.</para>
    /// <para>
    /// the responsibility of the board is to create the board and update it.
    /// </para>
    /// </summary>
    public class Puzzle
    {
        private TerminalService terminalService = new TerminalService();
        private Word word = new Word();
        public string letter_guessed = "";
        public string random_word = "";
        public string wordPlace ="";
        public bool guessed;
        private int wrongCount;
        private int winCounter;
        public bool gameOver = false;
        // it is right by default
        string desition1 = " ___";
        string desition2 = @"/___\ ";
        string desition3 = @"\   /";
        string desition4 = @" \ /";
        string desition5 = "  0";

        List<string> leterList = new List<string>(); 
        List<string> mysterious_word_List = new List<string>(); 
        
        

        /// <summary>
        /// Constructs a new instance of Puzzle. 
        /// </summary>
        public Puzzle()
        {
        }

        private string place()
        {
            List<char> chars = new List<char>();
            chars.AddRange(random_word);
            int wordLength = random_word.Length;

            foreach (char item in chars)
            {
                wordPlace += ("_  ");
            }
            return wordPlace;
        }

        public void drawBoard()
        {
            terminalService.WriteText(" ");
            Console.WriteLine(place());
            terminalService.WriteText(" ");
            terminalService.WriteText(" ___");
            terminalService.WriteText(@"/___\ ");
            terminalService.WriteText(@"\   /");
            terminalService.WriteText(@" \ /");
            terminalService.WriteText("  0");
            terminalService.WriteText(@" /|\ ");
            terminalService.WriteText(@" / \ ");
            terminalService.WriteText(" ");
            terminalService.WriteText("^^^^^^^");
            terminalService.WriteText(" ");
        }
        public void GetInputs()
        {
            letter_guessed = terminalService.ReadText("Guess a letter [a-z]: ");
        }
        
        public void mysterious_word_board()
        {
            List<char> chars = new List<char>();
            chars.AddRange(random_word);
            
            
            //so mysterious_word_List can have as many elements as the radom word has characters.
            foreach (char item in chars)
            {
                leterList.Add(item.ToString());
                mysterious_word_List.Add("_ ");
            }
        }
        private void mysterious_word_update()
        {
            // create a list that shows the guessed letters
            foreach (string item in leterList)
            {
                if (item == letter_guessed)
                {   
                    winCounter += 1;
                    int index = leterList.FindIndex(a => a.Contains(item));
                    mysterious_word_List[index] = $"{item} ";
                    if (winCounter == leterList.Count)
                    {
                        gameOver = true;
                    }
                }
            } 
            // print the the list that shows the guessed letters. 
            foreach (string item in mysterious_word_List)
            {
                Console.Write(item);
            } 
        }   
        public void updateBoard()
        {   
            if (guessed != true)
            {
                wrongCount += 1;
                if (wrongCount == 1)
                {
                    desition1 = "";
                }else if (wrongCount == 2)
                {
                    desition1 = "";
                    desition2 = "";
                }else if (wrongCount == 3)
                {
                    desition1 = "";
                    desition2 = "";
                    desition3 = "";
                }else if (wrongCount == 4)
                {
                    desition1 = "";
                    desition2 = "";
                    desition3 = "";
                    desition4 = "";
                }else if (wrongCount == 5)
                {
                    desition1 = "";
                    desition2 = "";
                    desition3 = "";
                    desition4 = "";
                    desition5 = "  x";
                    gameOver = true;
                }
            }
            
            terminalService.WriteText(" ");
            terminalService.WriteText(" ");
            mysterious_word_update();
            terminalService.WriteText(" ");
            terminalService.WriteText(desition1);
            terminalService.WriteText(desition2);
            terminalService.WriteText(desition3);
            terminalService.WriteText(desition4);
            terminalService.WriteText(desition5);
            terminalService.WriteText(@" /|\ ");
            terminalService.WriteText(@" / \ ");
            terminalService.WriteText(" ");
            terminalService.WriteText("^^^^^^^");
            terminalService.WriteText(" ");
        }


    }
}