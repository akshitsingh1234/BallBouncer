using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.ComponentModel;

public class Giruspawn : MonoBehaviour
{
    public GameObject giru;
    public GameObject haal;
    public Text timerr;
    GameObject gi;
    GameObject ha;
    GameObject rotated;
    GameObject rotated2;
    public AudioClip girrrr;
    public AudioClip haaaal;
    AudioSource haaaal1;
    AudioSource girrrr1;
    public GameObject explosion;
    float fulltime;
    float tympass;
    float countdownvalue = 15.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        fulltime = countdownvalue;
        girrrr=Resources.Load<AudioClip>("giroud");
        haaaal =Resources.Load<AudioClip>("haaland");
        girrrr1 = GetComponent<AudioSource>();
        haaaal1 = GetComponent<AudioSource>();
    }




    private void OnCollisionEnter(Collision collision)
    {
            if ((collision.gameObject.tag == "friendly") && (GameManager.coun % 16== 0) && (GameManager.coun != 0))
            {   
                gi = GameManager.unityGameObjects[GameManager.coun + 1];       
            rotated = (GameObject)Instantiate(giru, gi.transform.position + new Vector3(0, 1.8f, 0), Quaternion.identity);
                rotated.transform.Rotate(-90.0f, 180.0f, 0.0f, Space.Self);
            }
            else if ((collision.gameObject.tag == "friendly") && (GameManager.coun % 22== 0) && (GameManager.coun != 0))
            {
                ha= GameManager.unityGameObjects[GameManager.coun + 1];           
               rotated2 = (GameObject)Instantiate(haal, ha.transform.position + new Vector3(0, 1.8f, 0), Quaternion.identity);
                rotated2.transform.Rotate(-90.0f, 180.0f, 0.0f, Space.Self);
            }
     }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject == rotated)
        {
            Destroy(Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity), 2.0f);
            Destroy(other.gameObject);
            girrrr1.PlayOneShot(girrrr, 0.7F);
            GameManager.spee = 0.05f;
        }
        else if (other.gameObject == rotated2)
        {
            Destroy(Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity), 2.0f);
            Destroy(other.gameObject);
            GameManager.added = 2;
            haaaal1.PlayOneShot(haaaal, 0.7F);

            while (fulltime > 0)
            {
                timerr.text = fulltime.ToString();
                yield return new WaitForSeconds(1f);
                fulltime--;
            }
            timerr.text = "";
            GameManager.added = 1;
            fulltime = 15.0f;
        }
    
    }  
   
}