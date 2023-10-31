using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropsGrow : MonoBehaviour
{
    Animator animator;
    public bool GrowEnd = false;

    //�ִϸ��̼�
    public bool beetroot = false;
    public bool carrot = false; //�ϴ� �̰ŷ�
    public bool parsnip = false;
    public bool pumpkin = false;


    void Awake()
    {
        animator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartGrow());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FullGrow());
    }


    IEnumerator StartGrow()
    {
        yield return new WaitForSeconds(5f);    //5�� ���
        if (beetroot)
        {
            animator.SetBool("beetroot", true);
        }
        else if (carrot)
        {
            animator.SetBool("carrot", true);
        }
        else if (parsnip)
        {
            animator.SetBool("parsnip", true);
        }
        else if (pumpkin)
        {
            animator.SetBool("pumpkin", true);
        }
    }

    IEnumerator FullGrow()
    {
        yield return new WaitForSeconds(21f);    //21�� ���
        GrowEnd = true;
    }
}
