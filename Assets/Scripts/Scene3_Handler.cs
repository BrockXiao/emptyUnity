using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Handler : MonoBehaviour {

    public GameObject Canvas = null;

    private UIHandler MsgPanel = null;
	// Use this for initialization
	void Start ()
    {
        InitObject();
        CheckObject();
        
        
	}
    void InitObject()
    {
        try
        {
            GameObject _prefab = Resources.Load<GameObject>("Prefabbs\\MsgPanel");
            //Debug.Log(go.name);
            if (_prefab != null)
            {
                GameObject obj = Instantiate(_prefab);
                if (Canvas != null)
                {
                    obj.transform.parent = Canvas.transform;
                    // B.tf.parent = A.tf  //B在A裡面
                    obj.transform.localPosition = Vector3.zero;
                    MsgPanel = obj.GetComponent<UIHandler>();
                }
            }

        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

        // Update is called once per frame
        void Update ()
    {
		
	}
    void CheckObject()
    {
        try
        {
            if (MsgPanel != null)
            {
                MsgPanel.SetTitle("我在場景中設定東西!!!!");
            }
        }
        catch (Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }
}
