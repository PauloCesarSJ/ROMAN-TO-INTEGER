using System.Xml.Linq;

namespace RomanToInteger
{
    public class MAIN
    {
        public static void Main()
        {
            string w = Console.ReadLine();

            int Final = 0, ultimo = 0, novo = 0;
          
            char[] s =  w.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                String p = c.ToString();
                switch (p) 
                { 
                    case "I":
                        novo = 1;
                        Final = Final + 1;
                        break;
                    case "V":
                        novo = 5;
                        Final = Final +5 ;
                        break;
                    case "X":
                        novo = 10;
                        Final = Final + 10;
                        break;
                    case "L":
                        novo = 50;
                        Final = Final + 50;
                        break;
                    case "C":
                        novo = 100;
                        Final = Final +100 ;
                        break;
                    case "D":
                        novo = 500;
                        Final = Final + 500;
                        break;
                    case "M":
                        novo = 1000;
                        Final = Final + 1000;
                        break;
                }
                if (ultimo < novo && ultimo != 0)
                {
                    Final = Final - (ultimo*2);
                }
                ultimo = novo;
            }
            Console.WriteLine(Final);
        }
    }
}