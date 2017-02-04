using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwitterTest : MonoBehaviour {

    public string url = "http://www.twitter.com";
    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        TextMesh text = GetComponent<TextMesh>();
        text.text = www.text;
        print("testt");
    }
}
