using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Helpers;
using TodoManager.Proxies;

namespace TodoManager.Models
{
    public class MainModel
    {
        public PersistentBindingList<TodoList> TodoLists { get; private set;  }

        public MainModel()
        {
            TodoLists = new TodoListBindingList();
        }
    }
}
