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
        public CustomList()
        {
            
        }

        public T this[int i]
        {

            set { items[i] = value; }
            get { return items[i]; }
        }


        

        public void Add(T itemToAdd)
        {
            if (capacity >= items.Length)
            {
                T[] items2 = new T[items.Length * 4];
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

            T[] items2 = new T[items.Length * 4];
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
                            items2[i] = items[i+1];
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
                    for (i = i; i < Count; i++)
                    {
                        items[i] = items2[i];
                       
                    }
                    break;    
                }
                else
                {
                    items[i+1] = items2[i];
                    newCount--;
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
            Count = Count - newCount ;
            StaticCount = newCount; 
        }
        public override string ToString()
        {
            string NewString = "";
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
        public static CustomList<T> operator -(CustomList<T> listToRemoveFrom, CustomList<T> ListToRemove)
        {
            for (int i = 0; i < listToRemoveFrom.Count; i++)
            {
                listToRemoveFrom.Remove(ListToRemove[i]);
            }
            return listToRemoveFrom; 
        }
        public static T[] Zipper(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> highestList = list1;
            int lowestCount = 0;
            int leftOver = 0; 
            int b = 0;
            int stopingPoint = 0;
            int stopingPoint2 = 0;

            if (list1.Count == list2.Count)
            {
                lowestCount = list1.Count; 
            }
            else if(list1.Count< list2.Count)
            {
                lowestCount = list1.Count;
                leftOver = list2.Count - list1.Count;
                highestList = list2;
            }
            else if (list2.Count < list1.Count)
            {
                lowestCount = list2.Count;
                leftOver = list1.Count - list2.Count;
                highestList = list1;
            }


          
            T[] items2 = new T[list1.items.Length * 4];
            for (int i = 0; i <= list2.Count + list2.Count; i = i + 2)
            {  
                
                    items2[i] = list1[b];
                    b++;
                    if(b == lowestCount)
                    {
                       if(highestList == list1)
                        {
                            stopingPoint = i+1;
                            stopingPoint2 = b;

                    }
                        break;
                    }


            }
            b = 0;
            for(int i = 1; i <= list2.Count+list2.Count; i = i +2)
            {
                
                items2[i] = list2[b];
                b++;
                if(b == lowestCount)
                {
                    if (highestList == list2)
                    {
                        stopingPoint = i+1;
                        stopingPoint2 = b;
                    }
                    break;
                }
            }
            if(leftOver > 0)
            {
                for (int i = 0; i <= leftOver; i++)
                {
                    items2[stopingPoint+i] = highestList[stopingPoint2+i];
                }
                    
            }
            return items2;
        }
    }

}