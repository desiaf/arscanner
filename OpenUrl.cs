using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenUrl : MonoBehaviour
{
    public string Url;
    public string Url2;
    public void Open()
    {
        Application.OpenURL(Url);
    }
    public void CallPhone()
    {
        Application.OpenURL("tel://[8448603206]");
    }

    public void MarkAsDelivered()
    {
        Application.OpenURL(Url2);
    }
}
