using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBreaker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" || other.tag =="subPlayer")
        {
            //Rigidbody tempRigid = other.gameObject.GetComponent<Rigidbody>();
            //tempRigid.AddForce(Vector3.back * 5000f);
            //tempRigid.angularVelocity = Vector3.left;
            Destroy(other.gameObject);
            FindObjectOfType<StartGameUI>().RetryUI();
        }
        if(other.tag == "subPlayer")
        {
            FindObjectOfType<HealthCount>().playerHealth--;
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
