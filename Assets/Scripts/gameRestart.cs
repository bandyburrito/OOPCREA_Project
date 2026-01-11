using UnityEngine;
using UnityEngine.SceneManagement;

public class gameRestart : MonoBehaviour
{

    public SceneManager sceneManager;
   

    public void Button1() 
    {
        SceneManager.LoadScene(0);
    }

}
