using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handHit : MonoBehaviour {

	public GameObject maestro;
	//public CharacterController controlador;
	//public Animator animator;
	
	public int damage = 60;
	
	
	//animator = maestro.GetComponent<Animator>();//need this...
	//controlador = maestro.GetComponent<CharacterController>();
	
	
	
	void OnTriggerEnter(Collider other){
		
			//Debug.Log(animator.GetTrigger("atacar"));
			if (other.tag == "Player"){
				FindObjectOfType<AudioManager>().Play("puno");
					//FindObjectOfType<AudioManager>().Play("muertewoman");
					other.GetComponent<wall>().vida = other.GetComponent<wall>().vida - damage ;
					
					int vidares = other.GetComponent<wall>().vida;
					
					
					
					
				
			}
	}
}
