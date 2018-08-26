using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    [DataContract]
    public class MainModel
    {
        [DataMember]
        public BindingList<TodoList> TodoLists { get; private set;  }

        public MainModel()
        {
            TodoLists = new BindingList<TodoList>();
        }

        public string Serialize()
        {
            // Create a stream to serialize the object to.  
            MemoryStream ms = new MemoryStream();

            // Serializer the MainModel object to the stream.  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(MainModel));
            ser.WriteObject(ms, this);
            byte[] json = ms.ToArray();
            ms.Close();
            return Encoding.UTF8.GetString(json, 0, json.Length);
        }

        public static MainModel Deserialize(string json)
        {
            MainModel deserializedModel = new MainModel();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(deserializedModel.GetType());
            deserializedModel = ser.ReadObject(ms) as MainModel;
            ms.Close();
            return deserializedModel;
        }
    }
}
