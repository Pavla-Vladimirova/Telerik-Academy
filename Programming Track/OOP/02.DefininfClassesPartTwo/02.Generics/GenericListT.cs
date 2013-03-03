using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//05.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
//clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
//06.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
//07.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.


namespace _02.Generics
{
    public class GenericList<T>
        where T:IComparable
    {
        const int StartCapacity = 10;
	    private T[] listGeneric;
	    private int counter = 0;

	    public GenericList(int capacity)
	    {
		    listGeneric = new T[capacity];
	    }

	    public GenericList() : this(StartCapacity)
	    {
	    }

        public int Counter
        {
            get { return this.counter; }
        }

        public void Add(T element)
        {
            if (counter >= listGeneric.Length)
            {
                T[] newListGeneric=new T [counter*counter];
                listGeneric.CopyTo(newListGeneric, 0);
                listGeneric = newListGeneric;
            }
            this.listGeneric[counter] = element;
            counter++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= counter)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = listGeneric[index];
                return result;
            }
        }

        public void RemoveByIndex(int index)
        {
            if (index >= counter)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            else
            {
                for (int i = index; i < counter-1; i++)
                {
                    listGeneric[i] = listGeneric[i + 1];
                }
                counter--;
            }
        }

        public void InsertAtGivenIndex(T element,int index)
        {
            if (index >= counter)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            else
            {
                T current=listGeneric[index];
                listGeneric[index] = element;
                T change = listGeneric[index + 1];
                counter++;
                for (int i = index+1; i < counter; i++)
                {
                    change = listGeneric[i];
                    listGeneric[i] = current;
                    current = change;
                }
            }
        }

        public void GetElementByValue(T element)
        {
            for (int i = 0; i < counter; i++)
            {
                if (listGeneric[i].CompareTo(element)==0)
                {
                    Console.WriteLine("The element is at position {0}",i);
                    return ;
                }
            }
            Console.WriteLine("There is no such element");

        }

        public void ClearAll()
        {
            while (counter!=0)
            {
                RemoveByIndex(counter-1);
            }
        }

        public override string ToString()
        {
            StringBuilder appending=new StringBuilder();
            Console.WriteLine("The list of type <{0}> is:",listGeneric.GetType());
            for (int i = 0; i < counter; i++)
            {
                appending.Append(listGeneric[i] + " ");
            }
            appending.Append("\n");
            return appending.ToString();
        }

        public T GetMin()
        {
            T minElement=listGeneric[0];
            for (int i = 0; i < counter; i++)
            {
                if (listGeneric[i].CompareTo(minElement)<0)
                {
                    minElement = listGeneric[i];
                }
            }
            return minElement;
        }

        public T GetMax()
        {
            T maxElement = listGeneric[0];
            for (int i = 0; i < counter; i++)
            {
                if (listGeneric[i].CompareTo(maxElement) > 0)
                {
                    maxElement = listGeneric[i];
                }
            }
            return maxElement;
        }
    }
}
