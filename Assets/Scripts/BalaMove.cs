using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMove : MonoBehaviour {
    public float projectileSpeed = 10f;
    //AUDIO
    public AudioClip ded1;
    public AudioClip ded2;
    private AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        //GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, projectileSpeed));
    }

    private void OnTriggerEnter(Collider other)
    {
        float rand = Random.Range(1.0f, 2.0f);

        if (rand > 1.5f)
            source.PlayOneShot(ded2,rand);
        else
            source.PlayOneShot(ded1,rand);

        Destroy(other.gameObject);
        //Destroy(this.gameObject);
    }
}
