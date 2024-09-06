using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Puente
{
    // Concrete implementation of IChurroMachine
    public class ChurroMachineChocolate : IChurroMachine
    {
        // Implementation of StartChurroMachine method
        public void StartChurroMachine()
        {
            Console.WriteLine("Starting machine");
        }

        // Implementation of GetChurro method
        public string GetChurro()
        {
            return "Churro de chocolate";
        }
    }
}
