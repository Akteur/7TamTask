using UnityEngine;

public class Moving : MonoBehaviour
{
    public bool up;
    public bool down;
    public bool left;
    public bool right;
    private float collX;
    private float collY;
    SpriteRenderer spriteRenderer;
    BoxCollider2D coll;
    [SerializeField] Sprite[] pigs;
    [SerializeField] float speed = 0.1f;
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
        collX = coll.size.x;
        collY = coll.size.y;
    }
    void FixedUpdate()
    {
        PlayerMoving();
    }

    void PlayerMoving()
    {
        if (up)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, 0);
            coll.size = new Vector2(collY, collX);
            spriteRenderer.sprite = pigs[0];
        }
        if (left)
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
            coll.size = new Vector2(collX, collY);
            spriteRenderer.sprite = pigs[1];
        }
        if (down)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, 0);
            coll.size = new Vector2(collY, collX);
            spriteRenderer.sprite = pigs[2];
        }
        if (right)
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, 0);
            coll.size = new Vector2(collX, collY);
            spriteRenderer.sprite = pigs[3];
        }        
    }
}
