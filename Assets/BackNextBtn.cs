using UnityEngine;
using System;
using UnityEngine.UI;
using System.Threading;

public class BackNextBtn : MonoBehaviour
{
    public Button back;
    public Button next;
    private String[] sections = new String[7] {
        "Welcome",
        "Overhead",
        "Controls",
        "Errands",
        "Training",
        "Scoring",
        "Welcome"
    };
    private int[] maxScene = new int[7] {
        0, 6, 4, 1, 1, 4, 0
    };

    // Start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(NextScene);
        back.onClick.AddListener(PrevScene);
    }

    void NextScene()
    {
        String currScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        int currSceneNo = Int32.Parse(currScene.Substring(currScene.Length - 1));
        currSceneNo += 1;
        String currSceneName = currScene.Substring(0, currScene.Length - 1);
        String nextSceneName = currSceneName + currSceneNo;
        int buildIndex = UnityEngine.SceneManagement.SceneUtility.GetBuildIndexByScenePath(nextSceneName);
        if (buildIndex >= 0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        } else {
            int currStringIdx = Array.IndexOf(sections, currSceneName);
            if (currStringIdx < sections.Length - 1) {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sections[currStringIdx + 1] + "0");
            }

        }
    }

    void PrevScene()
    {
        String currScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
        int currSceneNo = Int32.Parse(currScene.Substring(currScene.Length - 1));
        currSceneNo -= 1;
        String currSceneName = currScene.Substring(0, currScene.Length - 1);
        String prevSceneName = currSceneName + currSceneNo;
        int buildIndex = UnityEngine.SceneManagement.SceneUtility.GetBuildIndexByScenePath(prevSceneName);
        if (buildIndex >= 0) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(prevSceneName);
        } else {
            int currStringIdx = Array.IndexOf(sections, currSceneName);
            if (currStringIdx > 0) {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sections[currStringIdx - 1] + maxScene[currStringIdx - 1]);
            }

        }
    }

}
