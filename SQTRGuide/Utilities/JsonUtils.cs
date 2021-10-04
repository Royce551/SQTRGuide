using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SQTRGuide.Utilities
{
    public class JsonUtils
    {
        public static T Read<T>(string path)
        {
            using var file = File.OpenText(path);
            return (T)new JsonSerializer().Deserialize(file, typeof(T));
        }
    }
}
