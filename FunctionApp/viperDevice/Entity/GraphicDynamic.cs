using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace FunctionApp.viperDevice.Entity
{
    class GraphicDynamic
    {
        public const String tag_Order             = "Order";
        public const String tag_Temperature       = "Temperature";
        public const String tag_unit              = "unit";

        public Object order;
        public Object temperature;
        public Object unit;

        public GraphicDynamic(String szJson)
        {
            JObject obj = JObject.Parse(szJson);
            if (obj.ContainsKey(GraphicDynamic.tag_Temperature))
               this.temperature = obj.GetValue(GraphicDynamic.tag_Temperature);

            if (obj.ContainsKey(GraphicDynamic.tag_unit))
                this.unit = obj.GetValue(GraphicDynamic.tag_unit);
        }

    }


}
