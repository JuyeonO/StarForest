using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject canvas;
    private bool isCanvasActive = false;
    private Slot[] slots;  // ���Ե� �迭

    [SerializeField]
    private GameObject go_SlotsParent;  // Slot���� �θ��� Grid Setting 

    private void Start()
    {
        slots = go_SlotsParent.GetComponentsInChildren<Slot>();
        if (canvas != null) // Null üũ
        {
            canvas.SetActive(false);
        }
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
    public void AcquireItem(Item _item, int _count = 1)
    {
        if (_item == null)
        {
            return;
        }

        if (_item.itemType != Item.ItemType.Equipment)
        {
            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item != null)
                {
                    if (slots[i].item.itemName == _item.itemName)
                    {
                        slots[i].SetSlotCount(_count);
                        return;
                    }
                }
            }

            for (int i = 0; i < slots.Length; i++)
            {
                if (slots[i].item == null)
                {
                    slots[i].AddItem(_item, _count);
                    return;
                }
            }
        }
    }
}
