using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broken : MonoBehaviour
{
    public GameObject Active;
    public GameObject Remove;
   void Update()
    {
        if (Take_broke.chek == true)
        {
            Active.SetActive(true);
            Remove.SetActive(false);
        }
    }
}
