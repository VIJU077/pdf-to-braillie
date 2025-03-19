using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDC_Application
{
    class ConvertTextToBraille
    {
        public string[] res = new string[500000];
        public int i = 0;
        public String Display(String File)
        {
            String TextField = File;
            char[] charArr = TextField.ToCharArray();
            foreach (char ch in charArr)
            {
                char c = ch;
                BraileDict(c);
            }
            string s1 = string.Join("", res);
            System.IO.File.WriteAllText(@"D:\TextToBraille.txt", s1);
            return s1;
        }
        private void BraileDict(char sentence)
        {
           
            Dictionary<char, string> d = new Dictionary<char, string>();

            d.Add('a', "⠁");
            d.Add('b', "⠃");
            d.Add('c', "⠉");
            d.Add('d', "⠙");
            d.Add('e', "⠑");
            d.Add('f', "⠋");
            d.Add('g', "⠛");
            d.Add('h', "⠓");
            d.Add('i', "⠊");
            d.Add('j', "⠚");
            d.Add('k', "⠅");
            d.Add('l', "⠇");
            d.Add('m', "⠍");
            d.Add('n', "⠝");
            d.Add('o', "⠕");
            d.Add('p', "⠏");
            d.Add('q', "⠟");
            d.Add('r', "⠗");
            d.Add('s', "⠎");
            d.Add('t', "⠞");
            d.Add('u', "⠥");
            d.Add('v', "⠧");
            d.Add('w', "⠺");
            d.Add('x', "⠭");
            d.Add('y', "⠽");
            d.Add('z', "⠵");
            d.Add(' ', "  ");


            d.Add('A', "⠠⠁");
            d.Add('B', "⠠⠃");
            d.Add('C', "⠠⠉");
            d.Add('D', "⠠⠙");
            d.Add('E', "⠠⠑");
            d.Add('F', "⠠⠋");
            d.Add('G', "⠠⠛");
            d.Add('H', "⠠⠓");
            d.Add('I', "⠠⠊");
            d.Add('J', "⠠⠚");
            d.Add('K', "⠠⠅");
            d.Add('L', "⠠⠇");
            d.Add('M', "⠠⠍");
            d.Add('N', "⠠⠝");
            d.Add('O', "⠠⠕");
            d.Add('P', "⠠⠏");
            d.Add('Q', "⠠⠟");
            d.Add('R', "⠠⠗");
            d.Add('S', "⠠⠎");
            d.Add('T', "⠠⠞");
            d.Add('U', "⠠⠥");
            d.Add('V', "⠠⠧");
            d.Add('W', "⠠⠺");
            d.Add('X', "⠠⠭");
            d.Add('Y', "⠠⠽");
            d.Add('Z', "⠠⠵");

            d.Add('1', "⠼⠁");
            d.Add('2', "⠼⠃");
            d.Add('3', "⠼⠉");
            d.Add('4', "⠼⠙");
            d.Add('5', "⠼⠑");
            d.Add('6', "⠼⠋");
            d.Add('7', "⠼⠛");
            d.Add('8', "⠼⠓");
            d.Add('9', "⠼⠊");
            d.Add('0', "⠼⠚");

            d.Add(',', "⠂");
            d.Add('.', "⠲");
            d.Add('!', "⠖");
            d.Add('@', "⠈⠁");
            d.Add('#', "⠸⠹");
            d.Add('$', "⠈⠎");
            d.Add('%', "⠨⠴");
            d.Add('^', "⠈⠢");
            d.Add('&', "⠈⠯");
            d.Add('*', "⠐⠔");

            d.Add('(', "⠐⠣");
            d.Add(')', "⠐⠜");
            d.Add('[', "⠨⠣");
            d.Add(']', "⠨⠜");
            d.Add('{', "⠸⠣");
            d.Add('}', "⠸⠜");
            d.Add('_', "⠨⠤");

            d.Add('-', "⠤");
            d.Add('+', "⠐⠖");
            d.Add('/', "⠸⠌");
            d.Add('=', "⠐⠶");

            d.Add('|', "|");
            d.Add(':', "⠒");
            d.Add(';', "⠆");
            d.Add('"', "⠠⠶");
            d.Add('<', "⠈⠣");
            d.Add('>', "⠈⠜");


            if(d.ContainsKey(sentence))
            {
                res[i] = d[sentence];
                i++;
            }
            else
            {

            }
        }
    }
}
