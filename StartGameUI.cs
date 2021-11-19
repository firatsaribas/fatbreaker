using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using PathCreation;

public class StartGameUI : MonoBehaviour
{
    

    public GameObject reTryer ;
    public GameObject nextLevel;
    
    
    public void RetryUI()
    {
        reTryer.SetActive(true);
    }
    //public void StartThisLevel()
    //{
    //    LevelStarter.SetActive(false);
    //}
    public void ShowNextLevelUI()
    {
        nextLevel.SetActive(true);
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
