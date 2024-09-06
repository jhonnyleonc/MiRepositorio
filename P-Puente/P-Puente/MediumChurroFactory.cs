using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Puente
{
    // Concrete implementation of ChurroFactory
    public class MediumChurroFactory : ChurroFactory
    {
        public MediumChurroFactory(IChurroMachine cm) : base(cm)
        {
        }

        // Implementation of PrepareChurro method
        public override void PrepareChurro()
        {
            Console.WriteLine("Medium Churros");
            churroMachine.StartChurroMachine();
            Console.WriteLine(churroMachine.GetChurro());
            Console.WriteLine("______________________");
        }
    }
}
