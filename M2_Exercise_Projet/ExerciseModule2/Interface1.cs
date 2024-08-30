using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseModule2
{
    internal interface ICollectionInt<int>
    {
        void AddFirst(int item);
        void AddLast(int item);

        void remove();
        void Add(int item);

        void Brasser(int item);



    }

    class ILinkedList : ICollectonInt
    {

    }
}
