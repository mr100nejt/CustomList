using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customeLIST
{


    public class CustomList<T>
    {
        public bool Victory;
        public int capacity;
        public int remove;
        public static int StaticCount;
        public  int Count;
        public int newCount;
        private  T[] items = new T[1];
        private  T[] items2;
        private T[] items3;
        public static CustomList<T> addedList; 
        public string NewString;
        public CustomList()
        {
            
        }

        public T this[int i]
        {

            set { items[i] = value; }
            get { return items[i]; }
        }


        class interval2
        {

            private T[] items2 = new T[0];
            public T this[int i]
            {
                set { items2[i] = value; }
                get { return items2[i]; }
            }



        }
        class interval3
        {

            private T[] items3 = new T[0];
            public T this[int i]
            {
                set { items3[i] = value; }
                get { return items3[i]; }
            }



        }
        class interval4
        {

            private T[] items4 = new T[0];
            public T this[int i]
            {
                set { items4[i] = value; }
                get { return items4[i]; }
            }



        }

        public void Add(T itemToAdd)
        {
            if (capacity >= items.Length)
            {
                items2 = new T[items.Length * 4];
                for (int i = 0; i < items.Length; i++)
                {
                    items2[i] = items[i];
                }

                items = new T[items.Length * 4];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = items2[i];
                }

            }
            items[capacity] = itemToAdd;
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
            Count = 0;

            for (int i = 0; i < capacity + 1; i++)
            {
                Count++;
            }

            capacity++;
            StaticCount = Count;

           
        }  
        public void Remove(T itemToRemove)
        {
            for (int i = 0; i < Count; i++)
            {

                if (itemToRemove.Equals(items[i]))
                {
                    remove = i;
                    for (i = 0; i <= Count; i++)
                    {
                        if (i == remove)
                        {
                            items[i] = items2[i + 2];


                        }
                        if (i < Count)
                        {
                            items2[i] = items[i + 1];
                        }
                    }


                }
            }
            newCount = 0;
            for (int i = 0; i < Count; i++)
            {

                newCount++;
                if (i == remove)
                {
                    items[i] = items2[i];
                }
                else
                {
                    items[i] = items2[i];
                }
                if (Count <= newCount)
                {
                    newCount--;
                    for (i = 0; i < Count; i++)
                    {
                        Console.WriteLine(items[i]);
                    }
                    break;
                }
            }
            Count = newCount;
            StaticCount = newCount; 
        }
        public override string ToString()
        {
            
            for (int i = 0; i < Count; i++)
            {

                NewString += items[i].ToString() + ",";


            }

            return NewString;


        }
        public static CustomList<T> operator +(CustomList<T> listToAddTo, CustomList<T> ListToAdd)
        {
            for (int i = 0; i < ListToAdd.Count; i++)
            {
                
                listToAddTo.Add(ListToAdd[i]); 
            }
            return listToAddTo;   
        }

    }

}