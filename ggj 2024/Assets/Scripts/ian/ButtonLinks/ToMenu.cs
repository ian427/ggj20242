using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource click;
    //private bool canSwitch = false;
    public void OnButtonPress()
    {
        // click.Play();

        // canSwitch = true;
        SceneManager.LoadScene("MainMenu");
        // Debug.Log("click");
    }
    /* private void Update()
     {

         if (!click.isPlaying && canSwitch)//defults true
         {
             //Debug.Log("switch");

         }
     }*/
}
