using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class Singleton3
    {
        //静态字段
        private static Singleton3 singleton = new Singleton3();

        private Singleton3()
        {

        }

        /// <summary>
        /// Third method
        /// </summary>
        /// <returns></returns>
        public static Singleton3 GetSingleton()
        {
            return singleton;
        }
    }
}
