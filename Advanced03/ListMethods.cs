using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03
{
    internal class ListMethods<T>
    {
        private int Count;
        
        public T[] values;
        public ListMethods(int count) 
        {  
            Count = count;
            
            values = new T[count];
        }
        public T this[int ind]
        {
            
            set 
            {
                if (ind < Count && ind >= 0)
                    values[ind] = value;
                
                else 
                    throw new ArgumentOutOfRangeException();
            }
            get 
            {
                if(ind < Count && ind >=0)
                   return values[ind]; 
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> list = new List<T>(Count);
            if (predicate != null)
            {
                for (int i = 0; i < Count; i++) 
                {
                    if (predicate(this[i]))
                    {
                        list.Add(this[i]);
                    }
                }

            }
            return list;

        }

        public T Find(Predicate<T> predicate) 
        {
            if(predicate != null)
            {
                for(int i = 0;i < Count; i++)
                {
                    if (predicate(this[i]))
                    {
                        return this[i];
                    }
                }
            }
            return default;
        }

        public T FindLast(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = Count-1; i > 0; i--)
                {
                    if (predicate(this[i]))
                    {
                        return this[i];
                    }
                }
            }
            return default;
        }

        public int FindIndex(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (predicate(this[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        public int FindLastIndex(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = Count - 1; i > 0; i--)
                {
                    if (predicate(this[i]))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public void RemoveAll(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (predicate(this[i])) { values[i] = default; }
                }
            }
        }
        public void Remove(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (predicate(this[i])) 
                    { 
                        values[i] = default;
                        return;
                    }
                }
            }
        }

        public bool Exists(Predicate<T> predicate)
        {
            if(predicate != null)
            {
                for(int i = 0;i < Count; i++)
                {
                    if (predicate(this[i]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool TrueForAll(Predicate<T> predicate)
        {
            if (predicate != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (!predicate(this[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Foreach(Action<T> action)
        {
            if(action != null)
            {
                for(int i =0; i < Count; i++)
                {
                    action(this[i]);
                }
            }
        }
    }
}
