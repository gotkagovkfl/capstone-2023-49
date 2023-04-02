using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : Boss
{
    public bool move = false;
    void Start()
    {
        StartCoroutine(MoveDown());
    }

    void FixedUpdate()  // �÷��̾� ������ �̵�
    {
        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    IEnumerator MoveDown()    // ���� ���� ���
    {
        rigid.velocity = new Vector2(0, -5);
        yield return new WaitForSeconds(3f);
        rigid.velocity = Vector2.zero;
        yield return new WaitForSeconds(3f);
        move = true;
    }
}
