using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALANCE___Waga_Szalkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int waga_odwaznika_a = 0;
            int waga_odwaznika_b = 0;
            int waga_substancji = 0;
            int l_od_mniejszego = 0;
            int l_od_wiekszego = 0;

            for (; ; )
            {

                Console.WriteLine("Podaj kolejno wagi odwaznika A, B oraz substancji do odmierzenia");
                string[] dane = Console.ReadLine().Split(' ');
                waga_odwaznika_a = int.Parse(dane[0]);
                waga_odwaznika_b = int.Parse(dane[1]);
                waga_substancji = int.Parse(dane[2]);

                if (waga_odwaznika_a == 0 && waga_odwaznika_b == 0 && waga_substancji == 0)
                {
                    break;
                }
                else
                {

                    int odwaznik_mniejszy, odwaznik_wiekszy;
                    if (waga_odwaznika_a < waga_odwaznika_b)
                    {
                        odwaznik_mniejszy = waga_odwaznika_a;
                        odwaznik_wiekszy = waga_odwaznika_b;
                    }
                    else
                    {
                        odwaznik_mniejszy = waga_odwaznika_b;
                        odwaznik_wiekszy = waga_odwaznika_a;
                    }
                    bool zakonczyc = false;
                    int dzielnik = 0;
                    int obrot = 0;

                    for (dzielnik = waga_substancji; zakonczyc == false; obrot++)
                    {
                        if (dzielnik % odwaznik_wiekszy == 0 || dzielnik % odwaznik_mniejszy == 0)
                        {
                            if (dzielnik % odwaznik_mniejszy == 0 && odwaznik_mniejszy != 1)
                            {
                                l_od_mniejszego = dzielnik / odwaznik_mniejszy;
                            }
                            else
                            {
                                if (dzielnik % odwaznik_wiekszy == 0)
                                {
                                    l_od_wiekszego = dzielnik / odwaznik_wiekszy;
                                }
                                else
                                {
                                    l_od_wiekszego = dzielnik / odwaznik_wiekszy;
                                    l_od_mniejszego = dzielnik - (l_od_wiekszego * odwaznik_wiekszy);
                                }

                            }
                            zakonczyc = true;
                        }

                        else
                        {
                            if (dzielnik % (odwaznik_wiekszy + odwaznik_mniejszy) == 0)
                            {
                                l_od_wiekszego = dzielnik / (odwaznik_mniejszy + odwaznik_wiekszy);
                                l_od_mniejszego = dzielnik / (odwaznik_mniejszy + odwaznik_wiekszy);
                                zakonczyc = true;
                            }
                            else
                            {
                                if (((dzielnik + odwaznik_wiekszy) % odwaznik_mniejszy == 0) && (((dzielnik + odwaznik_mniejszy) % odwaznik_wiekszy) != 0))
                                {
                                    dzielnik += odwaznik_wiekszy;
                                    l_od_wiekszego++;
                                }
                                else
                                {

                                    dzielnik += odwaznik_mniejszy;
                                    l_od_mniejszego++;
                                }
                            }
                        }

                    }

                    //Console.WriteLine("Dzielnik=" + dzielnik);
                    if (waga_odwaznika_a < waga_odwaznika_b)
                    {
                        Console.WriteLine("{0} {1}", l_od_mniejszego, l_od_wiekszego);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1}", l_od_wiekszego, l_od_mniejszego);
                    }
                    l_od_wiekszego = 0;
                    l_od_mniejszego = 0;

                }
            }
            
        }
    }
}
