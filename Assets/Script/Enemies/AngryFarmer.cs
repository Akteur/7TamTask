using UnityEngine;

public class AngryFarmer : MonoBehaviour
{
    [SerializeField] GameObject farmer;
    EnemySpriteChanger spriteChanger;
    void Start()
    {
        spriteChanger = farmer.GetComponent<EnemySpriteChanger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(!spriteChanger.dirtyFarmer)
                spriteChanger.angryFarmer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            spriteChanger.angryFarmer = false;
        }
    }
}
