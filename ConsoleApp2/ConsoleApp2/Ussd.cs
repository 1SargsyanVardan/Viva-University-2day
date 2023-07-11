using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ussd
    {
        int code;
        int[] actions;
        public Ussd()
        {
            code = 0;
            actions = new int[1];
        }
        public Ussd(int code,int[] actions)
        {
            this.code = code;
            this.actions = actions;
        }
        public void Print()
        {
            Console.WriteLine($"Code: {Code}            Actions : {Actions[0]} and {Actions[1]}");
        }
        public int Code { get { return code; } }
        public int[] Actions { get { return actions; } }
    }
    static public class stringExtensions
    {
        static public Ussd concatStringUssd(this string str)
        {
            //*208*2000*1#//popoxeliii
             
            /*var stringArray = str.Split('*');
            foreach(string str2 in stringArray)
                Console.WriteLine(str2);*/
            Ussd ussd;
            if(str[0]=='*' && str[4]=='*' && str[9]=='*' && str[str.Length-1]=='#')
            {
                string code = str.Substring(1, 3);
                string money = str.Substring(5, 4);
                string confirmation = str.Substring(10, 1);
                int[] hz = new int[] { int.Parse(money), int.Parse(confirmation)};
                ussd = new Ussd(int.Parse(code), hz);
                return ussd;
            }
            return null;
        }
    }
}
