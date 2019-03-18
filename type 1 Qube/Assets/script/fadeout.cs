using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//パネルイメージ

public class fadeout : MonoBehaviour {
    float Fadespeed = 0.02f;//透明度が変わるスピード管理
    float Red, Green, Blue, Alfa;//パネルの色、不透明度を管理

    private bool isfadeout = true;//透明度を変更するパネルイメージ

    Image Fadeimage;//透明度を変更するパネルのイメージ


	// Use this for initialization
	void Start () {

        Fadeimage = GetComponent<Image>();
        Red = Fadeimage.color.r;
        Green = Fadeimage.color.g;
        Blue = Fadeimage.color.b;
        Alfa = Fadeimage.color.a;
	}
	
	// Update is called once per frame
	void Update () {
        if (isfadeout&& open.fade)
        {
            Invoke("Startfadeout", 2f);
        }
	}

    void Startfadeout()
    {
        Fadeimage.enabled = true; //パネルをon
        Alfa += Fadespeed;//不透明度を徐々に上げる
        Setalpha();//変更した透明度をパネルに反映
        if (Alfa >= 1) isfadeout = false;//完全に不透明になったら処理を抜ける 0か1

    }
    void Setalpha()
    {
        Fadeimage.color = new Color(Red, Green, Blue, Alfa);
    }
}
