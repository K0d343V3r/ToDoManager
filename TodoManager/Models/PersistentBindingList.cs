using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Helpers;

namespace TodoManager.Models
{
    public class PersistentBindingList<T> : BindingList<T>
    {
        protected override async void InsertItem(int index, T item)
        {
            if (index != Count)
            {
                // we only append at this stage
                throw new NotSupportedException("Insert not supported.");
            }

            T persistedItem = await AddToStoreAsync(item);

            base.InsertItem(index, persistedItem);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected virtual async Task<T> AddToStoreAsync(T item)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            throw new NotImplementedException("AddToStoreAsync must be handled by subclass.");
        }

        protected override async void RemoveItem(int index)
        {
            if (index < Count)
            {
                await RemoveFromStoreAsync(Items[index]);
            }
            
            base.RemoveItem(index);
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected virtual async Task RemoveFromStoreAsync(T item)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            throw new NotImplementedException("RemoveFromStoreAsync must be handled by subclass.");
        }

        protected override async void ClearItems()
        {
            await RemoveAllFromStoreAsync();
            base.ClearItems();
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        protected virtual async Task RemoveAllFromStoreAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            throw new NotImplementedException("RemoveAllFromStoreAsync must be handled by subclass.");
        }
    }
}
