﻿namespace _2._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 一个已排序的数组即可。
            // 条件为：j > 0 && less(a[j], a[j - 1])
            // 第一个条件总是满足，
            // 只要每个 a[j] 都不小于它前一个元素，第二个条件就总是为假，
            // 故一个已排序的数组满足题意。
        }
    }
}
