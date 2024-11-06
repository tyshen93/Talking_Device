using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public UiStartScene uiStartScene;
    public UiGameplay uiGameplay;

    // game start scene
   public void Init()
    {
        uiStartScene.gameObject.SetActive(true);
        uiGameplay.gameObject.SetActive(false);
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
