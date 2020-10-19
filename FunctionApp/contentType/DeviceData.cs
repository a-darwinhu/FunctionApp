using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FunctionApp.contentType
{
    class DeviceData
    {
        //=====================================
        // Receive data
        public const string data_id        = "id";
        public const string data_deviceId  = "deviceId";
        public const string data_viperdata = "viperdata";
        public const string data_Datatype  = "DataType";
        //=====================================

        public const string IDENTITY = "dd";
        public const string OS = "UNKNOWN";

        public enum TYPE
        {
            staticdata,
            dynamicdata
        }
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "contentType")]
        public string contentType { get; set; }
        [JsonProperty(PropertyName = "os")]
        public string os { get; set; }
        [JsonProperty(PropertyName = "lastupdate")]
        public long lastupdate { get; set; }
        [JsonProperty(PropertyName = "telemetryId")]
        public string telemetryId { get; set; }
        [JsonProperty(PropertyName = "deviceId")]
        public string deviceId { get; set; }
        [JsonProperty(PropertyName = "viperdata")]
        public object viperdata { get; set; }
        

        public DeviceData(String szJson, string id)
        {
            if(String.IsNullOrEmpty(id))
                this.id = Common.generateUUID(DeviceData.IDENTITY);

            if (!String.IsNullOrEmpty(szJson)) {
                this.os = DeviceData.OS;
                this.lastupdate = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                JObject obj = JObject.Parse(szJson);

                if (obj.ContainsKey(data_id))
                    this.telemetryId = obj.GetValue(data_id).ToString();

                if (obj.ContainsKey(data_deviceId))
                    this.deviceId = obj.GetValue(data_deviceId).ToString();

                if (obj.ContainsKey(data_viperdata))
                    this.viperdata = obj.GetValue(data_viperdata);

                JObject objViperdata = JObject.Parse(this.viperdata.ToString());

                this.contentType = (objViperdata.GetValue(data_Datatype).ToObject<int>() ==
                                    ((int)TYPE.staticdata)) ?
                                    TYPE.staticdata.ToString() :
                                    TYPE.dynamicdata.ToString();
            }
        }
    }
}
