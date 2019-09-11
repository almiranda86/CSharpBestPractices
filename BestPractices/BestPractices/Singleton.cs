using System;
using System.Collections.Generic;
using System.Text;

namespace BestPractices
{
    /// <summary>
    /// A simple application of the Pattern Singleton
    /// </summary>
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
