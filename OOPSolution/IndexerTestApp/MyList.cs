using System;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;
        public int this[int index]   // == MyList[i] == array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }   //  3
        }
        public MyList()
        {
            array = new int[3];  // 0,1,2
        }
    }
}
