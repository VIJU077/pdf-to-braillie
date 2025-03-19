using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC_Application
{
    class ConvertTextToAscii
    {
        ArrayList a1 = new ArrayList();
        public int String_Length;
        public String DisplayAscii(String File)
        {
            String TextField = File;
            String_Length = TextField.Length;
            char[] charArr = TextField.ToCharArray();
            foreach (char ch in charArr)
            {
                char c = ch;
                BrailleAscii(c);
            }
            string s1="";
            StringBuilder sb = new StringBuilder();
            IEnumerator enumerator = a1.GetEnumerator();
            while (enumerator.MoveNext())
            {
                sb.Append(enumerator.Current);
            }
            s1 = sb.ToString();
            System.IO.File.WriteAllText(@"D:\TextToBrailleAscii.txt",s1);
            return s1;
        }
        private void BrailleAscii(char sentence)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            dic.Add('a', 100000);
            dic.Add('b', 101000);
            dic.Add('c', 110000);
            dic.Add('d', 110100);
            dic.Add('e', 100100);
            dic.Add('f', 111000);
            dic.Add('g', 111100);
            dic.Add('h', 101100);
            dic.Add('i', 011000);
            dic.Add('j', 011100);
            dic.Add('k', 100010);
            dic.Add('l', 101010);
            dic.Add('m', 110010);
            dic.Add('n', 110110);
            dic.Add('o', 100110);
            dic.Add('p', 111010);
            dic.Add('q', 111110);
            dic.Add('r', 101110);
            dic.Add('s', 011010);
            dic.Add('t', 011110);
            dic.Add('u', 100011);
            dic.Add('v', 101011);
            dic.Add('w', 011101);
            dic.Add('x', 110011);
            dic.Add('y', 110111);
            dic.Add('z', 100111);
            dic.Add(' ', 000000);

            dic.Add('A', 100000);
            dic.Add('B', 101000);
            dic.Add('C', 110000);
            dic.Add('D', 110100);
            dic.Add('E', 100100);
            dic.Add('F', 111000);
            dic.Add('G', 111100);
            dic.Add('H', 101100);
            dic.Add('I', 011000);
            dic.Add('J', 011100);
            dic.Add('K', 100010);
            dic.Add('L', 101010);
            dic.Add('M', 110010);
            dic.Add('N', 110110);
            dic.Add('O', 100110);
            dic.Add('P', 111010);
            dic.Add('Q', 111110);
            dic.Add('R', 101110);
            dic.Add('S', 011010);
            dic.Add('T', 011110);
            dic.Add('U', 100011);
            dic.Add('V', 101011);
            dic.Add('W', 011101);
            dic.Add('X', 110011);
            dic.Add('Y', 110111);
            dic.Add('Z', 100111);

            dic.Add('1', 001000);
            dic.Add('2', 001010);
            dic.Add('3', 001100);
            dic.Add('4', 001101);
            dic.Add('5', 001001);
            dic.Add('6', 001110);
            dic.Add('7', 001111);
            dic.Add('8', 001011);
            dic.Add('9', 000110);
            dic.Add('0', 000111);

            dic.Add(',', 000001);
            dic.Add('.', 010001);
            dic.Add('!', 011011);
            dic.Add('@', 010000);
            dic.Add('#', 010111);
            dic.Add('$', 111001);
            dic.Add('%', 110001);
            dic.Add('^', 010100);
            dic.Add('&', 111011);
            dic.Add('*', 100001);

            dic.Add('(', 101111);
            dic.Add(')', 011111);
            dic.Add('[', 011001);
            dic.Add(']', 111101);
            dic.Add('_', 010101);

            dic.Add('-', 000011);
            dic.Add('+', 010011);
            dic.Add('/', 101101);
            dic.Add('=', 000101);

            dic.Add(':', 100101);
            dic.Add(';', 000101);
            dic.Add('"', 000100);
            dic.Add('<', 101001);
            dic.Add('>', 010110);

            if (dic.ContainsKey(sentence))
            {
                 a1.Add(dic[sentence]);
            }
            else
            {

            }
        }
    }
}
