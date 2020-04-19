using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Catch_in : MonoBehaviour
{
    public Text text_profil;
    public InputField inputfild;
    private void Start()
    {
        text_profil.text = Broadcast.MyText;
    }
    public void LoadText()
    {
        Broadcast.MyText = inputfild.text;
    }
   
}
