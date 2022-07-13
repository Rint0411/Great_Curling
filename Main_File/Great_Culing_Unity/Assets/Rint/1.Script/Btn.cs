using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Btn : MonoBehaviour
{
    public bool Button,Shot,Check;
    public GameObject Body,Canvas,Camera, Clean,sound;
    public Transform Ball,Line, PreventionPoint;
    public Rigidbody rid;
    public Vector2 Point;
    public float LineWidth, Power,PowerLimit;
    public RectTransform ImageRectTransform;
    public int Prevention;

    public void Down()
    {
        Button = true;
    }
    public void Up()
    {
        rid.AddRelativeForce(new Vector3(0,0,Power),ForceMode.Impulse);
        Button = false;
        Shot = true;
        transform.position = Point;
        ImageRectTransform.sizeDelta = new Vector2(0, 0);
        Canvas.SetActive(false);
        sound.SetActive(true);
        Invoke("CameraSet",0.5f);
    }
    private void Start()
    {
        Point = Body.transform.position;
        Prevention = Mathf.CeilToInt(PreventionPoint.transform.position.x) - Mathf.CeilToInt(Point.x);
    }

    private void Update()
    {
        if(Shot == false)
        {
            if(Button == true)
            {
                float x = Mathf.Clamp(Input.mousePosition.x,-Prevention + Point.x, Prevention + Point.x);
                float y = Mathf.Clamp(Input.mousePosition.y,0+Point.y, Prevention + Point.y);
                transform.position = new Vector2(x,y);
                float LineSize = (Vector3.Distance(transform.position, Point) / Vector3.Distance(PreventionPoint.position, Point) * 100);
                Power = LineSize  / PowerLimit;
                
                Vector3 differenceVector = transform.position - (Vector3)Point;
        
                ImageRectTransform.sizeDelta = new Vector2(LineSize*5, LineWidth);
                ImageRectTransform.pivot = new Vector2(0, 0.5f);
                ImageRectTransform.position = Point;
                float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
                ImageRectTransform.rotation = Quaternion.Euler(0, 0, angle);
                Ball.rotation = Quaternion.Euler(0, -Line.rotation.eulerAngles.z+90, 0);
            }

        }
        
    }

    void CameraSet()
    {
        VariableMng.VRBMNG.Start = true;
        Check = !Check;
        Camera.SetActive(Check);
        Clean.SetActive(true);
        VariableMng.VRBMNG.CameraSet.SetActive(!Check);
        VariableMng.VRBMNG.Turn += 1;

        Destroy(Canvas);
    }

}
