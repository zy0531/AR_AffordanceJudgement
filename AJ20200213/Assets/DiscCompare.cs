using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI; // Required when Using UI elements.
using UnityEngine;

public class DiscCompare : MonoBehaviour
{
    //public GUIStyle styleButton;
    //public GUIStyle styleLabel;
    public GameObject Cueprefab;
    public Text DisPoles;
    public Text ShoulderWidth;
    public InputField inputfield;
    public Text success;
    public Text fail;

    private float timeShown; // results show 2s then disappear

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Distance between 2 Poles
        float dis = Vector3.Distance(GameObject.Find("PoleRight").transform.position, GameObject.Find("PoleLeft").transform.position) - GameObject.Find("PoleRight").transform.localScale.x;
        DisPoles.text = "Pole Gap Width:" + dis.ToString();
        // Shoulder width of participant
        float inputF = float.Parse(inputfield.text, System.Globalization.CultureInfo.InvariantCulture);
        ShoulderWidth.text = "Shoulder Width:" + inputfield.text;

        // compare dis
        GameObject.Find("Go").GetComponent<Button>().onClick.AddListener(() =>
        {
            timeShown = 0.0f;
            if (dis <= inputF)
            {
                fail.text = "Poles fell down!";
                success.text = "";
            }
            else
            {
                success.text = "You went through successfully!";
                fail.text = "";
            }
        }
        );
        // show 2s and then disappear
        timeShown += Time.deltaTime;
        if (timeShown >= 2.0f)
        {
            success.text = "";
            fail.text = "";
        }

        // show the shoulder width cue
        GameObject.Find("Cue").GetComponent<Button>().onClick.AddListener(() =>
        {
            Cueprefab.SetActive(true);
            Cueprefab.transform.localScale = new Vector3(inputF, 0.05f, 0.05f);
        }
        );
        Cueprefab.transform.position = GameObject.Find("First Person Camera").transform.position + new Vector3(-1.0F, -1.0f, 0.5F);
        Cueprefab.transform.rotation = GameObject.Find("First Person Camera").transform.rotation;
    }
}
