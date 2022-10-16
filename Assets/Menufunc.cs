using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menufunc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
    public void jugal()
    {
        SceneManager.LoadScene("Juego");

    }
    public void controle()
    {
        SceneManager.LoadScene("Controles");
    }
}
