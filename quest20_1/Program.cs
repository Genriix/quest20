using System;
using System.Collections;

namespace quest20_1
{
    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add((int)1);
            arrayList.Add((int)2);
            arrayList.Add((int)3);
            arrayList.Add((string)"string");
            arrayList.Add((int)5);

            for (int i = 0; i < arrayList.Count; i++) 
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}