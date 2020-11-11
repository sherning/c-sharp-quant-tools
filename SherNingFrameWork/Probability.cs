﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherNingFrameWork
{
    static class Probability
    {
        //================================= Project Documentation =================================
        // Project Name : Probability
        // Platform     : Console Application
        // Class Type   : Static 
        // Date         : 03-Nov-2020
        // Developer    : Sher Ning
        //=========================================================================================
        // Copyright    : 2020, Sher Ning Technologies           
        // License      : Internal use
        // Client       : Sher Ning
        // Contact      : sherning@hotmail.com
        //=========================================================================================
        // References   :         
        // Obectives    : 
        // Remarks      :
        //=========================================================================================

        /*/
         *======================================== Version ========================================
         *  03/11/2020 - Factorial
         * 
         *======================================== Version ========================================
        /*/

        public static void Call()
        {
            Test1();
        }

        private static void Test1()
        {
            int n = 9;
            int r = 7;
            Console.WriteLine("Permutation: " + Permutation(n, r));
            Console.WriteLine("Combination: " + Combination(n, r));
        }

        private static double Factorial(int n)
        {
            // 0! = 1
            if (n == 0) return 1;

            double ret = 1;
            for (int i = n; i > 0; i--)
                ret *= i;

            return ret;
        }

        private static double Permutation(int n, int r)
        {
            // nPr 
            if (n == r) return Factorial(n);
            return Factorial(n) / Factorial(n - r);
        }

        private static double Combination(int n, int r)
        {
            // nCr
            if (n == r) return 1;

            // permutation / nPn == (n!) 
            return Permutation(n, r) / Factorial(r);
        }
    }
}
