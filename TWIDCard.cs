using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class TWIDCard
    {
        //https://web.fg.tp.edu.tw/~anny/idtest.htm
        public bool CheckIDNo(string idno)
        {
            var d = false;
            if (idno.Length == 10)
            {
                idno = idno.ToUpper();

                Console.WriteLine("------------------------------");
                Console.WriteLine($"A: {(int)'A'}");
                Console.WriteLine($"Z: {(int)'Z'}");
                Console.WriteLine($"0: {(int)'0'}");
                Console.WriteLine($"1: {(int)'1'}");
                Console.WriteLine($"2: {(int)'2'}");
                Console.WriteLine($"3: {(int)'3'}");
                Console.WriteLine($"9: {(int)'9'}");
                Console.WriteLine("------------------------------");

                if (idno[0] >= 0x41 && idno[0] <= 0x5A)
                {
                    var a = new[] { 10, 11, 12, 13, 14, 15, 16, 17, 34, 18, 19, 20, 21, 22, 35, 23, 24, 25, 26, 27, 28, 29, 32, 30, 31, 33 };
                    var b = new int[11];

                    /*
                     * 區域碼為A時, 我們預期要取到a[0],也就是10,因為A的ASCII值 = 65, 65-65=0, 所以減65
                     * https://zh.wikipedia.org/wiki/ASCII
                     */
                    b[1] = a[(idno[0]) - 65] % 10;
                    //Console.WriteLine($"a[{(idno[0]) - 65}] % 10 = {b[1]}");

                    var c = b[0] = a[(idno[0]) - 65] / 10;
                    //Console.WriteLine($"a[{(idno[0]) - 65}] / 10 = {b[0]}");
                    //Console.WriteLine($"c: {c}");
                    //Console.WriteLine($"b[0]: {b[0]}");
                    for (var i = 1; i <= 9; i++)
                    {
                        // 字串轉數字, 0 的ASCII值為48
                        b[i + 1] = idno[i] - 48;
                        
                        //計算
                        c += b[i] * (10 - i);
                    }
                    //檢查碼
                    if (((c % 10) + b[10]) % 10 == 0)
                    {
                        d = true;
                    }
                }
            }
            return d;
        }
    }

    
}
