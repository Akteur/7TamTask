using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        GameManager.instance.bombSetted = false;
        GameManager.instance.bombExploded = false;
        GameManager.instance.farmerIsDirty = false;
        SceneManager.LoadScene("SampleScene");
    }
}
