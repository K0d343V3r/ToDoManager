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
    public abstract class PersistentBindingList<T> : BindingList<T>
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

        protected abstract Task<T> AddToStoreAsync(T item);

        protected override async void RemoveItem(int index)
        {
            if (index < Count)
            {
                await RemoveFromStoreAsync(Items[index]);
            }
            
            base.RemoveItem(index);
        }

        protected abstract Task RemoveFromStoreAsync(T item);

        protected override async void ClearItems()
        {
            await RemoveAllFromStoreAsync();
            base.ClearItems();
        }

        protected abstract Task RemoveAllFromStoreAsync();
    }
}
