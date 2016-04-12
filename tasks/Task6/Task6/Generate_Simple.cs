using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Generate_Simple
    {
        public static void Run()
        {
            var observable =
                Observable.Generate(1, x => x < 6, x => x + 1, x => x,
                                             x => TimeSpan.FromSeconds(1)).Timestamp();

            using (observable.Subscribe(x => Console.WriteLine("{0}, {1}", x.Value, x.Timestamp)))
            {
                Console.WriteLine("Press any key to unsubscribe");
                Console.ReadKey();
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
