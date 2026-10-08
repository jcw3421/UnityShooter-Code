using JetBrains.Annotations;
using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawPoint;
    public GameObject cannon;
    public float jumpSpeed = 5.0f;
    //private GameObject p1;
    //protected GameObject p2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //씬에다 넣는 함수
    }

    // Update is called once per frame
    void Update()
    {
        // 만약에 마우스 왼쪽 버튼을 누르면
        // 마우스 왼쪽버튼: 중력적용 발사, 오른쪽 버튼 중력없이 발사
        // 목표물에 포탄이 맞았을때 제대로 부서지는가?
        // 발사 속도를 변수로 만들어서 에디터에서 변강할 것
        // 대포의 방향을 위아래로 조절해서 발사하기
        // 블럭 프리팹 만들고 for 문을 이용해서 가로 50x20 벽 만들기
        // GameObject.Transform.position = new Vector3(x,y,z)

        if (Input.GetMouseButtonDown(0) == true)

        {
            GameObject obj = Instantiate(projectile, spawPoint.position, spawPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.useGravity = true;

            if (rb != null)

            {
                rb.linearVelocity = spawPoint.right * 20.0f;
            }
        }

        if (Input.GetMouseButtonDown(1) == true)
        {
            //쏴! Shoot! 
            GameObject obj = Instantiate(projectile, spawPoint.position, spawPoint.rotation);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.useGravity = false;

            if (rb != null)

            {
                rb.linearVelocity = spawPoint.right * 20.0f;
            }
        }
        float rotDir = 0;

        //만약에 'w'키를 누르면 포탑이 올라간다
        if (Input.GetKey(KeyCode.W) == true)
        {
            transform.Translate(0.1f,0,0);  
            //transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
        }


        //만약에 's'키를 누르면 포탑이 내려간다
        if (Input.GetKey(KeyCode.S) == true)
        {
            transform.Translate(-0.1f, 0, 0);
        }
        //transform.localRotation *= Quaternion.Euler(0.0f, 0.0f, rotDir * 2.0f);

        // 대포 자체를 왼쪽 오른쪽 이동하기
        //만약에 a키를 누르면 대포가 왼쪽으로 이동
        //만약네 d키를 누르면 대포가 오른쪽으로 이동
        //만약에 트랜스폼을 사용하면 현재 스크립트가 붙어있는 오브젝트가 변경된다


        if (Input.GetKey(KeyCode.A) == true)
        {
            //rotDir = -1;
            //transform.Translate(-0.5f, 0, 0);
            transform.Translate(0, 0,  0.1f);
            Debug.Log("A키가 눌러졌다 " + transform.position);
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            //rotDir = -1;
            transform.Translate(0, 0, -0.1f);
            Debug.Log("D키가 눌러졌다" + transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb)
            {
                rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            }
        }
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
      
        Debug.Log("Mouse X:" + h + ", Mouse Y:" + v);

        cannon.transform.Rotate(Vector3.forward * -v * 2.0f);
        transform.Rotate(Vector3.up * h * 2.0f);
    

        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position. transform.position.z + 0.5f);
    }
}
    
