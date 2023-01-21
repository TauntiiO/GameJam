using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchMenu : MonoBehaviour
{
    public void LaunchingMenu()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Lauching menu");
    }
}