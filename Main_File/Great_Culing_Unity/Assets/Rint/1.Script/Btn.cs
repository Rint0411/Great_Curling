using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Btn : MonoBehaviour
{
    public bool Button,Shot,Check;
    public GameObject Body,Canvas,Camera, Clean;
    public Transform Ball,Line;
    public Rigidbody rid;
    public Vector2 Point;
    public float LineWidth, Power,PowerLimit;
    public RectTransform ImageRectTransform;

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
        Invoke("CameraSet",0.5f);
    }
    private void Start()
    {
        Point = Body.transform.position;
    }

    private void Update()
    {
        if(Shot == false)
        {
            if(Button == true)
            {
                float x = Mathf.Clamp(Input.mousePosition.x,-350+Point.x,350+Point.x);
                float y = Mathf.Clamp(Input.mousePosition.y,0+Point.y,350+Point.y);
                transform.position = new Vector2(x,y);
                Power = (Mathf.Abs(transform.position.x-Point.x)+Mathf.Abs(transform.position.y-Point.y))/PowerLimit;
                
                Vector3 differenceVector = transform.position - (Vector3)Point;
        
                ImageRectTransform.sizeDelta = new Vector2(differenceVector.magnitude, LineWidth);
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
