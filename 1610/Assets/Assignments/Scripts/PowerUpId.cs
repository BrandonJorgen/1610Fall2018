using UnityEngine;

[CreateAssetMenu]
public class PowerUpId : ScriptableObject
{
    public string PowerUpTag;
    public bool CorrectPowerUp;

    public void PowerUpCheck(Collider powerUp)
    {       
        if (powerUp.CompareTag(PowerUpTag))
        {
            CorrectPowerUp = true;
            Debug.Log("Found the correct power up!");
        }
        else
        {
            CorrectPowerUp = false;
            Debug.Log("Not the correct power up.");
        }
        
    }

    public void ScaleChange(Collider player)
    {
        if (CorrectPowerUp == true)
        {
            player.transform.localScale += new Vector3(3.0f, 0, 3.0f);
        }
    }
    
}
