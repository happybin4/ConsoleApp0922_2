using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_2
{
    class Math
    {
        public void Sosu(int x, int y) //x부터 y까지의 소수 구하기
        {
            int Mnum=0;
            for (int i = x; i <= y; i++) //x부터 y까지 루프
            {
                for(int j = 2; j <= i; j++)
                {
                    if(i%j == 0)
                    {
                        Mnum++;
                    }
                }
                if(Mnum == 1)
                {
                    Console.Write(i+" ");
                }
                Mnum = 0;
            }
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Math m1 = new Math();
            m1.Sosu(3, 100);
        }
    }
}
