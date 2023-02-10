using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL:MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void yt()
    {
       Application.OpenURL("https://www.youtube.com/watch?v=WhWc3b3KhnY");
    }
    public void instagram()
    {
        Application.OpenURL("https://www.instagram.com/mycin.in/");
    }
    public void Linkedin()
    
    {
        Application.OpenURL("https://www.linkedin.com/in/akankshathisside/");
    }
    public void Google()
    {
        Application.OpenURL("https://www.google.com/");
    }
}
