using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    //Variables
    public string username;
    public string password;

    //Function that gets two strings and check if it's the parameters it need to log in
    private bool login(string user, string pass)
    {
        if( user == "admin"  &&  pass == "abccba")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Start()
    {
        //Call of the function with a conditional
        if(login(username, password) == true)
        {
            Debug.Log($"Access granted");
        }
        else
        {
            Debug.Log($"Access denied");
        }
    }
}
