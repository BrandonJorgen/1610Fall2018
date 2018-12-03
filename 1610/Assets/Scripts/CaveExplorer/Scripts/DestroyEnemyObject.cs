using UnityEngine;

public class DestroyEnemyObject : MonoBehaviour
{
    public FloatData Value;
    public string TagName;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == TagName)
        {
            Destroy(other.gameObject);
            Value.Value += 1;
        }
    }
}