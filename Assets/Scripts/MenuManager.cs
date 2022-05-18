using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  
  
    //funcion para cargar el primer nivel
    public void LoadLVL1()
    {
        SceneManager.LoadScene("Nivel_1");
    }
    public void Loadmainmenu()
    {
        SceneManager.LoadScene("Menu");
    }

    IEnumerator Loadnivel1()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Nivel_1");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

