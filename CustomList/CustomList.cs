using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;
        public T[] Items { get { return items; } set { items = value; } }
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }
        //Constructor
        public CustomList()
        {
            count = 0;
            items = new T[4];
            capacity = items.Length;

        }

        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            if (count == capacity)
            {
                T[] newItems = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }                
                capacity= newItems.Length;
                items = newItems;
               
            }
                            
            items[count] = item;
            count++;
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            if (items.Contains(item))
            {
                int itemIndex = Array.IndexOf(items, item);
                // Create new, updated array with same capacity
                // If value is BEFORE itemIndex, assign as usual
                // If item is AFTER, assign that index to NEXT value (index+1)
                T[] newArray = new T[capacity];
                for (int i = 0;i < count; i++)
                {
                    if( i < itemIndex)
                    {
                        newArray[i] = items[i];
                    }
                    else
                    {
                        newArray[i] = items[i + 1];
                    }
                }
                items = newArray;
                count--;
                return true;
            }
            else
            {
            return false;

            }
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            string finalString = "";
            int countValue = 0;
            foreach(T item in items)
            {
                countValue++;
                if (countValue <= count)
                {
                finalString += item.ToString();
                }
            }
            return finalString;
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            for (int i = 0; i < secondList.Count; i++)
            {
                firstList.Add(secondList[i]);
            }
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
