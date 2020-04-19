using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class Take_and_remove : MonoBehaviour
{
   // public GameObject myPlaer;
    private float distance;
    public float interactDistance=3f;
    public KeyCode myKey = KeyCode.E;
    public Text myText;
    public Transform arm;
    private void OnMouseDrag()
    {
        distance = Vector3.Distance(arm.GetComponent<Transform>().position, transform.position);
        if (distance < interactDistance)
        {
        //myText.enabled = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (Input.GetKeyDown(myKey))
            {
                transform.position = arm.position;
                transform.rotation = arm.rotation;
            transform.SetParent(arm);
                gameObject.GetComponent < Rigidbody >().useGravity = false;
                
                // gameObject.GetComponent<BoxCollider>().isTrigger = true;
            }
            
        }
       
    }
    private void Return()
    {
        distance = Vector3.Distance(arm.GetComponent<Transform>().position, transform.position);
        if (distance < 0.5f)
        { 
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            if (!Input.GetKeyDown(KeyCode.Mouse1))
            {
                transform.position = arm.position;
                transform.rotation = arm.rotation;
                transform.SetParent(arm);
                gameObject.GetComponent<Rigidbody>().useGravity = false;
            }
        }

    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    private void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            transform.parent = null;
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            if (distance < interactDistance){
                gameObject.transform.position = new Vector3(arm.position.x, arm.position.y, arm.position.z + 1.1f);
            }
        }
        else
        {
            Return();
        }

    }
}
