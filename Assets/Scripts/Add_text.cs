using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Add_text : MonoBehaviour
{
    public GameObject plaer;
    public Text field;
    private string[] new_mess = { "Press the button", "Find the card","Finde the ware"," You play!","Sequence=1-5-2","You Winner" };
    private int i = 0;
    private void Update()
    {
        if (Add_Tap_Text.trigger==true)
        if (Add_Tap_Text.trigger==true)
        {
            i++;
            field.text = new_mess[1] + "\n";
           // Destroy(field);
        }
        if (Lock_open.trigger == true)
        {
            i++;
            field.text = new_mess[2]+"\n";
        }
        if (i == 2&&Comp_inform.trigger==false)
        {
            i++;
            field.text = new_mess[i] + "\n";
        }
        if (Comp_inform.trigger == true)
        {
            i++;
            field.text = new_mess[4] + "\n";
        }
        if (End_Game_key1.Key_enter == true && End_Game_key2.Key_enter == true && End_game_key3.Key_enter == true && End_game_key4.Key_enter == true)
        {
            field.text = new_mess[5] + "\n";
            
        }
    }

}
