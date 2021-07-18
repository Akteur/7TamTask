using UnityEngine;

public class ButtonDown : MonoBehaviour
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
            moving.down = true;
    }
    public void PointerUp()
    {
        moving.down = false;
    }
}
