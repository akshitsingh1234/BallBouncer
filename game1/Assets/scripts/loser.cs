using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loser: MonoBehaviour
{
    public void ChangeSceneother(string sceneName)
    {
        SceneManager.LoadScene("SampleScene");
        GameManager.scorecollected = 0;
    }
}
