using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Puente
{
    // Abstract base class for ChurroFactory
    public abstract class ChurroFactory
    {
        protected IChurroMachine churroMachine;

        // Constructor that initializes the churroMachine
        protected ChurroFactory(IChurroMachine cm)
        {
            churroMachine = cm;
        }

        // Abstract method to be implemented by derived classes
        public abstract void PrepareChurro();
    }
}
