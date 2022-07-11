using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Big : MonoBehaviour
{
    [SerializeField] GameObject TargetOBJ;
    private Vector3 Target;
    public GameObject self_object;
    [SerializeField] GameObject popup;
    [SerializeField] float size = 1f; //원하는 사이즈
    [SerializeField] float speed; //커질 때의 속도
    [SerializeField] float movespeed;
    private float time;
    private Vector2 originScale; //원래 크기
    private Vector3 originPos;
    private bool canMove = false;

    private void Awake()
    {
        originScale = transform.localScale; //원래 크기 저장 
        originPos = transform.localPosition;
    }
    public void Big_Start()
    {
        canMove = true;
        SoundMng.instance.PlaySe(1);
        Target = TargetOBJ.transform.position;
        popup.SetActive(true);
        transform.SetAsLastSibling();
        StartCoroutine(Up());
        StartCoroutine(MoveToTarget());
    }
    IEnumerator Up()
    {
        while (transform.localScale.x < size)
        {
            transform.localScale = originScale * (1f + time * speed);
            time += Time.deltaTime;

            if (transform.localScale.x >= size)
            {
                time = 0;
                break;
            }
            yield return null;
        }
    }
    IEnumerator MoveToTarget()
    {
        Vector3 movespeed1 = Vector3.zero;
        while((transform.position != Target) && canMove)
        {
            transform.position = Vector3.SmoothDamp(transform.position, Target, ref movespeed1, movespeed);
            yield return null;
        }
    }

    public void Big_Stop()
    {
        transform.SetAsFirstSibling();
        canMove = false;
        self_object.transform.localScale = originScale;
        self_object.transform.localPosition = originPos;
        popup.SetActive(false);
    }
}
