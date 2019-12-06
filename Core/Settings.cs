using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core
{
    [Serializable]
    public class SerializableSettings
    {
        public double Eps { get; set; } = 1e-6;
        public int Max { get; set; } = 500;
        public double Omega { get; set; } = 1.091;
    }
    public static class Settings
    {
        public static double Eps { get; set; } = 1e-6;
        public static int Max { get; set; } = 500;
        public static double Omega { get; set; } = 1.091;
        public static void Load()
        {
            var serializer = new XmlSerializer(typeof(SerializableSettings));
            SerializableSettings obj = null;
            using(var fs = new FileStream("settings.xml", FileMode.OpenOrCreate))
            {
                if(fs.Length != 0)
                    obj = (SerializableSettings)serializer.Deserialize(fs);
            }
            if(obj != null)
            {
                Eps = obj.Eps;
                Omega = obj.Omega;
                Max = obj.Max;
            }
        }
        public static void Save()
        {
            var serializer = new XmlSerializer(typeof(SerializableSettings));
            SerializableSettings obj = new SerializableSettings()
            {
                Max = Max,
                Eps = Eps,
                Omega = Omega
            };
            using (var fs = new FileStream("settings.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, obj);
            }
        }
    }
}
