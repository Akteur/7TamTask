using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public bool bombSetted = false;
    public bool bombExploded = false;
    public bool farmerIsDirty = false;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
