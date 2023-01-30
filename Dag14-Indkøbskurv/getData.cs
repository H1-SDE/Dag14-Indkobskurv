using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dag14_Indkøbskurv
{
    internal class GetData
    {
        public static Events GetEvent()
        {
            using (var sr = new StreamReader("data/Events.json"))
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                string data = sr.ReadToEnd();

                return JsonSerializer.Deserialize<Events>(data, options);}


        }


    }
}
