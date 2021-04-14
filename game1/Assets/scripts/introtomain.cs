using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class introtomain : MonoBehaviour
{
    public void ChangeSceneintromain(string sceneName1)
    {
        SceneManager.LoadScene("SampleScene");  
    }
}
