using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Update() {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();   //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기 / gamemanager 두 줄 GameManager 스크립트 완성 후 추가 352p
        gameManager.EndGame();
    }
}
