using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {

    public GameObject enemy;
    Vector3 carpos;
    int time,delay,dif;
    float poz,oldPoz;

	// Use this for initialization
	void Start () {
        delay = 50;
        dif = 0;
        oldPoz = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time = Time.frameCount;
        if (dif < 24)
        {
            if (time % 50 == 0)
                dif += 1;
        }
        if(time == delay)
        {
            if(oldPoz>=0)
                poz = Random.Range (-2.2f,oldPoz);
            else
                poz = Random.Range(oldPoz, 2.2f);
            oldPoz = poz;
            delay = time + Random.Range(25-dif, 30-dif);
            if(poz >= 0)
            carpos = new Vector3(poz, transform.position.y, transform.position.z);
            Instantiate(enemy, carpos, transform.rotation);
        }

	}
}
