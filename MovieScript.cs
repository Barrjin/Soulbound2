using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]

public class MovieScript : MonoBehaviour {

    public MovieTexture movie;
    private AudioSource movieAudio;

	void Start ()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        movieAudio = GetComponent<AudioSource>();
        movieAudio.clip = movie.audioClip;
        movie.Play();
        movieAudio.Play();
  
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space) && movie.isPlaying)
        {

            movie.Pause();
        }

        else if (Input.GetKeyDown(KeyCode.Space) && !movie.isPlaying)
        {

            movie.Play();
        }
    }
}
