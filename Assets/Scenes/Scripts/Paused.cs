using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Button;
    public GameObject Button_Exit;
    public GameObject Button_Restart;
    public GameObject TXT_Advice;

    public void Pause()
    {
        Button.SetActive(true);
        Panel.SetActive(true);
        Button_Exit.SetActive(true);
        Button_Restart.SetActive(true);
        TXT_Advice.SetActive(true);

        Time.timeScale = 0;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }
}
