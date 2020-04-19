using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enter_pass : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text_profil;
    public InputField inputfild;
    private void Start()
    {
        text_profil.text = Password.Pass;
    }
    public void LoadText()
    {
        Password.Pass = inputfild.text;
    }
}
