using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPlanetCore
{
    class Moon : IPlanet
    {
        private static Moon instance = null;
        private Moon() { }

        public static Moon Instance
        {
            get
            {
                return (instance != null) ? instance : new Moon();
            }
            private set { }
        }
    }
}
