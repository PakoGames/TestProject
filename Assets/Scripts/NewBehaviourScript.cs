using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class MyClass
{
    public int i;
    public int j;
}

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        short s = 0;
        int i = 0;
        long l = long.MaxValue;
        float f = 0;
        double d = 0;

        object o = d;
        double d2 = (double)o;

        i = (int)l;
        l = i;

        TestFunc(out i);
        Debug.Log(i);

        MyClass mc = new MyClass();

        

        var gf = mc;

        Debug.Log($"short: {short.MinValue} - {short.MaxValue}");
        Debug.Log($"int: {int.MinValue} - {int.MaxValue}");
        Debug.Log($"long: {long.MinValue} - {long.MaxValue}");
        Debug.Log($"float: {float.MinValue} - {float.MaxValue}");
        Debug.Log($"double: {double.MinValue} - {double.MaxValue}");
    }

    public void TestFunc(out int i)
    {
        i = 10;
    }

    public void TestFunc(MyClass mc)
    {

    }

}


