using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtsacleRotation : MonoBehaviour
{
    public float turnSpeed;
    private void TurnAround()
    {
        gameObject.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.Self);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnAround();
    }
}
