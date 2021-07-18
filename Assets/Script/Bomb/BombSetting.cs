using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombSetting : MonoBehaviour
{
    [SerializeField] SpriteRenderer bombSpriteRenderer;
    [SerializeField] SpriteRenderer promptSpriteRenderer;
    [SerializeField] Light pointLight;
    [SerializeField] GameObject camera;
    Vector3 newCamPos;
    private void Awake()
    {
        GameManager.instance.bombExploded = false;
        GameManager.instance.bombSetted = false;
    }
    void Start()
    {
        bombSpriteRenderer.color = new Color(1, 1, 1, 0);
        promptSpriteRenderer.color = new Color(1, 1, 1, 1);
        newCamPos = camera.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameManager.instance.bombSetted = true;
            bombSpriteRenderer.color = new Color(1, 1, 1, 1);
            promptSpriteRenderer.color = new Color(1, 1, 1, 0);
            StartCoroutine(ExplosiveTimer());
            
        }
    }
    void Explosive()
    {
        GameManager.instance.bombExploded = true;
        bombSpriteRenderer.color = new Color(1, 1, 1, 0);
        pointLight.range = 3;
        pointLight.intensity = 20f;
    }
    IEnumerator ExplosiveTimer()
    {
        for(int i = 0; i < 4; i++)
        {
            pointLight.intensity = 0f;
            yield return new WaitForSeconds(0.3f);
            pointLight.intensity = 3f;
            yield return new WaitForSeconds(0.3f);
        }
        Explosive();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("GameOver");
    }
}
