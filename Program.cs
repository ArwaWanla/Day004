using System;
using System.Collections.Generic;

namespace tr
{
    class Program
    {
        static List<string> tokenizer(string source)
        {
            List<string> list = new List<string>();
            string token = "";
            int i = 0;
            int cnt = 0;
            char current = ' '; 
            

            while (i < source.Length && i + 1 < source.Length)
            {
                token = "";

                if (source[i] == '#' && i+1 < source.Length && char.IsLetterOrDigit(source[i+1]))//check the char after # int|char
                {
                    //check if it enters the loop
                    
                    current = source[i];
                    token += source[i];
                    i++;
                    current = source[i];
                    

                    if (!char.IsPunctuation(current) && !char.IsWhiteSpace(current))
                    {
                        
                        token += source[i];
                        current = source[i];
                        i++;

                        while (i < source.Length && char.IsLetterOrDigit(current) || current =='_')
                        {
                            current = source[i];

                            if (char.IsWhiteSpace(current) || current =='#')
                            {
                                continue;
                            }
                            token += current;
                            i++;

                        }

                    }

                    Console.WriteLine(token);

                }
                i++;   

            }
            return list;
        }


        static void Main(string[] args)
        {
            var value = " @chamath #opti.onstrade  #blockchain #DeFi #Crypto #Finance @Ripple @Chedda CEO Jon Steinberg interviews Doug Kehring about the growth opportunities taking shape at @Oracl and how #finance is driving them. @OracleERPCloud";
            tokenizer(value);
        }
    }
}




