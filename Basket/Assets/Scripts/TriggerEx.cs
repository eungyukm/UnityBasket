using UnityEngine;

// Item Contoller
public class TriggerEx : MonoBehaviour
{
    public GameManager gameManager;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter Called!!");
        if (other.tag == "Apple")
        {
            Debug.Log("Tage is Apple");
            gameManager.appleCatchCount++;
        }

        if (other.tag == "Plane")
        {
            gameManager.appleMissCount++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CollisionEnter Called!!");
    }
}
