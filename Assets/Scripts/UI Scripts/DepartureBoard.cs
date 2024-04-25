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
<<<<<<< HEAD
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 + 200), 0.5f).setEaseOutCubic();
=======
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 + 200), 1).setEaseOutCubic();
        src.clip = clip1;
        src.Play();
>>>>>>> 849d60138368627f709edeab8f7c68454437cbc9
	}
	
	void OnMouseExit()
	{
<<<<<<< HEAD
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 - 150), 0.5f).setEaseOutCubic();
=======
		transform.LeanMoveLocal(new Vector2(-Screen.width / 2 + 175, -Screen.height / 2 - 150), 1).setEaseOutCubic();
        src.clip = clip2;
        src.Play();
>>>>>>> 849d60138368627f709edeab8f7c68454437cbc9
	}
}
