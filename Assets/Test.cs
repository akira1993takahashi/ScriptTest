using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //�̗�
    private int power = 25; //�U����
    private int mp = 53;�@//MP

    //�U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    //�h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        //�c��hp�����炷
        this.hp -= damage;
    }

    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U�������B�c��MP��" + mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        //�U���p�̊֐����Ăяo��
        lastboss.Attack();
        //�h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //���@�U���p�̊֐����Ăяo��(10��)
        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
        //MP������Ȃ����b�Z�[�W�m�F�p
        lastboss.Magic();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
