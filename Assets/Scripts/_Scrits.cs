using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class _Scrits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void YenidenOyna()
    {
        SceneManager.LoadSceneAsync("AnaSayfa");
    }
    public void Cıkıs()
    {
        Application.Quit();
    }
}
