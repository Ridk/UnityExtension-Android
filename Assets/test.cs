
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.EventSystems;
using System.Collections;

public class test : MonoBehaviour ,IPointerClickHandler{

    public void OnPointerClick(PointerEventData eventData)
    {
    #if UNITY_ANDROID
        AndroidCall.GetImage("BLEConnect","SetHead",MediaStoreType.Video);
    #endif
      // SetImage("/storage/emulated/0/MeRuRuLab.jpg");

    }

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {

    }

}
