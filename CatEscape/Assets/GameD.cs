using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameD : MonoBehaviour {

    GameObject hp;
    int playerHp;

	// Use this for initialization
	void Start () {
        this.hp = GameObject.Find("hp");
        playerHp = 10;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DecHp()
    {
        this.hp.GetComponent<Image>().fillAmount -= 0.1f;
        playerHp--;
    }
}
