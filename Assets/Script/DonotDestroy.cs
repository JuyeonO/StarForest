using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonotDestroy : MonoBehaviour
{
    private static DonotDestroy instance;

    // �ٸ� ��ũ��Ʈ���� �� ������Ʈ�� ������ �� ����� �Ӽ�
    public static DonotDestroy Instance
    {
        get
        {
            // �ν��Ͻ��� ������ �����ϰ� �׷��� ������ ������ �ν��Ͻ��� ��ȯ
            if (instance == null)
            {
                // ���� �̱��� ������Ʈ�� ������ ����
                instance = FindObjectOfType<DonotDestroy>();

                // ���� �̱��� ������Ʈ�� ������ ���� ����
                if (instance == null)
                {
                    GameObject DonotDestroy = new GameObject("DonotDestroy");
                    instance = DonotDestroy.AddComponent<DonotDestroy>();
                }

                // �� ��ȯ �ÿ� �ı����� �ʵ��� ����
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }
}
