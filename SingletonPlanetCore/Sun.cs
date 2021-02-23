using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPlanetCore
{
    class Sun : IPlanet
    {
        private static Sun instance = null;
        private Sun() { }

        public static  Sun Instance
        {
            get
            {
                return (instance != null) ? instance : new Sun();
            }
            private set { }
        }
    }
}
