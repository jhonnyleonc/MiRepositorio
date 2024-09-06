using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace P_Puente
{

    namespace Bridge
    {
        public static class MainBridge
        {
            public static string ExecuteChurroPattern()
            {
                // Crear máquinas
                IChurroMachine cmChocolate = new ChurroMachineChocolate();
                IChurroMachine cmStrawberry = new ChurroMachineStrawberry();

                // Crear fábricas
                ChurroFactory smChurroFactory = new SmallChurroFactory(cmChocolate);
                ChurroFactory mdChurroFactory = new MediumChurroFactory(cmStrawberry);
                ChurroFactory lgChurroFactory = new LargeChurroFactory(cmStrawberry);



                // Capturar resultados
                string results = "";

                // Redefinir Console.SetOut para capturar la salida
                using (var sw = new System.IO.StringWriter())
                {
                    Console.SetOut(sw);

                    // Ejecutar fábricas
                    smChurroFactory.PrepareChurro();
                    mdChurroFactory.PrepareChurro();
                    lgChurroFactory.PrepareChurro();

                    // Obtener los resultados
                    results = sw.ToString();
                }

                return results;
            }
        }
    }
}
