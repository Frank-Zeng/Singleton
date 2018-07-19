using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class Singleton2
    {
        private static Singleton2 singleton = null;

        private Singleton2()
        {

        }

        /// <summary>
        /// 静态构造函数，由CLR保证，程序第一次使用这个类型时被调用，且只调用一次。
        /// </summary>
        static Singleton2()
        {
            singleton = new Singleton2();
        }

        /// <summary>
        /// Second method.
        /// </summary>
        /// <returns></returns>
        public static Singleton2 GetSingleton()
        {
            return singleton;
        }
    }
}
