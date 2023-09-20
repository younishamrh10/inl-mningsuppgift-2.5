using System;
namespace uppgift2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriva in en beräkning som innehållande två decimaltal och ett gångertecken");
            string beräkning = Console.ReadLine();
            int gångerindex = beräkning.IndexOf("*");
            string decimal1text = beräkning[..gångerindex];
            string decimal2text = beräkning[(gångerindex + 1)..];
            float decimal1 = float.Parse(decimal1text);
            float decimal2 = float.Parse(decimal2text);
            float svar = decimal1 * decimal2;
            Console.WriteLine("svare är" + svar);
        }
    }
}