using UnityEngine;

public class InExplosiveRadius : MonoBehaviour
{
    [SerializeField] GameObject farmer;
    EnemySpriteChanger spriteChanger;
    void Start()
    {
        farmer = GameObject.FindGameObjectWithTag("Enemy");
        spriteChanger = farmer.GetComponent<EnemySpriteChanger>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            spriteChanger.dirtyFarmer = true;
            GameManager.instance.farmerIsDirty = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            spriteChanger.dirtyFarmer = false;
            GameManager.instance.farmerIsDirty = false;
        }
    }
}
