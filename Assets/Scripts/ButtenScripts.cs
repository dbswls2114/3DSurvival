using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtenScripts : MonoBehaviour
{
    //UnityEvent startButton;
    Button startButton;
    
    private void Awake()
    {
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(GoMainScene);
    }


    public void GoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
