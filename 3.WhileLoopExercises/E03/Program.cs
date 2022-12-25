using System;

namespace StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int cCounter = 0;
            int oCiunter = 0;
            int nCounter = 0;
            string theWord = "";
            while (input != "End")
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    continue;
                }
                char toTest = char.Parse(input); 
                //the upper latter 
                if (toTest > 64 && toTest < 91)
                {
                    theWord+=input;
                }
                //counters 
                if (toTest == 99)
                {                   
                    if (cCounter >= 1)
                    {
                        if (oCiunter>=1 && nCounter >= 1)
                        {
                            theWord+=" ";
                            cCounter = 0;
                            oCiunter = 0;
                            nCounter = 0;
                        }
                        else if (cCounter >= 1)
                        {
                            theWord += input;
                        }                       
                    }
                    cCounter++;
                }
                else if (toTest == 111)
                {                   
                    if (oCiunter >= 1)
                    {
                        if (cCounter >= 1 && nCounter >= 1)
                        {
                            theWord += " ";
                            cCounter = 0;
                            oCiunter = 0;
                            nCounter = 0;
                        }
                        else if (oCiunter >= 1)
                        {
                            theWord += input;
                        }
                    }
                    oCiunter++;
                }
                else if (toTest == 110)
                {                    
                    if (nCounter >= 1)
                    {
                        if (cCounter >= 1 && oCiunter >= 1)
                        {
                            theWord += " ";
                            cCounter = 0;
                            oCiunter = 0;
                            nCounter = 0;
                        }
                        else if (nCounter >= 1)
                        {
                            theWord += input;
                        }
                    }
                    nCounter++;
                }
                //thelower latters 
                else if (toTest > 96 && toTest < 123)
                {
                        theWord +=input;
                }
                if (cCounter >= 1 && nCounter >= 1 && oCiunter >=1)
                {
                    
                    Console.Write(theWord+" ");
                    cCounter = 0;
                    oCiunter = 0;
                    nCounter = 0;
                    theWord = "";
                }
                //other cases 
                else
                {
                    continue;
                }
            }
        }
    }
}
