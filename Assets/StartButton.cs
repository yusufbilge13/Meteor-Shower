using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject panel;

    public void startButton()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
    }
}
