using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public Sprite obj;  //����� ��ǰ
    public int Price;   //����
    private Text money; //���� ��(Text)

    public void Clicked()
    {
        this.money = GameObject.Find("money").GetComponent<Text>();

        int haveMoney = int.Parse(money.text);

        if (haveMoney >= Price) //�� �������� Ȯ��
        {
            this.money.text = (haveMoney - Price).ToString();
            //�κ��丮�� �ش� ������ �߰�
        }
        else
        {
            Debug.Log("���� �����մϴ�!");
        }

    }
}