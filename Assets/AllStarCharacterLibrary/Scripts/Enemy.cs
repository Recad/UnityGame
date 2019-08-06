using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	
	Animator animator;
	public CharacterController PlayerController; 
	public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    Vector2 hotSpot = new Vector2(16.0f,16.0f);
	public bool targeted=false;
	
	public int life = 300;
	
	
	public bool estadistancia=false;
	
	public float distanciaAtacar = 20f;
	public float distanciaGolper = 4.0f;
	// Use this for initialization
	
	public void iniciarataqueEvent(){
		
		 animator.SetBool("ataco",true);
		//Debug.Log("inicia");
	}
	
	
	public void estaatacandoEvent(){
		
		animator.SetBool("ataco",false);
		//Debug.Log("termina");
	}
	
	
	void Start () 
	{
		animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	
		float distancia=Vector3.Distance(PlayerController.transform.position,transform.position);
	
		if (distancia < distanciaAtacar) {
			
			transform.LookAt(PlayerController.transform.position);
			
			if(distancia <= distanciaGolper){
				if (!animator.GetBool("Muerto")){
					
					animator.SetTrigger("atacado");
					
				}
				
				
				}
			
		}
	
	
	
	}
	void OnMouseEnter() 
	{
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		targeted = true;
    }
    void OnMouseExit() 
	{
        Cursor.SetCursor(null, new Vector2(16.0f,16.0f), cursorMode);
		targeted = false;
    }
	
}
