using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2022.1.29
/// </summary>

public class Testing : MonoBehaviour
{
    public delegate void TestDelegate();

    private TestDelegate testDelegateFunction;

    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();

        TestingInterface(myClass);

        //--
        testDelegateFunction = MyTestDelegateFunction;
    }

    private void MyTestDelegateFunction() { }

    private void TestingInterface(MyInterface myInterface)
    {
        myInterface.Greeting();
    }
}
public class MyClass : MyInterface
{
    public void Greeting()
    {
        Debug.Log("yoo");
    }
}

public interface MyInterface
{
    void Greeting();
}
