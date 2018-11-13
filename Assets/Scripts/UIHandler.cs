using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour {

    #region //UI Setting Config (Name)
    private const string TITLE_NAME = "BBB";
    #endregion

    // Use this for initialization
    private Text TextBBB { get; set; }
    private Text textAYS { get; set; }
    private Button btnYes { get; set; }
    private Text textYes { get; set; }
    private Button btnNo { get; set; }
    private Text textNo { get; set; }
    private void Awake()
    {
        ScanObject();

        InitObject();
    }

    private void ScanObject()
    {
        try
        {
            #region //Scan
            //scan
            int childCount = this.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = this.transform.GetChild(i).gameObject;
                Debug.Log("Child Index = " + i + " Name = " + go.name);
                if (go.name.Equals("BBB"))
                {
                    TextBBB = go.GetComponent<Text>();
                }
                if (go.name.Equals("are you sure?"))
                {
                    textAYS = go.GetComponent<Text>();
                }
                if (go.name.Equals("BtnYes"))
                {
                    btnYes = go.GetComponent<Button>();
                    textYes = go.GetComponentInChildren<Text>();//最短模式
                    /*
                     int c = btnYes.transform.childCount
                     */
                }
                if (go.name.Equals("BtnNo"))
                {   
                    btnNo = go.GetComponent<Button>();
                }

            }            
            #endregion
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }

       
    }

    private void InitObject()
    {
        #region //Init
        try
        {
        //init
            if (TextBBB != null)
            {
                TextBBB.text = "I M Right!";
            }
            if (textAYS != null)
            {
                textAYS.text = "這個是測試的文字\n換行測試\n換行測試2";
            }
            if (textYes != null)
            {
                textYes.text = "OK";
            }
            if (textNo != null)
            {
                textNo.text = "否";
            }
            if(btnNo !=null)
            {
                btnNo.gameObject.SetActive(false);
            }

        }
        catch(Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
        #endregion


    }

    public void SetTitle(string title)
    {
        try
        {
            TextBBB.text = title;
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
