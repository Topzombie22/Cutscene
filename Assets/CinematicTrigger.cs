using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CinematicTrigger : MonoBehaviour
{
    public PlayableDirector director;
    public GameObject player;
    public GameObject trigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            director.Play();
            player.GetComponent<Controller>().enabled = false;
            trigger.SetActive(false);
        }
    }
}
