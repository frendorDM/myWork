using System;

namespace DataStructure
{
  public class ArrayList
  {
    public int CurrentLenght { get; private set; }
    private int[] _array;
    private int _lenght
    {
      get
      {
        return _array.Length;
      }
    }
    public ArrayList()
    {
      _array = new int[9];
      CurrentLenght = 0;
    }

    public void Add(int value)
    {
      if (_lenght == CurrentLenght)
      {
        IncreaseLenght();
      }
      _array[CurrentLenght] = value;
      CurrentLenght++;
    }
    public void AddFirst(int value)
    {
      if (_lenght == CurrentLenght)
      {
        IncreaseLenght();
      }
      for (int i = _lenght+1; i >= 0; i--)
      {
        _array[i + 1] = _array[i];
      }
      _array[0] = value;
      CurrentLenght++;
    }
    public void AddByIndex(int value, int index)
    {
      int requiredIndex=0;
      if (_lenght == CurrentLenght)
      {
        IncreaseLenght();
      }
      for (int i = 0; i < _lenght; i++)
      {
        if (i==index)
        {
          requiredIndex = i;
        }
      }
      for (int i = _lenght + 1; i == requiredIndex; i--)
      {
        _array[i + 1] = _array[i];
      }
      _array[requiredIndex] = value;
      CurrentLenght++;
    }
    private void IncreaseLenght(int number = 1)
    {
      int newLenght = _lenght;
      while (newLenght <= CurrentLenght + number)
      {
        newLenght = (int)(newLenght * 1.33 + 1);
      }

      int[] newArray = new int[newLenght];
      Array.Copy(_array, newArray, _lenght);

      _array = newArray;
    }
    private void ShiftElements()
    {
      for (int i = 0; i <= _lenght; i++)
      {
        _array[i + 1] = _array[i];
      }
    }

    public override bool Equals(object obj)
    {
      ArrayList arrayList = (ArrayList)obj;
      if (CurrentLenght != arrayList.CurrentLenght)
      {
        return false;
      }
      else
      {
        for (int i = 0; i < CurrentLenght; i++)
        {
          if (_array[i] != arrayList._array[i])
          {
            return false;
          }
        }
        return true;
      }

    }
    
  }
}
