using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace StringImages
{
    class image
    {
        static void Main(string[] args)
        {
       

          
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("images.txt"))
                {
                    String line;

                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        char[] delimiterChars = { '/' };



                        string[] words = line.Split(delimiterChars);

                      



                        String[] sa = {"0","1","2","3","4","5","6" };


                        int length = words.Length;
                       
                        int loop = 0;
                        foreach (string s in words)
                        {

                            sa[loop] = s;


                            loop++;
                        }

                        if(length == 7)
                        System.Console.WriteLine("new Quilt { QuiltId = "  + i + ", Type = \"" + sa[3] + "\", SubType = \"" + sa[4] + "\", ShortDescription = \"" + sa[5] + "\", ImageUrl =\"" + line +"\"},");
                        else
                            System.Console.WriteLine("new Quilt { QuiltId = " + i + ", Type = \"" + sa[3] + "\", SubType = \"" + sa[4] + "\", ShortDescription = \"none\", ImageUrl =\"" + line + "\"},");
                        i++;
                    }
                     
                   

                

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
          

            

            
           

           

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
