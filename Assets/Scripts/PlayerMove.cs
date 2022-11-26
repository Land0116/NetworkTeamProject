using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMove : MonoBehaviourPun
{
    private Rigidbody rb;
    public DiceScript dice;

    public int curPos;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        dice =  GameObject.Find("Dice_Red").GetComponent<DiceScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0)) && dice.isThrowDice == false)
        {
            //rb.AddForce(Vector3.up * 120);
            dice.ThrowDice();
            Move();
        }
    }

    public void Move()
    {
        if(transform.position != GameManager.Instance.map[curPos].board.position)
        {
            Vector3 Borad = Vector3.MoveTowards(transform.position, GameManager.Instance.map[curPos].board.position, GameManager.Instance.speed * Time.deltaTime);
            Debug.Log("¿Ãµø");
            rb.MovePosition(Borad);
        }
    }

}