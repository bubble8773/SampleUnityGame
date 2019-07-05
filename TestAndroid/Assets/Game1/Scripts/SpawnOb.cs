using UnityEngine;
using System.Collections;

public class SpawnOb : MonoBehaviour {

	//public GameObject enemy;
	public int objNum;
	Vector3 spawn_pos;

    private float maxWidth, maxHeight, timer;
    private int health;
    
    // Use this for initialization
    void Start () {
        
		timer = 0.0f;
		//objNum = 20;
        maxWidth = Screen.width;
        maxHeight =  Screen.height;
		StartCoroutine (simpleSpawning ());
        health = 3;
    }
	
	IEnumerator  simpleSpawning()
	{
		yield return new WaitForSeconds (1.0f);
		for(int i = 0; i <= objNum; i++){
			while (timer >= 0) {
				yield return new WaitForSeconds (5.0f);
                spawn_pos =  new Vector3 (Random.Range(-1000, 195),0.0f, 0.0f ); //new Vector3(Random.Range(-maxWidth, maxWidth), 0.0f, Random.Range(-maxHeight, maxHeight));

        Instantiate(this, spawn_pos, Quaternion.identity);
                
                yield return new WaitForSeconds (5.0f);
			}
			yield return new WaitForSeconds(Random.Range(3.0f, 4.0f));
          
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            health--;
            if (health == 0)
            {
                //this.gameObject.SetActive(false);
                Destroy(this.gameObject);
                Debug.Log("Enemy distroyed");

            }
        }
        Debug.Log("Enemy health = " +health);
    }


    void FixedUpdate () {
		timer += Time.deltaTime;
		if (timer >= 10) {
			
			timer = 0.0f;
		}
       
    }
}
