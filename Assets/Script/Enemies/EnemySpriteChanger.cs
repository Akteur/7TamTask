using System;
using UnityEngine;

public class EnemySpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite[] farmerTop;
    [SerializeField] Sprite[] farmerBottom;

    [SerializeField] Sprite[] dirtyFarmerTop;
    [SerializeField] Sprite[] dirtyFarmerBottom;

    [SerializeField] Sprite[] angryFarmerTop;
    [SerializeField] Sprite[] angryFarmerBottom;

    [SerializeField] SpriteRenderer enemyTopRenderer;
    [SerializeField] SpriteRenderer enemyBottomRenderer;
    [SerializeField] Vector3 enemyTransform;

    [SerializeField] GameObject farmerTopBody;
    public bool angryFarmer;
    public bool dirtyFarmer;
    private int spriteType;
    private float xDiff;
    private float yDiff;
    void Start()
    {
        enemyBottomRenderer = GetComponent<SpriteRenderer>();
        enemyTransform = transform.position;
    }
    void Update()
    {
        xDiff = Math.Abs(enemyTransform.x - transform.position.x);        
        yDiff = Math.Abs(enemyTransform.y - transform.position.y);
        if(yDiff > xDiff)
        {
            MovingDown();
            MovingUp();
        }
        else if(yDiff < xDiff)
        {
            MovingLeft();
            MovingRight();
        }
        ChangeSprite(spriteType);
    }
    void MovingDown()
    {
        if(enemyTransform.y > transform.position.y)
        {
            spriteType = 0;
        }
    }
    void MovingLeft()
    {
        if (enemyTransform.x > transform.position.x)
        {
            spriteType = 1;
        }
    }
    void MovingRight()
    {
        if (enemyTransform.x < transform.position.x)
        {
            spriteType = 2;
        }
    }
    void MovingUp()
    {
        if (enemyTransform.y < transform.position.y)
        {
            spriteType = 3;
        }
    }

    void ChangeSprite(int type)
    {
        if (angryFarmer)
        {
            farmerTopBody.transform.localPosition = new Vector3(0, 3.81f, 0);
            enemyTopRenderer.sprite = angryFarmerTop[type];
            enemyBottomRenderer.sprite = angryFarmerBottom[type];
            enemyTransform = transform.position;
        }
        else if (dirtyFarmer && GameManager.instance.bombExploded)
        {
            enemyTopRenderer.sprite = dirtyFarmerTop[type];
            enemyBottomRenderer.sprite = dirtyFarmerBottom[type];
            enemyTransform = transform.position;
        }
        else
        {
            enemyTopRenderer.sprite = farmerTop[type];
            enemyBottomRenderer.sprite = farmerBottom[type];
            enemyTransform = transform.position;
        }
    }
}
