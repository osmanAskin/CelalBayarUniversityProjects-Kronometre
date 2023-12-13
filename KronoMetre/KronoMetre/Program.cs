using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KronoMetre
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte dakikaBirler = 9;
            sbyte dakikaOnlar = 5;

            sbyte saniyeBirler = 9;
            sbyte saniyeOnlar = 5;

            bool kronometreCalisiyor = true;

            while (kronometreCalisiyor)
            {
                for (; dakikaOnlar >= 0; dakikaOnlar--)
                {
                    for (; dakikaBirler >= 0; dakikaBirler--)
                    {
                        for (; saniyeOnlar >= 0; saniyeOnlar--)
                        {
                            for (; saniyeBirler >= 0; saniyeBirler--)
                            {
                                Console.WriteLine(dakikaOnlar.ToString() + dakikaBirler.ToString() + ":" + saniyeOnlar.ToString() + saniyeBirler.ToString());
                                System.Threading.Thread.Sleep(1000);
                                Console.Clear();
                            }
                            saniyeBirler = 9;
                        }
                        saniyeOnlar = 5; 
                    }
                    dakikaBirler = 9; 
                }
                kronometreCalisiyor = false;
            }

            Console.ReadKey(false);
        }
    }
}



