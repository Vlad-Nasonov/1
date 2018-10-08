using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2__2_semestor_
{
    public class Sequence
    {

        public string FileName { get; set; }
        public byte[] Numbers { get; set; }
        public Sequence(string inputFile)
        {
            FileName = inputFile;
            Numbers = File.ReadAllBytes(inputFile);

        }

        public int CountSequences()
        {
            int counter = 0;
            int repeater = 1;
            int lastDigit = 0;
            List<char> digits = Encoding.Default.GetString(Numbers).ToList();
            int length = digits.Count;
            int pointer = 0;
            lastDigit = digits[0];
            for (int i = 2; i < length; i = i+2)
            {
                if (lastDigit == digits[i])
                {
                    repeater++;
                }
                else
                {
                    if (repeater > 1)
                    {
                        counter++;
                        repeater = 1;
                    }
                    lastDigit = digits[i];
                }
                pointer = i;
            }
            if (pointer == length - 1)
            {
                if (repeater > 1)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}







/*public int Result { get; set;} */
//List<int> digits { get; set; }




/*public Sequence()
{
    digits = new List<int>();
}*/

/*public string FileContent()
{
    string result = "";

    foreach (int digit in digits)
    {
        result += digit.ToString() + " ";
    }

    return result;
}*/

/* public void Decoder()
 {
     using (var file = new StreamReader(FileName))
     {
         char[] separator = { ' ', ',', ';', '.'};
         string[] temp = Encoding.Default.GetString(Numbers).Split(separator, StringSplitOptions.RemoveEmptyEntries);
         foreach (string digit in temp)
         {
             digits.Add(Convert.ToInt32(digit));
         }
     }
 }*/

