using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Vector
{
    public class Vector<T>
    {
        // This constant determines the default number of elements in a newly created vector.
        // It is also used to extended the capacity of the existing vector
        private const int DEFAULT_CAPACITY = 10;

        // This array represents the internal data structure wrapped by the vector class.
        // All the elements are to be stored in this private  array. 
        private T[] data;

        // This property represents the number of elements in the vector
        public int Count { get; private set; } = 0;

        // This property represents the maximum number of elements (capacity) in the vector
        public int Capacity { get; private set; } = 0;

        // This is an overloaded constructor
        public Vector(int capacity)
        {
            data = new T[capacity];
        }

        // This is the implementation of the default constructor
        public Vector() : this(DEFAULT_CAPACITY) { }

        // An Indexer is a special type of property that allows a class or structure to be accessed the same way as array for its internal collection. 
        // So an element of the vector as vector[i] or vector[0] etc
        public T this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                return data[index];
            }
            set
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                data[index] = value;
            }
        }

        // This private method allows extension of the existing capacity of the vector by another 'extraCapacity' elements.
        // The new capacity is equal to the existing one plus 'extraCapacity'.
        // It copies the elements of 'data' (the existing array) to 'newData' (the new array), and then makes data pointing to 'newData'.
        private void ExtendData(int extraCapacity)
        {
            T[] newData = new T[data.Length + extraCapacity];
            for (int i = 0; i < Count; i++) newData[i] = data[i];
            data = newData;
        }

        // This method adds a new element to the existing array.
        // If the internal array is out of capacity, its capacity is first extended to fit the new element.
        public void Add(T element)
        {
            if (Count == data.Length) ExtendData(DEFAULT_CAPACITY);
            data[Count++] = element;
        }

        // This method searches for the specified object and returns the zero‐based index of the first occurrence within the entire data structure.
        // This method performs a linear search
        // If occurrence is not found, then the method returns –1.
        public int IndexOf(T element)
        {
            for (var i = 0; i < Count; i++)
            {
                if (data[i].Equals(element)) return i;
            }
            return -1;
        }

        // Read the instruction carefully, study the code examples from above as they should help you to write the rest of the code.
        public void Insert(int index, T element)
        {
            // If the internal array is full, extend its capacity
            if (Count == Capacity)
            {
                ExtendData(DEFAULT_CAPACITY);
            }
            // If index is equal to Count, add the item to the end of the Vector<T>
            if (index == Count)
            {
                Add(element);
            }
            else if (index >= 0 && index <= Count)
            {
                // Shuffle elements to the right to make space for the new element
                for (var i = Count; i >= index; i--)
                {
                    data[i + 1] = data[i];
                }
                data[index] = element;
                Count += 1;
            }
            else if (index < 0 || index > Count)
            {
                //If index is outside the range of vector, throw exception
                throw new IndexOutOfRangeException();
            }
            else
            throw new NotImplementedException();
        }

        //Clear the elements of the Vector
        public void Clear()
        {
            if (Count != 0)
            {
                Count = 0;
            }
            else
            throw new NotImplementedException();
        }

        //Method to check if the vector contains an element
        public bool Contains(T element)
        {
            return IndexOf(element) >= 0;
            throw new NotImplementedException();
        }

        //Method to remove an element, it finds the index of the element and then uses the RemoveAt method
        public bool Remove(T element)
        {
            // Store the index of the item
            int index = IndexOf(element);

            if (index != -1)
            {
                // Remove the item at the relevant index
                RemoveAt(index);

                // Return true if item was successfully removed
                return true;
            } 
            else if (index == -1)
            {
                // If the item isn't found in the Vector<T>, return false
                return false;
            } 
            else
            throw new NotImplementedException();
        }

        //Method to remove an element at a specific index
        public void RemoveAt(int index)
        {
            // If the index is invalid, throw an exception
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            else if (index <= Count) 
            {
                // Start from the index that'll be removed and thus shift elements to the left 
                for (int i = index; i < Count - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                // Decrease count because we removed an element
                Count--;
            } else 
                throw new NotImplementedException();


        }
       
        //This method converts the vector's elements to a readable string format
        public override string ToString()
        {
            // Use StringBuilder construct the string
            StringBuilder sb = new StringBuilder();

            // Start the string with an opening square bracket
            sb.Append("[");

            // Iterate over the elements of the vector
            for (int i = 0; i < Count; i++)
            {
                // Append the current element to the original string
                sb.Append(data[i]);

                // If it's not the last element, append with a comma and a space
                if (i < Count - 1)
                {
                    sb.Append(", ");
                }
            }

            // Finsh the string with a closing square bracket
            sb.Append("]");

            // Return the constructed string
            return sb.ToString();
            throw new NotImplementedException();
        }

    }
}
