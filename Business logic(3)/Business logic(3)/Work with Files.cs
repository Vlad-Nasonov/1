using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Business_logic_3_
{
    public class Work_with_Files
    {
        public string InputFile { get; set; }
        public string[] Lines { get; set; }
        public Work_with_Files(string inputFile)
        {
           InputFile = inputFile;
           Lines = File.ReadAllLines(inputFile, Encoding.Default);
           
        }
        public  void WriteToFileAllLines(string name_file, string[] lines)
        {
            File.WriteAllLines(name_file, lines);
        }

        public List<string> ChangeLines(int k, bool position)
        {
            List<string> resuitsLines = new List<string>(Lines);

            if (Lines.Length > k)
            {

                if (position)
                {
                    for (int i = 0; i < k; i++)
                    {
                        resuitsLines.Remove(resuitsLines[0]);
                    }
               

                }
                else
                {
                    
                   for (int i = 0; i < k; i++)
                    {
                        resuitsLines.RemoveAt(resuitsLines.Count - 1);
                    }

                }
            }
            return resuitsLines; 
        }
        
         
    }
}
