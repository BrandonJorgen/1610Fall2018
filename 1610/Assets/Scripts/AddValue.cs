using System;
using UnityEngine;

[CreateAssetMenu]
public class AddValue : ScriptableObject
{
    public FloatData Data;

    public void AddValueToObj(FloatData data)
    {
        data.Value += Data.Value;
        Console.WriteLine("Added To Value");
    }

    public void MinusValueToObj(FloatData data)
    {
        data.Value -= Data.Value;
    }

    public void MultiplyValueToObj(FloatData data)
    {
        data.Value *= Data.Value;
    }

    public void DivideValueToObj(FloatData data)
    {
        data.Value /= Data.Value;
    }
}
