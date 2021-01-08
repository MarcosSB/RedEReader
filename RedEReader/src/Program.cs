using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using RedEReader;
using RedEReader.src.Models;

namespace RedEConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            var generacion = Generacion.GetGeneracion();
            Console.WriteLine(generacion);
            var desc = JsonSerializer.Deserialize<Root>(generacion);
            
            foreach (var included in desc.included)
            {
                Console.WriteLine("La tecnología " + included.type + " es " + included.attributes.type);
            }
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        }
    }
}
