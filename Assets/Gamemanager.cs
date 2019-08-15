using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {
	
	
	public GameObject sol;
	public float  horaDay;
	public bool day = true;
	
	
	public IEnumerator nocheRutine(float waitTime)
    {	
		//TODO LO QUE SE HABILITA EN LA NOCHE AQUI
		
        
        
        yield return new WaitForSeconds(waitTime);
        day= true;
       sol.transform.position = new Vector3(257,7,531);
        sol.GetComponent<Light>().enabled = true;
        
    }
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
			horaDay =horaDay+0.0001f;
			Vector3 solfactor = new Vector3();
			
			if (horaDay > 0.2592024f){
				sol.GetComponent<Light>().enabled = false;
					horaDay = 0f;
					day=false;
					
					StartCoroutine(nocheRutine(10f));
					
			}
			
			
			if (horaDay < 0.1625f) {
				
				 solfactor = new Vector3(0,horaDay,-2f*horaDay );
				sol.transform.position =  sol.transform.position + solfactor;
			
			}else {
				
				if (horaDay > 0.2324034) {
					solfactor = new Vector3(0,-0.6f*horaDay,-2.9f*horaDay );
				sol.transform.position =  sol.transform.position + solfactor;
					}else {
						solfactor = new Vector3(0,-0.7f*horaDay,-2.5f*horaDay );
				sol.transform.position =  sol.transform.position + solfactor;
						
						}
				 
			}
		
			
			//Vector3 solfactor = new Vector3(0,horaDay,-2*horaDay );
		
			 ; //= Vector3.Slerp(transform.position,newpocam,factor);
			
		
		
		Vector3 correc = new Vector3(250f,0,250f);
		sol.transform.LookAt(correc);
		
		
		
	}
}
