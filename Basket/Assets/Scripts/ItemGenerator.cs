using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGenerator : MonoBehaviour
{
    public GameObject applePrefab;

    public GameObject boomPrefab;

    public GameObject[] pivot;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateItem());

        // int score = gameDirector.point;
    }

    IEnumerator GenerateItem()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            int rand = Random.Range(0, 10);

            Vector3 yPos = new Vector3(0, 5, 0);
            
            Instantiate(applePrefab, pivot[rand].transform.position, Quaternion.identity );
            Instantiate(boomPrefab, pivot[rand].transform.position, Quaternion.identity);   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
