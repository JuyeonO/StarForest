using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellController : MonoBehaviour
{
    public GameObject windowSell;
    public GameObject cancelBtn;

    void Start()
    {
        if (windowSell != null)
        {
            windowSell.SetActive(false);  // �ʱ⿡ �Ǹ� â�� ��Ȱ��ȭ
        }

        Button cancelBtn = windowSell.transform.Find("CancelBtn").GetComponent<Button>();
        cancelBtn.onClick.AddListener(Cancel);
    }
    private void Cancel()
    {
        windowSell.SetActive(false);
    }

}
