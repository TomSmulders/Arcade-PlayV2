using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    int currentSelected = 1;
    public int max = 3;

    public int selected1;
    public int selected2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "start")
        {
            if (Input.GetKeyDown(KeyCode.W) && currentSelected >= 1)
            {
                currentSelected--;
                RectTransform myRectTransform = GetComponent<RectTransform>();
                myRectTransform.localPosition += new Vector3(0,155,0);  
            }
            if (Input.GetKeyDown(KeyCode.S) && currentSelected <= max - 2)
            {
                currentSelected++;
                RectTransform myRectTransform = GetComponent<RectTransform>();
                myRectTransform.localPosition -= new Vector3(0, 155, 0);
            } 

            if (Input.GetKeyDown(KeyCode.Space))
            {
                switch (currentSelected)
                {
                    case 0:
                        SceneManager.LoadScene(selected1); 
                        break;
                    case 1:
                        SceneManager.LoadScene(selected2);
                        break;
                    case 2:
                        Application.Quit();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
