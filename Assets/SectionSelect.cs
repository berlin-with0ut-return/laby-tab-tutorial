using UnityEngine;
using System;
using System.Text.RegularExpressions;
using UnityEngine.UI;

public class SectionSelect : MonoBehaviour
{
    public Button overhead, controls, errands, training, scoring, next;

    // Start is called before the first frame update
    void Start()
    {
        overhead.onClick.AddListener(GoToOverhead);
        controls.onClick.AddListener(GoToControls);
        errands.onClick.AddListener(GoToErrands);
        training.onClick.AddListener(GoToTraining);
        scoring.onClick.AddListener(GoToScoring);
        next.onClick.AddListener(GoToOverhead);
    }

    void GoToOverhead() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Overhead0");
    }

    void GoToControls() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Controls0");
    }

    void GoToErrands() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Errands0");
    }

    void GoToTraining() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Training0");
    }

    void GoToScoring() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Scoring0");
    }
}
