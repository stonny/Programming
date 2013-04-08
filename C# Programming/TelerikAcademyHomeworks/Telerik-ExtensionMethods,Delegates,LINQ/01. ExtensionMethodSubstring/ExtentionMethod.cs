using System;
using System.Text;

public static class Extensions
{
    public static StringBuilder Substring(this StringBuilder input, int index, int lenght)
    {
        StringBuilder result = new StringBuilder();
        if ((input.Length <= index) || (index < 0) || (lenght > input.Length - index) || (input.Length > index))
        {
            throw new ArgumentOutOfRangeException("Out of range!");
        }
        else
        {
            for (int i = index; i < index + lenght; i++)
            {
                result.Append(input[i]);
            }
        }
        return result;
    }

}

