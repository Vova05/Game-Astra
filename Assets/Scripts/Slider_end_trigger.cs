using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider_end_trigger : MonoBehaviour
{
    public GameObject Slider;
    public Vector3 start_position;
    private void Start()
    {
        start_position = Slider.transform.position;
    }
    private void OnTriggerStay(Collider other)
    {
        Slider.GetComponent<Renderer>().material.color = Color.green;
        if (other.tag == "Slider")
        {
            Slider.GetComponent<Renderer>().material.color = Color.green;
            other.transform.position = start_position;
        }
    }

}
