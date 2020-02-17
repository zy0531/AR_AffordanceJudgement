using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoleSpace : MonoBehaviour
{
    public int TranslateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 amountToMove = (GameObject.Find("PoleRight").transform.position - GameObject.Find("PoleLeft").transform.position).normalized;
        // Vector3 amountToMove = new Vector3(1, 0, 0);
        Vector3 left = GameObject.Find("PoleLeft").transform.position;
        Vector3 right = GameObject.Find("PoleRight").transform.position;
        GameObject.Find("Inward").GetComponent<Button>().onClick.AddListener(() =>
        {
            //Put your logic here
            
            GameObject.Find("PoleLeft").transform.position = Vector3.Lerp(left, left + amountToMove/40, 1);
            GameObject.Find("PoleRight").transform.position = Vector3.Lerp(right, right - amountToMove/40, 1);
        }
        );
        GameObject.Find("Outward").GetComponent<Button>().onClick.AddListener(() =>
        {
            GameObject.Find("PoleLeft").transform.position = Vector3.Lerp(left, left - amountToMove/40, 1);
            GameObject.Find("PoleRight").transform.position = Vector3.Lerp(right, right + amountToMove/40, 1);
        }
        );
    }

    //private void OnGUI()
    //{

    //    if (GUI.Button(new Rect(Screen.width - 500, 200, 400, 150), "Inward", style))
    //    {
    //        //Time.DeltaTime
    //        //https://answers.unity.com/questions/490687/when-to-use-timedeltatime.html
    //        GameObject.Find("PoleLeft").transform.Translate(Vector3.right * Time.deltaTime * TranslateSpeed);
    //        GameObject.Find("PoleRight").transform.Translate(Vector3.right * Time.deltaTime * (-TranslateSpeed));
    //        //GameObject.Find("PoleLeft").transform.Translate(Vector3.right);
    //        //GameObject.Find("PoleRight").transform.Translate(-Vector3.right);
    //    }
    //    if (GUI.Button(new Rect(100, 200, 400, 150), "Outward", style))
    //    {

    //        GameObject.Find("PoleLeft").transform.Translate(Vector3.right * Time.deltaTime * (-TranslateSpeed));
    //        GameObject.Find("PoleRight").transform.Translate(Vector3.right * Time.deltaTime * TranslateSpeed);
    //        //GameObject.Find("PoleLeft").transform.Translate(-Vector3.right);
    //        //GameObject.Find("PoleRight").transform.Translate(Vector3.right);
    //    }


    //} 

}
