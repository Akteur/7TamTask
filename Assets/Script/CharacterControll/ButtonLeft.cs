using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLeft : MonoBehaviour
{
    [SerializeField] GameObject player;
    Moving moving;
    void Start()
    {
        moving = player.GetComponent<Moving>();
    }
    public void PointerDown()
    {
        if(!moving.up && !moving.down) 
            moving.left = true;
    }
    public void PointerUp()
    {
        moving.left = false;
    }
}
