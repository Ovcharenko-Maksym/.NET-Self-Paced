using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayEvent
{  
    public class CustomArray<T> : IEnumerable<T>
    {
        public delegate void ArrayHandler(object sender, ArrayEventArgs<T> e);
        public event ArrayHandler OnChangeElement;
        public event ArrayHandler OnChangeEqualElement;

        private readonly T[] array;
        private int firstIndex;

        public int First
        {
            get => firstIndex;
            private set => firstIndex = value;
        }

        public int Last => firstIndex + Length - 1;

        public int Length { get; private set; }

        public T[] Array => array;

        public CustomArray(int first, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than zero.");
            }

            this.firstIndex = first;
            this.Length = length;
            this.array = new T[length];
        }

        public CustomArray(int first, IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "Collection cannot be null.");
            }

            if (list.Any())
            {
                throw new ArgumentException("empty list");
            }

            this.firstIndex = first;
            this.array = new T[list.Count()];
            int i = 0;
            foreach (var item in list)
            {
                array[i] = item;
                i++;
            }
        }

        public CustomArray(int first, params T[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "Params cannot be null.");
            }

            if (list.Length == 0)
            {
                throw new ArgumentException("Params cannot be empty.", nameof(list));
            }

            this.firstIndex = first;
            this.array = list;
            this.Length = list.Length;
        }

        public T this[int index]
        {
            get
            {
                if (index < firstIndex || index > Last)
                {
                    throw new ArgumentException("Index is out of range.");
                }

                return array[index - firstIndex];
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException(nameof(value), "value is null");
                }

                if (index < firstIndex || index > Last)
                {
                    throw new ArgumentException("Index is out of range.");
                }

                var oldValue = array[index - firstIndex];
                if (!object.Equals(oldValue, value))
                {
                    array[index - firstIndex] = value;
                    OnChangeElement?.Invoke(this, new ArrayEventArgs<T>(index, "Element value changed.", value));

                    if (object.Equals(value, index))
                    {
                        OnChangeEqualElement?.Invoke(this, new ArrayEventArgs<T>(index, "Element value equals index.", value));
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
