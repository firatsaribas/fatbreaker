using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCount : MonoBehaviour
{
    public int playerHealth;
    private void HealthCheck()
    {
        if (playerHealth == 1)
        {
            FindObjectOfType<LookChanger>().LookChange(1);
        }
        if (playerHealth == 2)
        {
            FindObjectOfType<LookChanger>().LookChange(2);
        }
        if (playerHealth == 3)
        {
            FindObjectOfType<LookChanger>().LookChange(3);
        }
        if (playerHealth == 4)
        {
            FindObjectOfType<LookChanger>().LookChange(4);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthCheck();
    }
}
