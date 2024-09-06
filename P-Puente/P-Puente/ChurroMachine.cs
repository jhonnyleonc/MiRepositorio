using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Puente
{
    // Interface for ChurroMachine
    public interface IChurroMachine
    {
        // Method to start the churro machine
        void StartChurroMachine();

        // Method to get the churro
        string GetChurro();
    }
}
