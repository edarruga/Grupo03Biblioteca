using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal class Table<T, U> : KeyedCollection<T, U> where U : Entity<T> where T : IEquatable<T>
    {
        protected override T GetKeyForItem(U item)
        {
            return item.Id;
        }
    }
}
