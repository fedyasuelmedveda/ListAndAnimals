using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class CustomList<T>
    {
        private T[] arr;
        private int size;
        private int maxNumber;

        public int GetSize()
        {
            return size;
        }

        public int GetNumberOfElements()
        {
            return maxNumber;
        }
        public CustomList(int size = 0)
        {
            if (size > 0)
            {
                arr = new T[size];
                this.size = size;
                this.maxNumber = 0;
            }
            else
            {
                arr = Array.Empty<T>();
                this.size = 0;
                this.maxNumber = 0;
            }
        }
        public T this[int i]
        {
            get 
            {
                if (i < maxNumber && i >= 0)
                    return arr[i];
                else
                    return default(T);
            }
            set
            {
                if (i < maxNumber && i >= 0)
                    arr[i] = value;
            }
        }
        private int FindElement(T t)
        {
            for(int i = 0; i < maxNumber; i++)
            {
                if (arr[i].Equals(t))
                    return i;
            }
            return -1;
        }

        public void FindAndDeleteElement(T t)
        {
            int f = FindElement(t);
            if (f != -1)
            {
                DeleteElementByIndex(f);
            }
        }
        public void DeleteElementByIndex(int index)
        {
            if(index >= 0 && index < maxNumber)
            {
                for(int i = index; i < maxNumber-1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                maxNumber--;
            }
        }
        public void AddElement(T t) 
        {
            if (maxNumber < size)
            {
                arr[maxNumber] = t;
                maxNumber++;
            }
            else
            {
                Array.Resize(ref arr, size += 10);
                arr[maxNumber] = t;
                maxNumber++;
            }
        
        }

    }
}
