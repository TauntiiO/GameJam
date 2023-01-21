using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void button_exit()
    {
        Application.Quit();
        Debug.Log("Exiting game");
    }
}