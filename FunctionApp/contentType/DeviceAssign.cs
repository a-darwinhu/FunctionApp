using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace FunctionApp.contentType
{
    class DeviceAssign
    {
        public DeviceAssign(String szJson)
        {
            JObject obj = JObject.Parse(szJson);
            //if (obj.ContainsKey(GraphicDynamic.tag_Temperature))
            //    this.temperature = obj.GetValue(GraphicDynamic.tag_Temperature);

            //if (obj.ContainsKey(GraphicDynamic.tag_unit))
            //    this.unit = obj.GetValue(GraphicDynamic.tag_unit);
        }
    }
}
