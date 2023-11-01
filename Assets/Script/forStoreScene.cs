using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forStoreScene : MonoBehaviour
{
    public GameObject windowSell;
    private void Start()
    {
        // �ʱ⿡ Window_sell Panel�� ��Ȱ��ȭ
        if (windowSell != null)
        {
            windowSell.SetActive(false);
        }
    }

    // Slot ��ư Ŭ�� �� ȣ��Ǵ� �Լ�
    public void OnSlotButtonClick()
    {
        // Slot ��ư�� Ŭ������ �� �����ϰ� ���� ������ �߰��մϴ�.
        // ��: Window_sell Panel�� Ȱ��ȭ
        if (windowSell != null)
        {
            windowSell.SetActive(true);
        }
    }

    // �Ǹ� â���� ��� ��ư�� ������ ȣ��� �Լ�
    public void OnCancelClick()
    {
        // ��� ��ư�� ������ �� �����ϰ� ���� ������ �߰��մϴ�.
        // ��: Window_sell Panel�� ��Ȱ��ȭ
        if (windowSell != null)
        {
            windowSell.SetActive(false);
        }
    }
}
