using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour
{
    public InputField inputname;
    public Text Name;
    public static string username;

    public void CallInput()
    {
        username = inputname.text;
    }

    void Awake()
    {

        Name.text = ("NAME: " + username);
    }

}
