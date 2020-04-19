using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controller : MonoBehaviour
{
    CharacterController controler;
    Animator anim;
    public float speed = 2f;
    public float jump = 14f;
    public float gravity = 4f;
    public bool IsGround;
    int temp = 0;
    Vector3 direction=Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controler = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
      
        if (x!=0|| z != 0)
        {
            //if (Input.GetButton("Run"))
           // {
             //   speed = speed * 2*Time.deltaTime;
            //}
            Vector3 dir = transform.TransformDirection(new Vector3(x*speed*Time.deltaTime, 0f , z *speed* Time.deltaTime));
            controler.Move(dir);
        }
       
        Jumping();
    }
    public void Jumping()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit hitdown;
        if (Physics.Raycast(ray, out hitdown, 0.25f))
        {
            IsGround = true;
        }
        else
        {
            IsGround = false;
        }
        if (Input.GetButton("Jump")&&IsGround==true)
        {
            direction.y = jump;
        }
        direction.y -= gravity * Time.deltaTime;
        controler.Move(direction * Time.deltaTime);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name.ToString() == "Transportation")
        {
            Rigidbody body = hit.gameObject.GetComponent<Rigidbody>();
            if (body != null)
            {
                body.AddForce(hit.moveDirection*10f);
            }
        }
    }
}