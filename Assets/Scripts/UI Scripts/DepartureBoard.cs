using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepartureBoard : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip1, clip2;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnMouseEnter()
	{
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 + 200), 0.5f).setEaseOutCubic();
        src.clip = clip1;
        src.Play();
	}
	
	void OnMouseExit()
	{
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 - 150), 0.5f).setEaseOutCubic();
        src.clip = clip2;
        src.Play();
	}
}
