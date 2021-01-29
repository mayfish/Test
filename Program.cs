using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        /*
         * 程式進入點
         */
        static void Main(string[] args)
        {

            Fun1();
            Fun2();
            //CheckIDNo();

            Console.ReadKey();
            //https://docs.microsoft.com/zh-tw/dotnet/csharp/tutorials/intro-to-csharp/hello-world
            //https://www.jetbrains.com/lp/mono/
        }

        /// <summary>
        /// n++、++n的區別
        /// </summary>
        static void Fun1()
        {
            int n = 1;
            n = n + 1;
            n++;
            ++n;
            Console.WriteLine($"n: {n}");
            Console.WriteLine($"-------------------------------------");

            n = 1;
            while (true)
            {
                // 先比較 n < 3 是否成立, 然後再做 n = n + 1
                if (n++ < 3)
                {
                    Console.WriteLine($"n: {n}");
                    continue;
                }
                else
                    break;
            }
            Console.WriteLine($"n: {n}");
            Console.WriteLine($"-------------------------------------");
            n = 1;
            while (true)
            {
                // 先做 n = n + 1, 然後再比較 n < 3 是否成立
                if (++n < 3)
                {
                    Console.WriteLine($"n: {n}");
                    continue;
                }
                else
                    break;
            }
            Console.WriteLine($"n: {n}");
        }

        /// <summary>
        /// 運算子優先順序
        /// https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/operators/
        /// </summary>
        static void Fun2()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" true && false = { test(true) && test(false)}");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" false && true = { test(false) && test(true)}");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" true || false = { test(true) || test(false)}");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($" false || true = { test(false) || test(true)}");
        }
        static bool test(bool para)
        {
            Console.WriteLine("do it");
            return para;
        }

        static void CheckIDNo() 
        {
            /*
            * 在主控台上顯示文字
            */
            Console.WriteLine(@"===身分證字號驗證器===");

            /*
             * 迴圈
             */
            do
            {
                /*
                 * 特殊字元 @
                 * https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/tokens/verbatim
                 */
                //Console.WriteLine("請輸入\"身分證字號\":");
                Console.WriteLine(@"請輸入""身分證字號"":");
                //Console.WriteLine("請輸入\"身分證字號\":");

                /*
                 * 讀取輸入的字串
                 */
                string input = Console.ReadLine();

                /*
                 * 檢查輸入的字串是否為10碼
                 */
                if (input.Length != 10)
                {
                    Console.WriteLine("錯誤:身分證字號應為10碼");

                    /*
                     * 忽略後續，重接跳到 "while" 執行
                     */
                    continue;
                }

                var tWIDCard = new TWIDCard();
                var result = tWIDCard.CheckIDNo(input);

                /*
                 * 特殊字元 $
                 * https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/tokens/interpolated
                 */
                //Console.WriteLine(input + " : " + (result ? "OK" : "Error"));
                Console.WriteLine($"{input} : {(result ? "OK" : "Error")}");
            } while (true);
        }
    }
}
