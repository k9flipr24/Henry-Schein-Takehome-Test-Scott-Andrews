using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrapperTakehome
{
    public class WordWrapper
    {
        public static String wrap(String text, int maxLineLength)
        {
            int currentLineLength = 0;
            String currentLine = "";
            String wholeLine = "";
            if (text.Length < 1)
                throw new Exception("ERROR: Cannot accept empty string");
            else if (maxLineLength < 1)
                throw new Exception("ERROR: Cannot have column width less than 1");

            var words = text.Split(' ');

            foreach (var word in words)
            {
                if(currentLineLength + word.Length <= maxLineLength)
                {
                    currentLineLength += word.Length;
                    currentLine += word;
                    if(currentLineLength + 1 >= maxLineLength)
                    {
                        currentLine += '\n';
                        wholeLine += currentLine;
                        currentLine = "";
                        currentLineLength = 0;
                    }
                    else
                    {
                        currentLine += " ";
                        currentLineLength += 1;
                    }
                }
                else
                {
                    if(currentLineLength == 0)
                    {
                        wholeLine += word + '\n';
                    }
                    else
                    {
                        wholeLine += currentLine.Trim() + '\n';
                        currentLine = "";
                        currentLineLength = 0;
                    }
                }
            }
            wholeLine += currentLine;
            wholeLine = wholeLine.Trim();
            Console.WriteLine(wholeLine);
            return wholeLine;
        }
    }
}


