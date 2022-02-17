using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            for (int i = 0; i < 17; i++)
            {
                liste.Add(4);
            }

            //Console.WriteLine("Adet= {0} Kapasite= {1}", liste.Count , liste.Capacity);
            //Console.WriteLine($"Adet= {liste.Count} Kapasite= {liste.Capacity}" );


            //Stack

            Stack stack = new Stack();
            stack.Push(12);//Ekleme yapar
            stack.Push(22);
            stack.Push(32);

            //Console.WriteLine(stack.Peek());//En üsteki değere bakar ve söyler
            //Console.WriteLine(stack.Pop());//En üsteki değeri alır gösterir ve diziden atar
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Count);//dizideki elamanları sayar


            //Queue // ilk giren ilk çıkar (fıfo)

            Queue q = new Queue();
            q.Enqueue(12);
            q.Enqueue(22);
            q.Enqueue(32);
            //Console.WriteLine(q.Peek()); // q.Peek() En üsteki değeri gösterir 32 yi gösterir
            //Console.WriteLine(q.Dequeue()); // q.Dequeue() en üsteki değeri alır diziden gösterir 32 tutar ve diziden çeker alır
            //Console.WriteLine(q.Peek()); // q.Peek() En üsteki değeri gösterir 22 yi gösterir


            //Hashtab  son giren ilk çıkar (Lıfo)
            Hashtable ht = new Hashtable();
            ht.Add(34, "istanbul");
            ht.Add(16, "Bursa");
            ht.Add(6, "Ankara");

            //Console.WriteLine(ht[34] + "\n" +  ht[16] + "\n" + ht[6]);

            //SortedList verilen değeri baştaki keylere göre küçükten büyüğe doğru sıralama yapar
            SortedList s = new SortedList();
            s.Add(34, "Istanbul");
            s.Add(6, "Ankara");

            Console.WriteLine(s.GetByIndex(0));//Ankara geliyor.
                
        }
    }
}
