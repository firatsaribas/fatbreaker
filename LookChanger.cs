using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookChanger : MonoBehaviour
{
    public GameObject shpere1;
    public GameObject shpere2;
    public GameObject shpere3;
    public void LookChange(int i)
    {
        if (i==1)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(false);
            shpere3.SetActive(false);
        }
        if (i == 2)
        {
            shpere1.SetActive(true);
            shpere2.SetActive(false);
            shpere3.SetActive(false);
        }
        if (i == 3)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(true);
            shpere3.SetActive(false);
        }
        if (i == 4)
        {
            shpere1.SetActive(false);
            shpere2.SetActive(false);
            shpere3.SetActive(true);
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
