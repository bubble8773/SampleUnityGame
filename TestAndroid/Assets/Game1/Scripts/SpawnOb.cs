using UnityEngine;
using System.Collections;

public class SpawnOb : MonoBehaviour {

	public GameObject cylinder;
	public float timer;

	public int objNum;
	Vector3 spawn_pos;

    private float maxWidth, maxHeight;

    public float objLifeTime;
    // Use this for initialization
    void Start () {


		timer = 0.0f;
		//objNum = 20;
        maxWidth = Screen.width;
        maxHeight =  Screen.height;
		StartCoroutine (simpleSpawning ());
        Destroy (gameObject, objLifeTime);
        }
	
	IEnumerator  simpleSpawning()
	{
		yield return new WaitForSeconds (1.0f);
		for(int i = 0; i <= objNum; i++){
			while (timer >= 0) {
				yield return new WaitForSeconds (2.0f);
                spawn_pos = new Vector3(Random.Range(-maxWidth, maxWidth), 0.0f, Random.Range(-maxHeight, maxHeight));    //Random.Range (-417, 727), 0.0f, Random.Range (195,-200));

                Instantiate(cylinder, spawn_pos, Quaternion.identity);
                
                yield return new WaitForSeconds (2.0f);
			}
			yield return new WaitForSeconds(Random.Range(3.0f, 4.0f));
          
        }
	}

  

	void FixedUpdate () {
		timer += Time.deltaTime;
		if (timer >= 10) {
			
			timer = 0.0f;
		}
       
    }
}
