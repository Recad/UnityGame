using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour {
	
	
	public GameObject PlayerTranform;
	
	
	Animator animator;
	CharacterController controlador;
	
	private Vector3 _cameraOfsset;
	
	public bool firsperson = false;
	
	//public bool rotatemause = true;
	
	public bool apuntarPlater = false;
	public float velocidadrotar = 2.5f; 
	//public float velocidadmauserotar = 3f;
	
	public float factor = 0.5f;
	
	

	// Use this for initialization
	void Start () {
		_cameraOfsset = transform.position - PlayerTranform.transform.position;
		animator = PlayerTranform.GetComponent<Animator>();//need this...
		controlador = PlayerTranform.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		
		 bool rotaR = Input.GetKey(KeyCode.A);
		 bool rotaL = Input.GetKey(KeyCode.D);
		 bool VerR = Input.GetKey(KeyCode.E);
		 bool VerL = Input.GetKey(KeyCode.Q);
		 
		 float Horizontal = Input.GetAxis("Horizontal");
		 float Vertical  = Input.GetAxis("Vertical");
		
		
		if (Input.GetKeyDown(KeyCode.R)) {
				
				firsperson = !firsperson;
						
		}
		
		
		if (firsperson) {
			
				transform.position = PlayerTranform.transform.position+ new Vector3(0,0.85f,0.5f);
			
			
		} else {
			
			/* por ahora no lo nececito
			if (rotatemause){
				
				Quaternion CamRotAngulo = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*velocidadmauserotar,Vector3.up);
				
				_cameraOfsset = CamRotAngulo * _cameraOfsset;
			
			
			}*/
			if (Vertical < 0) {
			Vertical = 0;
			}
			
			if (VerR){
				
				
				Quaternion CamRotAngulo = Quaternion.AngleAxis(-10.5f*velocidadrotar,Vector3.up);
				
				_cameraOfsset = CamRotAngulo * _cameraOfsset;
				
				Vector3 newpo = PlayerTranform.transform.position + _cameraOfsset;
		
				transform.position = Vector3.Slerp(transform.position,newpo,factor);
				

			}else if (VerL){
				
				Quaternion CamRotAngulo = Quaternion.AngleAxis(10.5f*velocidadrotar,Vector3.up);
				
				_cameraOfsset = CamRotAngulo * _cameraOfsset;
				
				Vector3 newpo = PlayerTranform.transform.position + _cameraOfsset;
		
				transform.position = Vector3.Slerp(transform.position,newpo,factor);
				
			}
			
				
			if (rotaR){
				
				
				Quaternion CamRotAngulo = Quaternion.AngleAxis(-10.5f*velocidadrotar,Vector3.up);
				
				_cameraOfsset = CamRotAngulo * _cameraOfsset;
				

			}else if (rotaL){
				
				Quaternion CamRotAngulo = Quaternion.AngleAxis(10.5f*velocidadrotar,Vector3.up);
				
				_cameraOfsset = CamRotAngulo * _cameraOfsset;
				
			}
			
			
			
			Vector3 newpocam = PlayerTranform.transform.position + _cameraOfsset;
		
			transform.position = Vector3.Slerp(transform.position,newpocam,factor);
			
			PlayerTranform.transform.Rotate(0,Horizontal*310.0f*Time.deltaTime,0);
			
			
			
			
			if (apuntarPlater || rotaR || rotaL || VerL || VerR/*|| rotatemause*/){
				
				Vector3 correc = new Vector3(0,1.4f,0);
				//transform.Rotate(10,0,0);
				transform.LookAt(PlayerTranform.transform.position + correc);
				
			}
				
		
		
		}
		
	}
}
