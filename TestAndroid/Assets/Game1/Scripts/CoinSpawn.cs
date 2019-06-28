using UnityEngine;
using System.Collections;

public class CoinSpawn : MonoBehaviour {

	//public float coinRotSpeed = 0.0f;

	public GameObject coin;

    public float coinTimer;
	public int coinNum;

	Vector3 coin_spawn_pos;
    private float maxWidth, maxHeight;
    // Use this for initialization
    void Start () {
	
		coinTimer = 0.0f;
		coinNum = 20;
        maxWidth = Screen.width;
        maxHeight = Screen.height;
        StartCoroutine (CoinSpawning ());
        
    }

IEnumerator  CoinSpawning()
{
	yield return new WaitForSeconds (0.3f);
		for(int i = 0; i <= coinNum; i++){
		while (coinTimer >= 5) {
			yield return new WaitForSeconds (0.3f);
				//coin_spawn_pos = new Vector3 (Random.Range (-451,577), 46.0f, Random.Range (-18, 365));
                coin_spawn_pos = new Vector3(Random.Range(maxWidth, -maxWidth), 46.0f, Random.Range(maxHeight, -maxHeight));    
                Instantiate(coin, coin_spawn_pos, Quaternion.identity);
			
			yield return new WaitForSeconds (1.0f);
		}
		yield return new WaitForSeconds(Random.Range(3.0f, 4.0f));
	}
}

	void FixedUpdate()
	{
        //transform.eulerAngles += Vector3.up * coinRotSpeed * Time.deltaTime;
       // transform.Translate(Vector3.forward * 5.0f);
        coinTimer += Time.deltaTime;

		if (coinTimer >= 10) {
			
			coinTimer = 4.0f;
		}

	}
	

}
