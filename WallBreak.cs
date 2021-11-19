using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public GameObject breakbaleWall;
    private void OnTriggerEnter(Collider other)
    {
        int temphealth = FindObjectOfType<HealthCount>().playerHealth;
        if(other.tag == "Player" || other.tag == "subPlayer")
        {
            if (temphealth >= 4)
            {
                
                GameObject tempWall = Instantiate(breakbaleWall, gameObject.transform.position, gameObject.transform.rotation);
                Destroy(gameObject);


            }
            if (temphealth < 4)
            {
                //Rigidbody tempRigid = other.gameObject.GetComponent<Rigidbody>();
                //tempRigid.AddForce(Vector3.back * 5000f);
                //tempRigid.angularVelocity = Vector3.left;
                Destroy(other.gameObject);
                FindObjectOfType<StartGameUI>().RetryUI();
            }
            FindObjectOfType<HealthCount>().playerHealth = 1;
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
