using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buy : MonoBehaviour
{
    public Sprite obj;  //����� ��ǰ
    public int Price;   //����
    private TMP_Text money; //���� ��(Text)

    public GameObject EndingCheckPanel;


    public void Clicked()
    {
        this.money = GameObject.Find("txt_Coin").GetComponent<TextMeshProUGUI>();

        int haveMoney = int.Parse(money.text);

        if (haveMoney >= Price) //�� �������� Ȯ��
        {
            if(obj.name == "spr_deco_coracle_land") //����� ������Ʈ�� ������ Ȯ��
            {
                EndingCheckPanel.SetActive(true);
            }
            else
            {
                this.money.text = (haveMoney - Price).ToString();
                //�κ��丮�� �ش� ������ �߰�
            }
        }
        else
        {
            Debug.Log("���� �����մϴ�!");
        }
    }
    public void onBtnBuyBoat()
    {
        SceneManager.LoadScene("EndingScene");
        //Debug.Log("Ending");
    }
    public void onBtnCancelBoat()
    {
        EndingCheckPanel.SetActive(false);
    }
}