using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

#region 2 �������� �������
//public class MyList
//{
//    private int[] m_array;
//    public int Count { get; private set; }
//
//    public int Capacity
//    {
//        get { return m_array.Length; }
//        set
//        {
//            if (value > m_array.Length)
//            {
//                System.Array.Resize(ref m_array, value);
//            }
//        }
//    }
//
//    public MyList()
//    {
//        m_array = new int[4];
//    }
//
//    public MyList(int capacity)
//    {
//        m_array = new int[capacity];
//    }
//
//    public int this[int index]
//    {
//        get
//        {
//            CheckIndexRange(index);
//            return m_array[index];
//        }
//        set
//        {
//            CheckIndexRange(index);
//            m_array[index] = value;
//        }
//    }
//
//    private bool CheckIndexRange(int index)
//    {
//        if (index < 0 || index >= Count)
//            throw new ArgumentOutOfRangeException();
//
//        return true;
//    }
//
//    private void IncreaseCapacityIfNeed()
//    {
//        if (Count == Capacity)
//        {
//            Capacity *= 2;
//        }
//    }
//
//    public void Add(int item)
//    {
//        IncreaseCapacityIfNeed();
//
//        m_array[Count] = item;
//        Count++;
//    }
//
//    public void Insert(int index, int item)
//    {
//        if (index < 0 || index > Count)
//        {
//            throw new ArgumentOutOfRangeException();
//        }
//
//        IncreaseCapacityIfNeed();
//
//        if (index < Count)
//        {
//            System.Array.Copy(m_array, index, m_array, index + 1, Count - index);
//        }
//
//        Count++;
//        m_array[index] = item;
//    }
//
//    public int IndexOf(int item)
//    {
//        for (int i = 0; i < Count; i++)
//        {
//            if (m_array[i] == item)
//            {
//                return i;
//            }
//        }
//
//        return -1;
//    }
//
//    public bool Remove(int item)
//    {
//        int index = IndexOf(item);
//        if (index >= 0)
//        {
//            RemoveAt(index);
//            return true;
//        }
//
//        return false;
//    }
//
//    public void RemoveAt(int index)
//    {
//        CheckIndexRange(index);
//        Count--;
//        if (index < Count)
//        {
//            System.Array.Copy(m_array, index + 1, m_array, index, Count - index);
//        }
//    }
//
//    public bool Contains(int item)
//    {
//        return IndexOf(item) >= 0;
//    }
//
//    public void Clear()
//    {
//        System.Array.Clear(m_array, 0, m_array.Length);
//        Count = 0;
//    }
//}
#endregion

public class MyList<T>
{
    private T[] m_array;
    public int Count { get; private set; }

    public int Capacity
    {
        get { return m_array.Length; }
        set
        {
            if (value > m_array.Length)
            {
                System.Array.Resize(ref m_array, value);
            }
        }
    }

    public MyList()
    {
        m_array = new T[4];
    }

    public MyList(int capacity)
    {
        m_array = new T[capacity];
    }

    public T this[int index]
    {
        get
        {
            CheckIndexRange(index);
            return m_array[index];
        }
        set
        {
            CheckIndexRange(index);
            m_array[index] = value;
        }
    }

    private bool CheckIndexRange(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException();

        return true;
    }

    private void IncreaseCapacityIfNeed()
    {
        if (Count == Capacity)
        {
            Capacity *= 2;
        }
    }

    public void Add(T item)
    {
        IncreaseCapacityIfNeed();

        m_array[Count] = item;
        Count++;
    }

    public void Insert(int index, T item)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException();
        }

        IncreaseCapacityIfNeed();

        if (index < Count)
        {
            System.Array.Copy(m_array, index, m_array, index + 1, Count - index);
        }

        Count++;
        m_array[index] = item;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            if (m_array[i].Equals(item))
            {
                return i;
            }
        }

        return -1;
    }

    public bool Remove(T item)
    {
        int index = IndexOf(item);
        if (index >= 0)
        {
            if (m_array[i] == item)
            {
                m_array[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    remove[j] = m_array[j];
                }
                
                for (int j = i + 1; j < m_array.Length; j++)
                    remove[j - 1] = m_array[j];

                m_array = remove;
                c--;
                break;
            }
        }

        return false;
    }

    public void RemoveAt(int index)
    {
        CheckIndexRange(index);
        Count--;
        if (index < Count)
        {
            System.Array.Copy(m_array, index + 1, m_array, index, Count - index);
        }
    }

    public bool Contains(T item)
    {
        return IndexOf(item) >= 0;
    }

    public void Clear()
    {
        System.Array.Clear(m_array, 0, m_array.Length);
        Count = 0;
    }
}

public class HomeWork : MonoBehaviour
{
    public void Start()
    {
        #region 2 �������� �������
        // MyList myList = new MyList();
        // myList.Add(1);
        // myList.Add(5);
        // myList.Add(UnityEngine.Random.Range(1, 10));
        // myList.Add(UnityEngine.Random.Range(1, 10));
        // myList.Add(UnityEngine.Random.Range(1, 10));
        // UnityEngine.Debug.Log("�������� � ������ 5 ����������");
        // UnityEngine.Debug.Log($" m_array.Length = {myList.Count} And Capacity = " + myList.Capacity);
        // UnityEngine.Debug.Log(" ");
        // myList.Insert(1, 3);
        // myList.Remove(3);
        // myList.RemoveAt(0);
        // UnityEngine.Debug.Log("������� �� ������� 2 ���������");
        // UnityEngine.Debug.Log($" m_array.Length ={myList.Count} And Capacity = " + myList.Capacity);
        // UnityEngine.Debug.Log(" ");
        //
        // UnityEngine.Debug.Log("Count = " + myList.Count);
        //
        // for (int i = 0; i < myList.Count; ++i)
        // {
        //     UnityEngine.Debug.Log($"index {i}, item = " + myList[i]);
        // }
        //
        // myList.Clear();
        // UnityEngine.Debug.Log(" ");
        // UnityEngine.Debug.Log("Clear test");
        // for (int i = 0; i < myList.Count; ++i)
        // {
        //     UnityEngine.Debug.Log($"index {i}, item = " + myList[i]);
        // }
        #endregion





        MyList<MyClass> originalList = new MyList<MyClass>();

        // �������� ����� ��� ��������� ����
        Stopwatch originalStopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            originalList.Add(new MyClass());
        }
        originalList.RemoveAt(350);
        originalList.IndexOf(new MyClass());
        originalStopwatch.Stop();
        UnityEngine.Debug.Log("Original Code Elapsed Time: " + originalStopwatch.ElapsedMilliseconds);


        List<MyClass> genericList = new List<MyClass>();
        // �������� ����� ��� ���� � �����������
        Stopwatch genericStopwatch = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++)
        {
            genericList.Add(new MyClass());
        }
        genericList.RemoveAt(350);
        genericList.IndexOf(new MyClass());
        genericStopwatch.Stop();
        UnityEngine.Debug.Log("Generic Code Elapsed Time: " + genericStopwatch.ElapsedMilliseconds);
    }

}
