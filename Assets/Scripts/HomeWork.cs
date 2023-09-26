using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyList
{

    public int c = 0;
    public int cNum = 0;
    private int[] m_array = new int[4];

    public int Count
    {
        get => c;
        private set { Count = c; }
    }

    public int Capacity
    {
        get
        {
            int num = 2;
            int step = 1;
            while (m_array.Length > (int)Math.Pow(num, step))
            {
                step++;

            }
            num = (int)Math.Pow(num, step);
            return num;
        }
        set
        {
            cNum = value;
        }
    }

    public MyList()
    {

    }

    public MyList(int capacity)
    {
        Capacity = capacity;
    }

    public int this[int index]
    {
        get
        {
            return m_array[index];
        }
        set
        {
            m_array[index] = value;
        }
    }

    public void Add(int item)
    {
        int[] add = new int[m_array.Length + 1];

        if (c < m_array.Length)
        {
            m_array[c] = item;
            c++;
        }

        else
        {
            for (int i = 0; i < m_array.Length; i++)
                add[i] = m_array[i];

            m_array = add;
            m_array[c] = item;
            c++;
        }
    }

    public void Insert(int index, int item)
    {

        m_array[index] = item;

    }

    public int IndexOf(int item)
    {
        return -1;
    }

    public bool Remove(int item)
    {
        int[] remove = new int[m_array.Length - 1];

        for (int i = 0; i < m_array.Length; i++)
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
                return true;
            }
        }
        return false;

    }

    public void RemoveAt(int index)
    {
        int[] remove = new int[m_array.Length - 1];

        for (int i = 0; i < index; i++)
            remove[i] = m_array[i];

        for (int i = index + 1; i < m_array.Length; i++)
            remove[i - 1] = m_array[i];

        m_array = remove;
        c--;

    }

    public bool Contains(int item)
    {
        return false;
    }

    public void Clear()
    {

        for (int i = 0; i < m_array.Length; i++)
        {
                m_array[i] = 0;
        }
    }
}


public class HomeWork : MonoBehaviour
{
    public void Start()
    {

        MyList myList = new MyList();
        myList.Add(1);
        myList.Add(5);
        myList.Add(UnityEngine.Random.Range(1, 10));
        myList.Add(UnityEngine.Random.Range(1, 10));
        myList.Add(UnityEngine.Random.Range(1, 10));
        Debug.Log("Добавили в массив 5 эллементов");
        Debug.Log($" m_array.Length = {myList.Count} And Capacity = " + myList.Capacity);
        Debug.Log(" ");
        myList.Insert(1, 3);
        myList.Remove(3);
        myList.RemoveAt(0);
        Debug.Log("Удалили из массива 2 эллемента");
        Debug.Log($" m_array.Length ={myList.Count} And Capacity = " + myList.Capacity);
        Debug.Log(" ");

        Debug.Log("Count = " + myList.Count);

        for (int i = 0; i < myList.Count; ++i)
        {
            Debug.Log($"index {i}, item = " + myList[i]);
        }

        myList.Clear();
        Debug.Log(" ");
        Debug.Log("Clear test");
        for (int i = 0; i < myList.Count; ++i)
        {
            Debug.Log($"index {i}, item = " + myList[i]);
        }
        
    }

}
