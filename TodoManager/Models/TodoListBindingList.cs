using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Proxies;

namespace TodoManager.Models
{
    public class TodoListBindingList : PersistentBindingList<TodoList>
    {
        private TodoListsProxy _proxy = new TodoListsProxy(HttpClient.Instance);

        protected override async Task<TodoList> AddToStoreAsync(TodoList item)  
        {
            var newItem = await _proxy.CreateListAsync(item);
            newItem.BindableItems = new TodoListItemBindingList(newItem.Id, newItem.Items);
            return newItem;
        }

        protected override async Task RemoveFromStoreAsync(TodoList item)
        {
            await _proxy.DeleteListAsync(item.Id);
        }

        protected override async Task RemoveAllFromStoreAsync()
        {
            var ids = Items.Select(item => item.Id).ToList();
            await _proxy.DeleteListsAsync(ids);
        }
    }
}
