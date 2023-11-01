using UnityEngine;

public class ItemDetection : MonoBehaviour
{
    public float detectionRadius = 10f; // �������� ������ �ݰ�
    public LayerMask itemLayer; // ������ ���̾�

    private void Update()
    {
        DetectItemsInRadius();
    }

    private void DetectItemsInRadius()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius, itemLayer);

        if (colliders.Length > 0)
        {
            // �������� ������ ��� �޽��� ���
            Debug.Log("������ ����");
        }
    }
}
