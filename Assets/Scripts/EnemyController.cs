using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    Animation anim;
    BoxCollider boxCollider;
    public int hp = 100;
    public Image hpGauge;
    int fullHp;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animation>();
        boxCollider = GetComponent<BoxCollider>();
        fullHp = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "cutter01")
        {
            hp -= 50;
            hpGauge.fillAmount = (float)hp / fullHp;
            print(hp);
            if (hp <= 0)
            {
                anim.Play("Allosaurus_Die");
                Destroy(boxCollider);
            }
        } 
    }
}
