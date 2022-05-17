using UnityEngine;
using System;
using UnityEngine.UI;

public class StartTut : MonoBehaviour
{
    public Button begin;

    void Start()
    {
        begin.onClick.AddListener(StartTutorial);
    }

    // Update is called once per frame
    void StartTutorial()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelectSection");
    }
}
