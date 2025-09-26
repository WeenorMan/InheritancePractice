using UnityEngine;

public class Enemy : MonoBehaviour
{
   public virtual void AttackPlayer()
    {
        print("enemy is attacking player");
    }

    void OnMouseOver()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.red;
        AttackPlayer();
    }

    void OnMouseExit()
    {
        transform.GetComponent<SpriteRenderer>().color = Color.white;

    }
}
