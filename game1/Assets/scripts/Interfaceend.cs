using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interfaceend : MonoBehaviour
{
    public Text collect;
    public Text Highscore;
    // Start is called before the first frame update
    void Start()
    {
        Highscore.text="High Score: "+ PlayerPrefs.GetInt("HighScore", 0).ToString();
        GameManager.spee = 0.05f;
        GameManager.added = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        collect.text = "Cleared: " + GameManager.scorecollected;
      if (GameManager.scorecollected>=PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", GameManager.scorecollected);
            Highscore.text ="High Score: " + ((GameManager.scorecollected).ToString());
        }
        GameManager.unityGameObjects.Clear();
        GameManager.coun=0;
    }
}
      
