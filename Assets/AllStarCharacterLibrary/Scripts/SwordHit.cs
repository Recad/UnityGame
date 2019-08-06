using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordHit : MonoBehaviour {
	
	
	public GameObject maestro;
	//public CharacterController controlador;
	//public Animator animator;
	
	public int damage = 50;
	
	
	//animator = maestro.GetComponent<Animator>();//need this...
	//controlador = maestro.GetComponent<CharacterController>();
	
	
	
	void OnTriggerEnter(Collider other){
			//Debug.Log("duele");
			//Debug.Log(animator.GetTrigger("atacar"));
			if (maestro.GetComponent<Animator>().GetBool("estaatacando") && other.tag == "Enemy"){
					
					other.GetComponent<Enemy>().life = other.GetComponent<Enemy>().life - damage ;
					
					int vidares = other.GetComponent<Enemy>().life;
					
					if (vidares <=0){
						
							other.GetComponent<Animator>().SetBool("Muerto",true);
							
							Destroy(other);
						}
					
					
				
			}
	}
	
	
	
	
}
