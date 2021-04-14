using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionGameObjectExample : MonoBehaviour
{
    public bool isjump;
     
    void Start()
    {
        isjump = false;
    }

    void OnCollisionEnter(Collision collision)
    {

        if (gameObject.tag != "friendly")
        {
            SceneManager.LoadScene("lostscene");
        }
        else if ((gameObject.tag == "friendly") && (gameObject.name != "Plane"))
        {
            if (isjump == false)
            {
                GameManager.scorecollected=GameManager.scorecollected+GameManager.added;
                GameManager.coun++;
                isjump = true;
            }

        }
    }

        
    
}
