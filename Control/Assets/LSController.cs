using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LSController : MonoBehaviour
{
    Rigidbody rigid;
    public GameManageLogic manager;
    public float jumpPower;
    bool isJump;
    public int itemCount;
    public float speed;
   

    void Start()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {


        Vector3 vec = new Vector3(Input.GetAxisRaw("Vertical"), 0, -Input.GetAxisRaw("Horizontal"));

        rigid.AddForce(vec , ForceMode.Impulse);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * speed;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ground")
            isJump = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ball")
        {
            itemCount++;
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }

        else if (other.tag == "Point")
        {
            if (itemCount == manager.totalItemCount)
            {
                if (manager.stage == 2)
                    SceneManager.LoadScene(0);
                else
                    SceneManager.LoadScene(manager.stage + 1);
            }
            else
                SceneManager.LoadScene(manager.stage);
        }
    }
}
