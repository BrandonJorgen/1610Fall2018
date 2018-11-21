using UnityEngine;
using UnityEngine.Events;


public class ValueCheckAndEvent : MonoBehaviour
{
    public UnityEvent TriggerEnterNegativeValueCheck;
    public FloatData Value;

    private void OnTriggerEnter()
    {
        if (Value.Value <= 0.9)
        {
            TriggerEnterNegativeValueCheck.Invoke();
        }
    }
}