
using Newtonsoft.Json;
using System.Security.Cryptography.X509Certificates;

namespace SerialisationApp
{
    public class SerialiserJSON : ISerialiser
    {
        public T Deserialise<T>(string fromPath)
        {
            string jsonString = File.ReadAllText(fromPath);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        public void Serialise<T>(T item, string toPath)
        {
            string jsonString = JsonConvert.SerializeObject(item);
            File.WriteAllText(toPath, jsonString);
        }        

    }
}