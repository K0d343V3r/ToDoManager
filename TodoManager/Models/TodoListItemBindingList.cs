using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Proxies;

namespace TodoManager.Models
{
    public class TodoListItemBindingList : PersistentBindingList<TodoListItem>
    {
        private long _todoListId;
        private TodoItemsProxy _proxy = new TodoItemsProxy(HttpClient.Instance);

        public TodoListItemBindingList()
        {
        }

        public TodoListItemBindingList(long todoListId, IList<TodoListItem> items)
        {
            _todoListId = todoListId;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }

        protected override async Task<TodoListItem> AddToStoreAsync(TodoListItem item)
        {
            // initialize parent todo list
            item.TodoListId = _todoListId;

            return await _proxy.CreateItemAsync(item);
        }

        protected override async Task RemoveFromStoreAsync(TodoListItem item)
        {
            await _proxy.DeleteItemAsync(item.Id);
        }

        protected override async Task RemoveAllFromStoreAsync()
        {
            var ids = Items.Select(item => item.Id).ToList();
            await _proxy.DeleteItemsAsync(ids);
        }
    }
}
