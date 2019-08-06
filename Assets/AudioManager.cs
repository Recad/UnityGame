using UnityEngine.Audio;
using UnityEngine;
using System;
public class AudioManager : MonoBehaviour {

	public Sound[] sonidos;
	
	public static AudioManager instance;

	// Use this for initialization
	void Awake () {
		
		if (instance == null){
			
			instance = null;
		
		}else {
				Destroy(gameObject);
				return;
			
		}
		
		DontDestroyOnLoad(gameObject);
		
		foreach (Sound s in sonidos){
				
				s.source = gameObject.AddComponent<AudioSource>();
				s.source.clip = s.clip;
				
				s.source.volume = s.volume;
				s.source.pitch = s.pitch;
				s.source.loop = s.loop;
			}
	}
	
	void Start(){
		
		Play("theme");
	}
	
	
	public void Play (string nombre) {
		
		Sound s = Array.Find(sonidos, sound => sound.nombre == nombre);
		
		if (s == null)
			return;
		s.source.Play();
		
	}
}
