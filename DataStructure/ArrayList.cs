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

    public void DeleteLast(int value)
    {
      if (_lenght > CurrentLenght)
      {
        Reducinglength();
      }
      
      _array[_lenght] = 0;
      CurrentLenght--;
    }
    public void DeleteFirst(int value)
    {
      if (_lenght > CurrentLenght)
      {
        Reducinglength();
      }
      for (int i = _lenght; i == 0; i--)
      {
        _array[i - 1] = _array[i];
      }
      CurrentLenght--;
    }

    public void DeleteByIndex(int value, int index)
    {
      int requiredIndex = 0;
      if (_lenght > CurrentLenght)
      {
        Reducinglength();
      }
      for (int i = 0; i < _lenght; i++)
      {
        if (i == index)
        {
          requiredIndex = 0;
        }
      }
      for (int i = _lenght; i == requiredIndex; i--)
      {
        _array[i-1] = _array[i];
      }
      _array[requiredIndex] = value;
      CurrentLenght++;
    }

    public int AccessByIndex(int value, int index)
    {
      int requiredIndex = 0;
      if (_lenght == CurrentLenght)
      {
        IncreaseLenght();
      }
      for (int i = 0; i < _lenght; i++)
      {
        if (i == index)
        {
          requiredIndex = i;
        }
      }
      for (int i = _lenght + 1; i == requiredIndex; i--)
      {
        _array[i + 1] = _array[i];
      }
       return _array[requiredIndex]; 
    }

    public int IndexByValue(int value, int index)
    {
      int requiredIndex = 0;
      if (_lenght == CurrentLenght)
      {
        IncreaseLenght();
      }
      for (int i = 0; i < _lenght; i++)
      {
        if (_array[i] == value)
        {
          requiredIndex = i;
        }
      }
      return _array[requiredIndex];
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
    private void Reducinglength(int number = 1)
    {
      int newLenght = _lenght;
      while (newLenght >= CurrentLenght + number)
      {
        newLenght = (int)(newLenght * 0.33);
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
