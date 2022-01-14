using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        panel.SetActive(true);
    }

    public void sunlightmap()
    {
        SceneManager.LoadScene(1);
    }

    public void nightmaremap()
    {
        SceneManager.LoadScene(2);
    }
}
