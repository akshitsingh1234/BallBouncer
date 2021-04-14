using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interface : MonoBehaviour
{
    public Text collect;
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.scorecollected = 0;
        highscore.text = "Previous HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        collect.text = "Cleared: " + GameManager.scorecollected;
        highscore.text = "Previous HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();

    }
}
