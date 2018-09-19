using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TodoManager.Helpers;
using TodoManager.Proxies;

namespace TodoManager.Models
{
    public abstract class PersistentBindingList<T> : BindingList<T> where T : ISortable
    {
        private readonly bool _loading;

        public PersistentBindingList()
        {
        }

        public PersistentBindingList(IList<T> items)
        {
            ParameterValidator.CheckNull(items, "items");
            try
            {
                _loading = true;
                foreach (var item in items)
                {
                    // must use Add (not Items.Add()) for bindings to work correctly
                    Add(item);
                }
            }
            finally
            {
                _loading = false;
            }
        }

        protected override async void InsertItem(int index, T item)
        {
            // set position for new item
            item.Position = index;

            // do not go to the server if we are initially loading list
            T newItem = _loading ? item : await AddToStoreAsync(item);

            base.InsertItem(index, newItem);
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

        protected override async void OnListChanged(ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                await UpdateStoreAsync(Items[e.NewIndex]);
            }
            base.OnListChanged(e);
        }

        protected abstract Task<T> UpdateStoreAsync(T item);

        protected override async void SetItem(int index, T item)
        {
            // remove existing item at location
            await RemoveFromStoreAsync(Items[index]);

            // set position for new item
            item.Position = index;

            // add new item at position
            T newItem = await UpdateStoreAsync(item);

            // insert newly created item
            base.SetItem(index, item);
        }
    }
}
