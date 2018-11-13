using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1_Handler : MonoBehaviour {

    public Button btnNext;
    public Button btnExit;
    public Button btnYes;
    public Button btnNo;
    public GameObject MsgPanel;

    // Use this for initialization
    void Start ()
    {
         //MsgPanel.gameObject.SetActive(false);
		 btnNext.onClick.AddListener(BtnNextOnClick);
         btnExit.onClick.AddListener(BtnExitOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BtnNextOnClick()
    {
        /// so something 
        Debug.Log("BtnNext On click!!");
        Application.LoadLevel("Scene2");
    }

    public void BtnExitOnClick()
    {
        /// so something 
        Debug.Log("BtnExit On click!!");
        //MsgPanel.SetActive(true);
        MsgPanel.SetActive(true);
        btnYes.onClick.AddListener(BtnYesOnClick);
        btnNo.onClick.AddListener(BtnNoOnClick);
        
    }

    private void BtnNoOnClick()
    {
        MsgPanel.SetActive(false);
    }

    private void BtnYesOnClick()
    {
        Application.Quit();
        
    }
}
