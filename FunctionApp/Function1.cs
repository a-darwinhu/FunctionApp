using System;
using System.Collections.Generic;
using Microsoft.Azure.Documents;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Collections;
using Microsoft.Azure.Documents.Client;
using System.Linq;

using FunctionApp.viperDevice;
using FunctionApp.viperDevice.Entity;
using FunctionApp.Status;
using FunctionApp.contentType;

namespace FunctionApp
{
    public static class Function1
    {
        public const string outContainername = "contents";
        public const string collectionName = "stevesteas";

        // The primary key for the Azure Cosmos account.
        static readonly string EndpointUri = System.Environment.GetEnvironmentVariable("endpointUrl");
        static readonly string PrimaryKey = System.Environment.GetEnvironmentVariable("primaryKey");

        [FunctionName("Function1")]
        public static void Run(
            [CosmosDBTrigger(
            databaseName: "telemetry",
            collectionName: "stevesteas",
            ConnectionStringSetting = "cosmosdbConnectionString",
            LeaseCollectionName = "LeaseCollection",
            LeaseCollectionPrefix = "prefix1",
            CreateLeaseCollectionIfNotExists =true)] IReadOnlyList<Document> input,
            ILogger log)
        {
            if (input != null && input.Count > 0)
            {
                log.LogInformation("Documents modified " + input.Count);
                log.LogInformation("First document Id " + input[0].Id);

            }
            //*****************************************************************
            // Update/Create new to CosmosDB
            JObject obj = JObject.Parse(input[0].ToString());
            var doc_deviceId = GetJArrayValue(obj, "deviceId");
            JObject objViperdata = JObject.Parse(obj.GetValue("viperdata").ToString());
            var doc_DataType = (int.Parse(objViperdata.GetValue("DataType").ToString()) == 0) ? DeviceData.TYPE.staticdata.ToString() : DeviceData.TYPE.dynamicdata.ToString() ;


            //string output = JsonConvert.SerializeObject(odeviceData);
            DeviceData odeviceData = new DeviceData(obj.ToString(), "");
            // Saving the data
            try
            {
                var collectionUri = UriFactory.CreateDocumentCollectionUri(outContainername, collectionName);
                DocumentClient client = new DocumentClient(new Uri(EndpointUri), PrimaryKey);
                var option = new FeedOptions { EnableCrossPartitionQuery = true };
                var count = client.CreateDocumentQuery<DeviceData>(collectionUri, option)
                          .Where(doc => doc.contentType == doc_DataType)
                          .Count();

                // exist
                if (count != 0)
                {
                    // get current id
                    var id = client.CreateDocumentQuery<DeviceData>(collectionUri, option)
                             .Where(doc => doc.deviceId == doc_deviceId && doc.contentType == doc_DataType)
                             .Select(doc => doc.id)
                             .AsEnumerable()
                             .First();

                    // update the DeviceData
                    odeviceData.id = id;
                }
    
                // create/update new DeviceData
                Console.WriteLine(odeviceData.id);
                var result = client.UpsertDocumentAsync(collectionUri, odeviceData).Result;
                
            }
            catch (DocumentClientException dce)
            {
                Console.WriteLine(dce.Message);
            }


            //String deviceId = obj.GetValue("deviceId").ToString();
            //String test = GetJArrayValue(obj, "id");

            //JObject objViperdata = JObject.Parse(obj.GetValue("viperdata").ToString());

            //var cosmmosdb = new CosmosDBAttribute("contents", "stevesteas");

            //Console.WriteLine(deviceId);

            //String deviceIds = obj.ContainsKey("deviceIdSSSS").ToString();

            //String szGraphic = objViperdata.GetValue("Graphics").ToString();

            //List<GraphicDynamic> lst_graphic = new List<GraphicDynamic>();

            //List<Object> lstGraphic = JsonConvert.DeserializeObject<List<Object>>(szGraphic);
            //foreach (Object item in lstGraphic) // Loop through List with foreach
            //{
            //    Console.WriteLine(item.ToString());
            //    GraphicDynamic objItem = new GraphicDynamic(item.ToString());
            //    lst_graphic.Add(objItem);
            //}

            //Console.WriteLine(lst_graphic.Count);

            //log.LogInformation(collectionName);



        }

        private static string GetJArrayValue(JObject yourJArray, string key)
        {
            foreach (KeyValuePair<string, JToken> keyValuePair in yourJArray)
            {
                if (key == keyValuePair.Key)
                {
                    return keyValuePair.Value.ToString();
                }
            }
            return "";
        }




    }
}
