using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class wall : MonoBehaviour {
	
	Animator animator;
	CharacterController controlador;
	public int recargas = 3; 
	public int vida=500;
	public Text textoCargas;
	public Text textoVida;
	public float velocidadRotacion = 240.0f;
	public void iniciarataqueEvent(){
		
		 animator.SetBool("estaatacando",true);
		//Debug.Log("inicia");
	}
	
	
	public void estaatacandoEvent(){
		
		animator.SetBool("estaatacando",false);
		//Debug.Log("termina");
	}
	
	
	
	public IEnumerator PowerUpWearOff(float waitTime)
    {
        //PlayerShooting.timeBetweenBullets -= RFBoostValue; // add boost
        animator.SetFloat("Speed",2.5f);
        textoCargas.text = recargas.ToString();
        yield return new WaitForSeconds(waitTime);
        recargas = recargas -1; 
       
        animator.SetFloat("Speed",1);
        //PlayerShooting.timeBetweenBullets += RFBoostValue; // remove boost
        //isActive = false;
    }
	
	
	public void SpeedMax(){
		
		if (recargas>0) {
			StartCoroutine(PowerUpWearOff(5f));
		
		}
	}
	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator>();//need this...
		controlador = GetComponent<CharacterController>();
		textoCargas = GameObject.Find("Canvas/cargas").GetComponent<Text>();
		textoCargas.text = recargas.ToString();
		
		textoVida = GameObject.Find("Canvas/textvida").GetComponent<Text>();
		textoVida.text = vida.ToString();
		
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
		textoCargas.text = recargas.ToString();
		if (vida>=0) {
			
				textoVida.text = vida.ToString();
			
			}else {
				
				textoVida.text = "0";
				
				}
		
		
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
		
		if (vida <=0){
						
							animator.SetTrigger("Memori");
							animator.SetBool("Muerto",true);
							
							 Application.Quit();
							
							
		}
		
		if (Input.GetMouseButtonDown(1)) {
				animator.SetTrigger("atacar");
				
				
		}
		
		
		
		
	}
}
