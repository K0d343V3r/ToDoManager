using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager.Proxies
{
    public partial class TodoListItem
    {
        public TodoListItem(string task)
        {
            Task = task;
        }
    }
}
