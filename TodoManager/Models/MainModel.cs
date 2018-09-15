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
        public TodoListBindingList BindableLists { get; private set; }

        private MainModel(IList<TodoList> lists)
        {
            BindableLists = new TodoListBindingList(lists);
        }

        public static async Task<MainModel> CreateAsync()
        {
            var proxy = new TodoListsProxy(HttpClient.Instance);
            var lists = await proxy.GetAllListsAsync();
            return new MainModel(lists);
        }
    }
}
