using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollison : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "subPlayer")
        {
            FindObjectOfType<HealthCount>().playerHealth++;
            Debug.Log(FindObjectOfType<HealthCount>().playerHealth);
            Destroy(gameObject);
        }
    }
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
