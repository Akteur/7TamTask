using UnityEngine;

public class ButtonRight : MonoBehaviour
{
    [SerializeField] GameObject player;
    Moving moving;
    void Start()
    {
        moving = player.GetComponent<Moving>();
    }
    public void PointerDown()
    {
        if (!moving.up && !moving.down)
            moving.right = true;
    }
    public void PointerUp()
    {
        moving.right = false;
    }
}
