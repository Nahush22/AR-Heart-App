using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectObj : MonoBehaviour
{
    // private Text label;
    //private GameObject bg_label;
    private GameObject textHeart1,textHeart2,textHeart3,textHeart4,textHeart5,textHeart6,textHeart7,textHeart8,textHeart9,textHeart10,textHeart11,textHeart12;
    // private TextMesh textHeart;

    // Start is called before the first frame update
    void Start()
    {

        // textHeart = GameObject.Find("textheart").GetComponent<TextMesh>();

        textHeart1 = GameObject.Find("textheart1");
        textHeart1.SetActive(false);

        textHeart2 = GameObject.Find("textheart2");
        textHeart2.SetActive(false);

        textHeart3 = GameObject.Find("textheart3");
        textHeart3.SetActive(false);

        textHeart4 = GameObject.Find("textheart4");
        textHeart4.SetActive(false);

        textHeart5 = GameObject.Find("textheart5");
        textHeart5.SetActive(false);

        textHeart6 = GameObject.Find("textheart6");
        textHeart6.SetActive(false);

        textHeart7 = GameObject.Find("textheart7");
        textHeart7.SetActive(false);

        textHeart8 = GameObject.Find("textheart8");
        textHeart8.SetActive(false);

        textHeart9 = GameObject.Find("textheart9");
        textHeart9.SetActive(false);

        textHeart10 = GameObject.Find("textheart10");
        textHeart10.SetActive(false);

        textHeart11 = GameObject.Find("textheart11");
        textHeart11.SetActive(false);

        textHeart12 = GameObject.Find("textheart12");
        textHeart12.SetActive(false);

        // bg_label = GameObject.Find("textheart");
        // bg_label.SetActive(false);
    }

    //Update is called once per frame
    void Update()
    {

#if UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // bg_label.SetActive(true);
                // label.text = hit.transform.name.ToString();
            }
            else
            {
                // bg_label.SetActive(false);
                // label.text = "";
            }
        }

#elif UNITY_ANDROID
        if ((Input.GetTouch(0).phase == TouchPhase.Stationary) || (Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(0).deltaPosition.magnitude < 1.2f))
        {
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                string a = hit.transform.name.ToString();

                if(a=="one")
                {
                    textHeart1.SetActive(true);
                    textHeart2.SetActive(true);
                    textHeart3.SetActive(true);
                }
                else if(a=="two")
                {
                    textHeart4.SetActive(true);
                    textHeart5.SetActive(true); 
                }
                else if(a=="three")
                {
                    textHeart6.SetActive(true);
                    textHeart7.SetActive(true);
                    textHeart8.SetActive(true);
                    textHeart9.SetActive(true);
                    textHeart10.SetActive(true);
                    textHeart11.SetActive(true);
                    textHeart12.SetActive(true);
                }


                // textHeart.text = hit.transform.name.ToString();
                // bg_label.SetActive(true);
                // label.text = hit.transform.name.ToString();
            }
            else
            {
                textHeart1.SetActive(false);
                textHeart2.SetActive(false);
                textHeart3.SetActive(false);
                textHeart4.SetActive(false);
                textHeart5.SetActive(false);
                textHeart6.SetActive(false);
                textHeart7.SetActive(false);
                textHeart8.SetActive(false);
                textHeart9.SetActive(false);
                textHeart10.SetActive(false);
                textHeart11.SetActive(false);
                textHeart12.SetActive(false);

                // textHeart.text = "";
                // bg_label.SetActive(false);
                // label.text = "";
            }
		}
#endif

    }
}
