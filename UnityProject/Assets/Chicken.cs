using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour {

    //public void SetBool(string name, bool value);
    //public void SetTrigger(string name);

    Animator Chicken_Anime;
    bool 跑步開關;

    // Use this for initialization
    void Start ()
    {
       Chicken_Anime = gameObject.GetComponent<Animator>();
        跑步開關 = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Chicken_Anime.SetTrigger("吃飯觸發器");
        }
        if (Input.GetKey(KeyCode.R))
        {
            Chicken_Anime.SetBool("跑步開關", true);
        }
        else
        {
            Chicken_Anime.SetBool("跑步開關", false);
        }
    }
}
