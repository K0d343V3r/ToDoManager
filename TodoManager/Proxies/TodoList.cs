using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Models;

namespace TodoManager.Proxies
{
    public partial class TodoList
    {
        public PersistentBindingList<TodoListItem> BindableItems { get; set; }

        public TodoList(string name)
        {
            Name = name;
            BindableItems = new PersistentBindingList<TodoListItem>();
        }
    }
}
