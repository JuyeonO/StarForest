using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    public Sprite obj;  //사려는 물품
    public int Price;   //가격
    private Text money; //가진 돈(Text)

    public void Clicked()
    {
        this.money = GameObject.Find("money").GetComponent<Text>();

        int haveMoney = int.Parse(money.text);

        if (haveMoney >= Price) //돈 부족한지 확인
        {
            this.money.text = (haveMoney - Price).ToString();
            //인벤토리에 해당 아이템 추가
        }
        else
        {
            Debug.Log("돈이 부족합니다!");
        }

    }
}