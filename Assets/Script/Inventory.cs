using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject canvas;
    private bool isCanvasActive = false;


    private void Start()
    {
        canvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // i Ű�� ���� �� Canvas�� Ȱ��ȭ ���¸� ����
            isCanvasActive = !isCanvasActive;
            canvas.SetActive(isCanvasActive);
        }
    }

}
