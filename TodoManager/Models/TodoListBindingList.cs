using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Helpers;
using TodoManager.Proxies;

namespace TodoManager.Models
{
    public class TodoListBindingList : PersistentBindingList<TodoList>
    {
        private TodoListsProxy _proxy = new TodoListsProxy(HttpClient.Instance);

        public TodoListBindingList(IList<TodoList> lists)
            : base(lists)
        {
            foreach (var item in Items)
            {
                item.BindableItems = new TodoListItemBindingList(item.Id, item.Items);
            }
        }

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

        protected override async Task UpdateStoreAsync(TodoList item)
        {
            var result = await _proxy.UpdateListAsync(item.Id, item);
        }
    }
}
