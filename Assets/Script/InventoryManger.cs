using UnityEngine;

public class InventoryManger : MonoBehaviour
{
    private static InventoryManger instance;

    // ���� �������� ���� ������Ʈ�� ����ϱ� ���� DontDestroyOnLoad ���
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // GameManager�� �����ϴ� �޼��带 ����
    public static InventoryManger GetInstance()
    {
        return instance;
    }


    // ��Ÿ �κ��丮 ���� �ڵ�
}