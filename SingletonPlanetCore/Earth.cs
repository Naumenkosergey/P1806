using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPlanetCore
{
    class Earth : IPlanet
    {
        private static Earth instance = null;
        private Earth() { }

        public static Earth Instance
        {
            get
            {
                return (instance != null) ? instance : new Earth();
            }
            private set { }
        }

    }
}
