using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class children : MonoBehaviour
{
    public GameObject gamme;
    public Material material;
    
    GameObject chi;
    public GameObject giru;
    
    // Start is called before the first frame update
    void Start()
    {
        chi=gamme.transform.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        chi.GetComponent<Renderer>().material = material;
        chi.tag = "friendly";
        GameManager.unityGameObjects.Add(chi);
        //gi =(GameObject)Instantiate(giru,chi.transform.position+new Vector3(0,1,0), Quaternion.identity);
        //gi.SetActive(false);
    }
}

    

        
