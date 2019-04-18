using UnityEngine;
using UnityEngine.Events;


public class ValueCheckAndEvent : MonoBehaviour
{
    public UnityEvent TriggerEnterNegativeValueCheck, TriggerEnterPositiveValueCheck, TriggerExit, OnStart;
    public FloatData Value;

    private void Start()
    {
        OnStart.Invoke();
    }

    private void OnTriggerEnter()
    {
        if (Value.Value <= 0.9)
        {
            TriggerEnterNegativeValueCheck.Invoke();
        }

        if (Value.Value >= 1)
        {
            TriggerEnterPositiveValueCheck.Invoke();
            Debug.Log("Value is reported as greater than or equal to 1");
        }
    }

    private void OnTriggerExit()
    {
        TriggerExit.Invoke();
        Debug.Log("You have left the trigger zone");
    }
}