using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    [DataContract]
    public class TodoList
    {
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public BindingList<Todo> Todos { get; private set; }

        public TodoList(string name)
        {
            Name = name;
            Todos = new BindingList<Todo>();
        }
    }
}
