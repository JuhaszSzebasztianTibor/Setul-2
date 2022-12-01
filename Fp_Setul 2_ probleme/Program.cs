using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fp_Setul_2__probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();

        }

        /// <summary>
        /// 17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. 
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. 
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// <summary>


        private static void P17()
        {
            Console.WriteLine("Problema 17.");
            int n, numSecventa,  suma = 0, max = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");

            for (int i = 0; i < n; i++)
            {

                numSecventa = int.Parse(Console.ReadLine());

                if (numSecventa == 0)
                    suma++;
                else
                    suma--;
                if (suma > max)
                    max = suma;
                if (suma < 0)
                    break;
            }

            if (suma != 0)
                Console.WriteLine("Secventa nu este corecta");
            else
                Console.WriteLine("Secventa este corecta si are nivelul maxim de incuibare " + max);


        }

        /// <summary>
        /// 16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. 
        /// Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>


        private static void P16()
        {
            Console.WriteLine("Problema 16.");
            int n, firstNum, numSecventa,numSecventa1, count = 0, rest = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");
            firstNum = int.Parse(Console.ReadLine());
            numSecventa1 = int.Parse(Console.ReadLine());

            if (firstNum > numSecventa1)
                rest = 1;
            firstNum = numSecventa1;

            for (int i = 2; i < n; i++)
            {

                numSecventa = int.Parse(Console.ReadLine());

                if (count % 2 == rest)
                {
                    if (firstNum > numSecventa)
                        count++;
                }
                else
                {
                    if (firstNum < numSecventa)
                        count++;
                }
                firstNum = numSecventa;
            }

            if (count < 3)
                Console.WriteLine("Secventa este o secventa bitonioca, poate fi transformata");
            else
                Console.WriteLine("Secventa nu este o secventa bitonica, nu poate fi transformata");


        }

        /// <summary>
        /// 15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>

        private static void P15()
        {
            Console.WriteLine("Problema 15.");
            int n, firstNum, numSecventa, count = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");
            firstNum = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                
                numSecventa = int.Parse(Console.ReadLine());
                
                if (count % 2 == 0)
                {
                    if (firstNum > numSecventa)
                        count++;
                }
                else
                {
                    if (firstNum < numSecventa)
                        count++;
                }
                firstNum = numSecventa;
            }

            if (count > 1 || count == 0)
                Console.WriteLine("Secventa nu este o secventa bitonica");
            else
                Console.WriteLine("Secventa este o secventa bitonica");

        }

        /// <summary>
        /// 14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. 
        /// Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>

        private static void P14()
        {
            Console.WriteLine("Problema 14.");
            int n ,firstNum, save_first, numSecventa = 0, numDecrease = 0, numIncrease = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");
            firstNum = int.Parse(Console.ReadLine());

            save_first = firstNum;
            for (int i = 1; i < n; i++)
            {
                numSecventa = int.Parse(Console.ReadLine());

                if (firstNum < numSecventa) numIncrease++;

                if (firstNum > numSecventa) numDecrease++;

                firstNum = numSecventa;
            }


            if (save_first < numSecventa) numIncrease++;

            if (save_first > numSecventa) numDecrease++;


                if (numIncrease <= 1)
                Console.WriteLine("Sirul este o secventa monotona crescatoare rotita");
                
                else if(numDecrease <= 1)
                {
                    Console.WriteLine("Sirul este o secventa monotona descrescatoare rotita"); ;
                }
                else
                Console.WriteLine("Sirul nu este o secventa monotona rotita");

                 
        }

        /// <summary>
        /// 13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive 
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). 
        /// Determinati daca o secventa de n numere este o secventa crescatoare rotita.  
        /// </summary>

        private static void P13()
        {
            Console.WriteLine("Problema 13.");
            int n, numSecventa, save_first,  firstNum, numDecrease = 0;
           
            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");
            firstNum = int.Parse(Console.ReadLine());

            save_first = firstNum;
            for(int i = 1; i < n; i++)
            {
                numSecventa= int.Parse(Console.ReadLine());

               if (firstNum < numSecventa) numDecrease++;

               firstNum = numSecventa;
              
            }

            if (numDecrease == 1 && save_first > firstNum)
            {
                Console.WriteLine($"Secventa este crescatoare rotita");
            }
            else
            {
                Console.WriteLine($"Secventa nu este crescatoare rotita");
            }


        }

        /// <summary>
        /// 12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>

        private static void P12()
        {
            Console.WriteLine("Problema 12.");
            int n, numSecventa, numCount = 0, secventaCount = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");

            for(int i = 0; i < n; i++)
            {

                numSecventa = int.Parse(Console.ReadLine());
                    
                if(numSecventa != 0)
                {
                    
                    numCount++;
                    
                }
                else if(numCount != 0)
                {
                    secventaCount++;
                    numCount = 0;
                }

            }

            if(numCount != 0)
            {
                    secventaCount++;
                    numCount = 0;
            }
            Console.WriteLine($"Sunt {secventaCount} grupuri de numere diferite de zero." );

        }

        /// <summary>
        /// 11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>

        static int Inversa(int x)
        {
            int num = 0;
            
            while(x != 0) 
            {
                num = num * 10 + x % 10;
                x = x / 10;
            }

            return num;
        }


        private static void P11()
        {
            Console.WriteLine("Problema 11.");
            int n, numSecventa, inv, suma = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");

            for(int i = 0; i < n; i++)
            {

                numSecventa = int.Parse(Console.ReadLine());

                inv = Inversa(numSecventa);
                suma = suma + inv;
    
            }

            Console.WriteLine("Suma inverselor este " + suma);


        }

        /// <summary>
        /// 10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>


        private static void P10()
        {
            Console.WriteLine("Problema 10.");
            int n, numSecventa, firstNum, count = 1, max = 0;
            
            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere!");
            firstNum = int.Parse(Console.ReadLine());   

            for(int i = 1; i < n; i++)
            {
                numSecventa= int.Parse(Console.ReadLine());

                if (firstNum == numSecventa)
                {
                    count++;
                }
                else if (count > max)
                {
                       
                    max = count;

                }

                firstNum = numSecventa;

            }

            if (count > max)
            {
                max = count;
            }
            else if (count == 1)
            {
                max = 0;
            }

            Console.WriteLine("Numarul maxim de numere consecutive egale este " + max);
        }

        /// <summary>
        /// 9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>

        private static void P9()
        {
            Console.WriteLine("Problema 9.");

            int n, numSecventa,firstNum;

            bool cresc = true, desCresc = true;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere!");

            firstNum = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                numSecventa = int.Parse(Console.ReadLine());


                if (firstNum < numSecventa)
                {
                    cresc = false;
                }

                if (firstNum > numSecventa)
                {
                    desCresc = false;
                }

                firstNum = numSecventa;   
            }

            if(cresc || desCresc)
            {
                Console.WriteLine("Secventa este monotona");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona");
            }

        }

        /// <summary>
        /// 8. Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ... 
        /// </summary>

        private static void P8()
        {
            Console.WriteLine("Problema 8.");
            int firstNum = 0, secondNum = 1, thirdNum, n;

            Console.Write("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write(firstNum + " " + secondNum + " ");
            for(int i = 2; i < n; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write(thirdNum + " ");
                firstNum = secondNum;
                secondNum = thirdNum;
            }
            Console.WriteLine();
            Console.ReadKey();



        }

        /// <summary>
        ///  7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
        /// </summary>

        private static void P7()
        {
            Console.WriteLine("Problema 7.");

            int n, numSecventa, max = 0, min = 0;
            
            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti secventa de numere");
            numSecventa = int.Parse(Console.ReadLine());

            min = numSecventa;
            max = numSecventa;
            while (n > 0) 
            {
                numSecventa = int.Parse(Console.ReadLine());

                if(numSecventa > max) max = numSecventa;
                if(numSecventa < min) min = numSecventa;
                n--;
            }
            Console.WriteLine(max + " " + min);
        }

        /// <summary>
        /// 6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>

        private static void P6()
        {
            Console.WriteLine("Problema 6.");

            int n, numSecventa;
            bool isCrescator = false;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere");
            numSecventa = int.Parse(Console.ReadLine());

            

            int max = numSecventa;
            for (int i = 1; i < n; i++)
            {
                numSecventa = int.Parse(Console.ReadLine()); 
                if (numSecventa > max)
                {
                    max = numSecventa;
                    isCrescator = true;
                    // Metoda 2
                    //if(i == n-1)
                    //{
                    //    Console.WriteLine("Este crescator");
                    //}

                }
                else 
                {
                    isCrescator = false;
                }
            }
            if (isCrescator)
            {
                Console.WriteLine("Este crescator");

            }
            else
            {
                Console.WriteLine("Nu este crescator");
            }

        }

    /// <summary>
    /// 5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
    /// Se considera ca primul element din secventa este pe pozitia 0. 
    /// </summary>


    private static void P5()
        {
            Console.WriteLine("Problema 5.");
            int n, numSecventa, counter = 0;
            
            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti secventa de numere ");

            for (int i = 0; i < n; i++)
            {

                numSecventa = int.Parse(Console.ReadLine());
                
                if(numSecventa == i)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Numerele egale cu pozitia pe care apar in secventa sunt {counter}");
        }

        /// <summary>
        /// 4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.
        /// </summary>

        private static void P4()
        {
            Console.WriteLine("Problema 4.");
            Console.WriteLine();
            int n, numSecventa, a, index = -1;
            bool gasit = false;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul a = ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introducet secventa de numere");

               
                for (int i = 0; i < n; i++)
                {
                    numSecventa = int.Parse(Console.ReadLine());
                    if (numSecventa == a)
                    {
                        index = i;
                        gasit = true;
                    }
                }
 
                if(gasit)
                {
                    Console.WriteLine("Este " + index);
                }
                else
                {
                    Console.WriteLine(index);
                }

        }

            /// <summary>
            /// 3. Calculati suma si produsul numerelor de la 1 la n. 
            /// </summary>

            private static void P3()
        {
            Console.WriteLine("Problema 3.");
            Console.Write("Introduceti un numar n = ");

            int n, s = 0, p = 1;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                s = (n * (n + 1)) / 2;
                p = p * i;
            }
            Console.WriteLine("Suma numerelor este {0}, iar produsul este {1}", s, p);

        }

        /// <summary>
        /// 2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>

        private static void P2()
        {
            Console.WriteLine("Problema 2.");
            Console.WriteLine();

            int n, numSecventa, poz = 0, neg = 0, zero = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere!");

            for (int i = 0; i < n; i++)
            {
                numSecventa = int.Parse(Console.ReadLine());
                if (numSecventa == 0) zero++;
                if (numSecventa < 0) neg++;
                if (numSecventa > 0) poz++;
            }
            Console.WriteLine("Din secventa data " + poz + " numere sunt pozitive, " + neg + " numere sunt negative si " + zero + " zero"); 
        }

        /// <summary>
        /// 1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>

        private static void P1()
        {
            Console.WriteLine("Problema 1.");
            int n, numSecventa, counter = 0;

            Console.WriteLine("Introduceti un numar n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti secventa de numere !");

            for (int i = 0; i < n; i++)
            {
                numSecventa = int.Parse(Console.ReadLine());
                if (numSecventa % 2 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Din secventa data {counter} numere sunt pare");
        }
    }
}
