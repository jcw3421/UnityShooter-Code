using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class cheek : MonoBehaviour
{
    //충돌이 시작될떄 호출
    public int damange = 34;
 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {

            }
        }
        else if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Stage")
        {
            Destroy(collision.gameObject);
        }
       
 


    }

    //충돌이 유지되는 동안 호출

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중:" + collision.gameObject.name);
    }
  

    //충돌이 끝날떄 호출 

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 종료:" + collision.gameObject.name);

        //if (collision.gameObject.tag == "Enemy")
        //{   
        //    Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        //    if (enemy != null)
        // }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
