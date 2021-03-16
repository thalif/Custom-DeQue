using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeQue
{
    public class Deque
    {
        static int Capacity ;
        int[] Data = new int[Capacity];

        int Old;
        int New;
        int Count;

        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        public void InsertLast(int item)
        {
            if(IsEmpty)
            {
                New = -1;
                Old = -1;
                Data[++New] = item;
                Old++;
                Count++;
            }
            else
            {
                if((New + 1) == Capacity && Count < Capacity)
                {
                    Data[New = 0] = item;
                    Count++;
                }
                else if (Count < Capacity)
                {
                    Data[++New] = item;
                    Count++;
                }
                else if(Count == Capacity)
                {
                    ReSize();
                    InsertLast(item);
                }
            }
        }
        public void ReSize()
        {
            if(Count == Capacity)
            {
                int[] tempArray = new int[Capacity *= 2];

                int tempHead = Old;
                int tempTail = 0;

                for(int i = 0; i < Count; i++)
                {
                    if(tempHead < Count)
                    {
                        tempArray[i] = Data[tempHead++];
                    }
                    else if(tempTail < Old)
                    {
                        tempArray[i] = Data[tempTail++];
                    }
                }
                Data = tempArray;
                Old = 0;
                New = Count - 1;
            }
        }

        public void RemoveLast()
        {
            if(!IsEmpty)
            {
                Data[New--] = 0;
                Count--;
            }
            if(New < 0)
            {
                New = Capacity - 1;
            }
        }

        public void RemoveFirst()
        {
            if (!IsEmpty)
            {
                Data[Old] = 0;
                Old++;
                Count--;
            }
        }

        public Deque()
        {
            Capacity = 5;
            Data = new int[Capacity];

            Old = -1;
            New = -1;
            Count = 0;
        }
    }
}
