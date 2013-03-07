using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GenericList<T> where T : IComparable
{
    // Fields
    private T[] genericArray;
    private int position;

    // Constructor with capacity parameter
    public GenericList (int capacity)
    {
        this.genericArray= new T[capacity];
    }

    // Methods
    public void AddElement(T element)
    {
        if (position >= genericArray.Length)
        {
            T[] newList = new T[genericArray.Length * 2];
            for (int i = 0; i < genericArray.Length; i++)
            {
                newList[i] = genericArray[i];
            }
            position++;
            newList[genericArray.Length] = element;
            genericArray = newList;
        }
        else
        {
            genericArray[position] = element;
            position++;
        }
    }

    public int AccessByIndex(int index)
    {
        dynamic element = genericArray[index];
        return element;
    }

    public void RemoveAtIndex(int index)
    { 
        if (index != genericArray.Length - 1)
        { 
            // Initializing new array with  (capacity - 1) elements
            T[] tempArray = new T[genericArray.Length - 1];
            for (int i = 0; i < genericArray.Length - 1; i++)
            {
                while (i < index)
                {
                    tempArray[i] = genericArray[i];
                    i++;
                }
                tempArray[i] = genericArray[i + 1];
            }
            genericArray = tempArray;
        }
        else // Condition if the last index is chosen
        {
            T[] tempArray = new T[genericArray.Length - 1];
            for (int i = 0; i < genericArray.Length - 1; i++)
            {
                tempArray[i] = genericArray[i];
            }
            genericArray = tempArray;
        }
        
    }

    public void InsertAtIndex(int index, T element)
    {
            T[] tempArray = new T[genericArray.Length + 1];
            for (int i = 0; i < genericArray.Length + 1; i++)
            {
                    while (i < index)
                    {
                        tempArray[i] = genericArray[i];
                        i++;
                    }
                    if (i == index)
                    {
                        tempArray[index] = element;
                        i++;
                    }
                    tempArray[i] = genericArray[i - 1];
            }
            genericArray = tempArray;
    }

    public void ClearList()
    {
        genericArray = new T[genericArray.Length];
    }

    public int? ElementByValue(T value)
    {
        int? index = null;
        for (int i = 0; i < genericArray.Length; i++)
        {
            if (genericArray[i].Equals(value))
            {
                index = i;
                break;              
            }
        }
        return index;
    }

    public T GetMin()
    {
        T minValue = genericArray[0];

        for (int i = 0; i < position; i++)
        {
            if ((dynamic)minValue > (dynamic)genericArray[i])
            {
                minValue = genericArray[i];
            }
        }

        return minValue;
    }

    public T GetMax()
    {
        T maxValue = genericArray[0];

        for (int i = 0; i < position; i++)
        {
            if ((dynamic)maxValue < (dynamic)genericArray[i])
            {
                maxValue = genericArray[i];
            }
        }

        return maxValue;
    }
    public override string ToString()
    {
        StringBuilder printText = new StringBuilder();
        foreach (var item in genericArray)
        {
            printText.AppendFormat("{0} ", item);
        }
        return printText.ToString().Trim();
    }

}

