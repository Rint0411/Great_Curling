using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBrush : MonoBehaviour
{
    Vector3 Move;
    public GameObject buble;
    int Cnt = 1;
    public bool check = true;
    
    private void Update()
    {
        if(check == true)
        StartCoroutine(s());
    }
    IEnumerator s()
    {
        check = false;
        while(true)
        {
            if (Cnt <= 10)
            {
                Move = this.gameObject.transform.forward * 3f;
                Cnt++;
            }
            else if (Cnt <= 20)
            {
                Move = this.gameObject.transform.forward * -3f;
                Cnt++;
            }
            else
            {
                Cnt = 1;
                if (Cnt <= 10)
                {
                    Move = this.gameObject.transform.forward * 3f;
                    Cnt++;
                }
                else if (Cnt <= 20)
                {
                    Move = this.gameObject.transform.forward * -3f;
                    Cnt++;
                }
            }
            GameObject set = Instantiate(buble);
            buble.transform.position = this.gameObject.transform.position;
            Destroy(set, 0.5f);
            this.gameObject.transform.position += Move * Time.deltaTime;

            yield return new WaitForSeconds(0.02f);
        }
        
    }
}
