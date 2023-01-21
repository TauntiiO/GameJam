using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchSettings : MonoBehaviour
{
    public void LaunchingSettings()
    {
        SceneManager.LoadScene("Settings");
        Debug.Log("Lauching settings");
    }
}