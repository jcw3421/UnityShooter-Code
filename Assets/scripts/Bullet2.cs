using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public int damage = 30;
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player != null)
            {
                if (!player.Damage(damage))
                {
                    Debug.Log("당신은 죽었습니다!");
                }
                Debug.Log("플레이어 명중! ");
            }
        }
    }
}

//if (collision.gameObject.tag == "Enemy")
//{
//    Debug.Log("적 충돌!");
//    Enemy enemy = Collision.gameObhect.GetComponet<Enemy>();
//    if (enemy != null)
//    {
//        enemy.health -= damange;
//        if (enemy.health <= 0)
//        {

//        }
//        //적의 체력을 감소시킨다. 총알이 가지고 있는 값만큼.
//        //만약에 enemy의 Health 가 0이가너 0보다 작으면 Destory
//        Debug.Log("적 충돌!") + enemy.health);
//    }
//    else if
//}