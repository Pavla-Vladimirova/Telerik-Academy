using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodeAndDecodeStringUsingGivenEncryptionKey
{
    class EncodeAndDecodeStringUsingGivenEncryptionKey
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the key");
            string inputKey = Console.ReadLine();
            Console.WriteLine("Write the sequence to encode");
            string inputSequence = Console.ReadLine();
            List<short> outputEncoded = Encode(inputKey, inputSequence);
            //the new encoded sequence
            for (int i = 0; i < outputEncoded.Count; i++)
            {
                Console.Write("\\u{0:x4}", outputEncoded[i]);
            }
            Console.WriteLine();
        }

        static List<short> Encode(string key, string sequence)
        {
            //Decode is the same
            List<short> encoded = new List<short>();
            for (int i = 0, j = 0; i < sequence.Length; i++)
            {
                int result = sequence[i] ^ key[j];
                encoded.Add(Convert.ToInt16(result));
                if (j == key.Length - 1)
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
            }
            return encoded;
        }
    }
}
