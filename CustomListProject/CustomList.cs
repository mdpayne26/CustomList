using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private int capacity = 4;
        private int count;
        private T[] items;
        private int remove;
        //private T item;
        //CustomList<int> custom = new CustomList<int>();

        public CustomList()
        {
            items = new T[capacity];

        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity = capacity * 2;
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                temp[count] = item;

                items = temp;
            }
            else items[count] = item;
            count++;
        }
        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
        public bool Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].Equals(item) && i == count - 1)
                {
                    items[i] = items[i];
                    count--;
                    CopyIntoNewArray();
                }
                else if (items[i].Equals(item))
                {
                    items[i] = items[i + 1];
                    count--;
                    items[i].Equals(i++);
                    items[i++] = items[i++];

                    //count--;

                    CopyIntoNewArray();
                    return true;
                }
                
            }
            return false;
        }
        public void CopyIntoNewArray()
        {
            T[] temp = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                temp[i] = items[i];
            }
            //temp[count] = item;
            //for (int i = 0; i < count; i++)
            //{
            //    if ()
            //}

            items = temp;
        }
        public override string ToString()
        {
            string changeToString = "";
            for (int i = 0; i < count; i++)
            {
                changeToString = changeToString + items[i] + " ";
            }

            return changeToString.Trim();
        }


    }
}
