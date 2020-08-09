using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Window;
    public GameObject Canvas;

    private bool isTrue = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateWindows(int numberOfWindows)
    {
        if (isTrue)
        {
            for (int i = 0; i < numberOfWindows; i++)
            {
                Debug.Log(i);
                Canvas = GameObject.Find("Main Canvas");
                GameObject window = Instantiate(Window, new Vector2(-600 + (i * 75), 300 + (i * -50)), Quaternion.identity);
                window.GetComponent<DebugScript>().LogToDebug();
                window.GetComponent<Transform>().SetParent(Canvas.transform, false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
