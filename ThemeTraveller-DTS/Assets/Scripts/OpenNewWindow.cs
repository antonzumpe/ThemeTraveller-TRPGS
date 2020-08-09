using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNewWindow : MonoBehaviour
{
    public GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnClick()
    {
        GameManager.CreateWindows(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
