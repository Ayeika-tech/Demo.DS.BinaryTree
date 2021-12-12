using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DS.BinaryTree.Lib.Heap
{
    public class MaxHeap : BaseHeap
    {
        public MaxHeap(int size) : base(size) 
        { }

        public override void ReCalculateDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);

                if (HasRightChild(index) && GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex] < _elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        public override void ReCalculateUp()
        {
            var index = _size - 1;

            while (!IsRoot(index) && _elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
