using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    [DataContract]
    public class Todo
    {
        [DataMember]
        public string Task { get; private set; }

        [DataMember]
        public bool Done { get; set; }

        public Todo(string task)
        {
            Task = task;
        }
    }
}
