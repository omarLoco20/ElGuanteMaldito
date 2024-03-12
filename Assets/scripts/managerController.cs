using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerController : MonoBehaviour
{
    public string nivel1;
    public string comoJugar;
    public string creditos;
    public string dondeDesees;

    public void Jugar()
    {
        SceneManager.LoadScene(nivel1);
    }
    public void ComoJugar()
    {
        SceneManager.LoadScene(comoJugar);
    }
    public void Creditos()
    {
        SceneManager.LoadScene(creditos);
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void TuElijes()
    {
        print("tu eliges");
        SceneManager.LoadScene(dondeDesees);
    }
    

}
