using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueController : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;
    public GameObject Button_Exit;
    public GameObject Button_Restart;
    public GameObject TXT_Advice;

    public void Continue()
    {
        Panel.SetActive(false);
        Button.SetActive(false);
        Button_Exit.SetActive(false);
        Button_Restart.SetActive(false);
        TXT_Advice.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
