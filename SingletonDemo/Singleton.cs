using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    public class Singleton
    {
        private static object singleton_lock = new object();

        private static Singleton singleton = null;

        private Singleton()
        {

        }

        /// <summary>
        /// First method.
        /// </summary>
        /// <returns></returns>
        public static Singleton GetSingleton()
        {
            if(singleton == null)
            {
                lock(singleton_lock)
                {
                    if(singleton == null)
                    {
                        singleton = new Singleton();
                    }
                }
            }
            return singleton;
        }
    }
}
