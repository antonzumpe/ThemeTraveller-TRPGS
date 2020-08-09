using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Token;
    public GameObject Canvas;

    private bool isTrue = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateTokens(int numberOfTokens)
    {
        if (isTrue)
        {
            for (int i = 0; i < numberOfTokens; i++)
            {
                Debug.Log(i);
                Canvas = GameObject.Find("Main Canvas");
                GameObject token = Instantiate(Token, new Vector2(-600 + (i * 75), 300 + (i * -50)), Quaternion.identity);
                token.GetComponent<DebugScript>().LogToDebug();
                token.GetComponent<Transform>().SetParent(Canvas.transform, false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("Pressed primary mouse button.");
        //    CreateTokens(10);
        //}
    }
}
