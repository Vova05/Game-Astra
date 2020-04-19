using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_object2 : MonoBehaviour
{
    public GameObject target;
    public GameObject target2;


    // Update is called once per frame
    void Update()
    {
        if (Broken_chec.destroy == true)
        {
            target.SetActive(false);
            target2.SetActive(false);
        }

    }
}
