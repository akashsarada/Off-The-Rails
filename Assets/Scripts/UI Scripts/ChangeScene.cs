using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ChangeScene : MonoBehaviour
{
	public int scene;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void ButtonPressed()
	{
        GameObject obj = GameObject.Find("Audio Source");
        if (obj == null)
        {
            obj = new GameObject("Audio Source", typeof(AudioSource));
        }
        DontDestroyOnLoad(obj);
        AudioSource source = obj.AddComponent<AudioSource>();
        source.PlayOneShot(Resources.Load<AudioClip>("shutter"));

		SceneManager.LoadScene(scene);
	}
}
