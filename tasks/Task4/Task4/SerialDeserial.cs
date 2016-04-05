using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class SerialDeserial
    {
        public static void Run(IZimmerPreis[] Wohnkombinationen)
        {
            var wohn1 = Wohnkombinationen[0];

            // 1. serialize eine Wohnkombi auf einen JSON string
            Console.WriteLine(JsonConvert.SerializeObject(wohn1));

            // 2. ... with nicer formatting
            Console.WriteLine(JsonConvert.SerializeObject(wohn1, Formatting.Indented));

            // 3. serialize all items
            // ... include type, so we can deserialize sub-classes to interface type
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(Wohnkombinationen, settings));

            // 4. store json string to file "items.json" on your Desktop
            var text = JsonConvert.SerializeObject(Wohnkombinationen, settings);
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filename = Path.Combine(desktop, "Wohnkombinationen.json");
            File.WriteAllText(filename, text);

            // 5. deserialize items from "items.json"
            // ... and print Description and Price of deserialized items
            var textFromFile = File.ReadAllText(filename);
            //var itemsFromFile = JsonConvert.DeserializeObject<IZimmerPreis[]>(textFromFile, settings);
            //foreach (var x in itemsFromFile) Console.WriteLine($"{x} {x.AnzZimmer} {x.Preis}");
            var itemsFromFile = JsonConvert.DeserializeObject(textFromFile, settings);
            //foreach (var x in itemsFromFile) Console.WriteLine($"{x} {x.AnzZimmer} {x.Preis}");
            Console.WriteLine(itemsFromFile);
        }
    }
}
