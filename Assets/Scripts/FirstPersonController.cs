using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour {

	[SerializeField]
	public float speed;
	[SerializeField]
    public float gravity;
	[SerializeField]
    public float jumpPower;
    public Vector3 moveDirection;
    public CharacterController player;
[SerializeField]
    private float xMov;
	[SerializeField]
    private float zMov;
	[SerializeField]
    public Ray ray;
    public RaycastHit hit;
	[SerializeField]
    public float raydistance=2f;

	void Start () {
		player = GetComponent<CharacterController>();
		gravity=1f;
		speed=3f;
		jumpPower=0.8f;
	}
	
	void Update () {
		Move();
	}

	private void Move()
	{
		xMov=Input.GetAxis("Horizontal");
		zMov=Input.GetAxis("Vertical");
		if(player.isGrounded)
		{
			gravity=0.1f;
			moveDirection = new Vector3(xMov, 0f,zMov);
			moveDirection=transform.TransformDirection(moveDirection)*speed;
			if(Input.GetAxis("Run")==1)
			{	speed=7f;	jumpPower=1f;}
			else
			{	speed=3f;	jumpPower=0.8f;}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				gravity=-(jumpPower);
			}

		}
		else if(!player.isGrounded)
		{
			gravity+=0.12f;
			
		}
		moveDirection.y-=gravity;
		
		
		player.Move(moveDirection*Time.fixedDeltaTime);			
	}
	private void Use()
	{
		ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width/2, Screen.height/2));   
		if(Physics.Raycast(ray, out hit, raydistance))													
		{
		
		}
	}

}
