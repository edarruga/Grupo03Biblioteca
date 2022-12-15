using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Entity<T> : IEquatable<Entity<T>>
    {
        private T id;
        public Entity(T id) { this.id = id; }
        public T Id { get { return this.id; } }
        public bool Equals(Entity<T> other)
        {
            if (other==null)
            {
                return false;
            }
            else
            {
                return this.id.Equals(other.id);
            }
        }
    }
}
