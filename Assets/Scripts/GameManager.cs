using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gamePlay;
    public GameObject startScene;
    public UiManager uiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        startScene.SetActive(true);
        gamePlay.SetActive(false);
        uiManager.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
