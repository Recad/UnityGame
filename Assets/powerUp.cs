using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour {
	
	public GameObject efecto;

	void OnTriggerEnter(Collider other){
		 if (other.CompareTag("Player")){
			 
			 
			 //Debug.Log(other.GetComponent<recargas>());
				Pickup(other);
			 
			 }
			
	}
	
	
	
	 void Pickup(Collider player){
		 
		if (gameObject.CompareTag("vida")){
			
			Instantiate(efecto,transform.position, transform.rotation);
		 player.GetComponent<wall>().vida = 
		 player.GetComponent<wall>().vida + 50 ;
		 
		 //player.GetComponent<wall>().textoCargas.text = player.GetComponent<wall>().recargas.ToString();
		
		}else {
			
				Instantiate(efecto,transform.position, transform.rotation);
		 player.GetComponent<wall>().recargas = 
		 player.GetComponent<wall>().recargas + 1 ;
		 
		 player.GetComponent<wall>().textoCargas.text = player.GetComponent<wall>().recargas.ToString();
		
		
		
		}
		 
		 
		 
		 Destroy(gameObject);
		 
		 }
	
	
}
