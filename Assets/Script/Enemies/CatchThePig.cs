using UnityEngine;
using UnityEngine.SceneManagement;

public class CatchThePig : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
