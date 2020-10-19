using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace FunctionApp.viperDevice.Entity
{
    class CpuCore
    {
        public const String tag_temperature = "temperature";
        public const String tag_unit = "unit";

        public Object temperature;
        public Object unit;

        public CpuCore(String szJson)
        {
            JObject obj = JObject.Parse(szJson);
            if (obj.ContainsKey(CpuCore.tag_temperature))
                this.temperature = obj.GetValue(tag_temperature);

            if (obj.ContainsKey(CpuCore.tag_unit))
                this.unit = obj.GetValue(tag_unit);
        }
    }
}
