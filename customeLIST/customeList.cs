using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customeLIST
{


    public class CustomList<T>
    {
        int capacity = 0;
        private int count;
        public int Count 
        { 
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        private T[] items = new T[1];

        public T this[int i]
        {

            set { items[i] = value; }
            get { return items[i]; }
        }
       
        private T[] items2;

      
        class interval2
        {
            public CustomList<int> i = new CustomList<int>(); 
            private T[] items2 = new T[0];
            public T this[int i]
            {
                set { items2[i] = value; }
                get { return items2[i]; }
            }

        }

        public CustomList()
        {
            
        }
        public void Add(T itemToAdd)
        {
           
            
           

            if(capacity >= items.Length)
            { 
                items2 = new T[items.Length * 2];
                for( int i = 0; i < items.Length; i++)
                {
                    items2[i] = items[i];
                }
                Array.Clear(items,0, items.Length);
                items = new T[items.Length *2];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = items2[i];
                }
                
            }
            else
            {
                
                    
                
            }
            items[capacity] = itemToAdd;
            for (int i = 0; i < items.Length; i++)
            {
               
                Console.WriteLine(items[i]);
            }
            capacity++;
        }
    }

}