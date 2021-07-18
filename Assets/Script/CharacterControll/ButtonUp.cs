using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    [SerializeField] GameObject player;
    Moving moving;
    void Start()
    {
        moving = player.GetComponent<Moving>();
    }
    public void PointerDown()
    {
        if (!moving.left && !moving.right)
            moving.up = true;
    }
    public void PointerUp()
    {
        moving.up = false;
    }
}
