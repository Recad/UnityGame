using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class wall : MonoBehaviour {
	
	Animator animator;
	CharacterController controlador;
	
	
	public float velocidadRotacion = 240.0f;
	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator>();//need this...
		controlador = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		bool walking = Input.GetKey(KeyCode.W);
		bool reversa = Input.GetKey(KeyCode.S);
		bool runing = Input.GetKey(KeyCode.LeftAlt);
		
		//float Horizontal = Input.GetAxis("Horizontal");
		//float Vertical  = Input.GetAxis("Vertical");
		
		
		 
		animator.SetBool("corre",runing);
		animator.SetBool("walking",walking);
		animator.SetBool("reverse",reversa);
		
		/*if (Vertical < 0) {
			Vertical = 0;
		}*/
		
		
		//Quaternion CamRotAngulo = Quaternion.AngleAxis(Horizontal*velocidadRotacion,Vector3.up);
		//Vector3 newpo = cameraTransform.transform.position + (CamRotAngulo * cameraTransform.transform.position);
		//Vector3 correc = new Vector3(-1,0,-1);
		//transform.Rotate(0,Horizontal*velocidadRotacion*Time.deltaTime,0);
		
		//Vector3 correc = new Vector3(0,1.4f,0);
				//transform.Rotate(10,0,0);
		//cameraTransform.LookAt(transform.position + correc);
		
		//Vector3 correc2 = new Vector3(transform.position.x,transform.position.y,transform.position.z);
		
		//cameraTransform.Translate(0,0,0);
		//cameraTransform.Translate(Vector3.right * Horizontal*50.0f*Time.deltaTime);
		//cameraTransform.transform.TransformDirection(Vector3.up);
		//cameraTransform.RotateAround(correc2,Vector3.up,Horizontal*velocidadRotacion*Time.deltaTime);
		//cameraTransform.transform.Translate(-Horizontal*100.0f*Time.deltaTime, 0, 0, Space.World);
		//Vector3 correc = new Vector3(0,1.4f,0);
				//transform.Rotate(10,0,0);
		//cameraTransform.transform.LookAt(transform.position);
		
		/*if (controlador.isGrounded){
				
		}*/
		
		if (Input.GetMouseButtonDown(1)) {
				animator.SetTrigger("atacar");
		}
		
	}
}
