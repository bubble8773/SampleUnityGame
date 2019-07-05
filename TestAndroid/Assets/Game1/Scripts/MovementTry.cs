using UnityEngine;
using System.Collections;

public class MovementTry : MonoBehaviour {

    RaycastHit rayCastHit;
	private float rayDist = 10000;

    public GameObject bullet;
    public float objLifeTime, bulltetSpeed;

    void Update () {

        GameObject projectile = null;
        GameObject Player = GameObject.Find ("Player");//"OldSingleCut");//
        //Ray camRay = Camera.main.ScreenPointToRay (AndroidInput.GetSecondaryTouch (0).position);//(Input.mousePosition);

        Player.transform.LookAt(GameObject.FindGameObjectWithTag("Enemy").transform);
        if (GameData.instance.gameOverPopUp.activeInHierarchy || GameData.instance.gameWinPopUP.activeInHierarchy || GameData.instance.pausePopUp.activeInHierarchy)
        {
            return;
        }
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(camRay, out rayCastHit, rayDist))
        {
            //Debug.Log(rayCastHit.collider.name );
            if (rayCastHit.collider.name == "Plane")
            {
                Player.transform.position = rayCastHit.point;
            }
        }
        Debug.DrawRay(camRay.origin, camRay.direction * rayDist, Color.cyan);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectile = Instantiate(bullet, GameObject.Find("Gun").transform) as GameObject;

        }
        if (projectile)
        {
            projectile.GetComponent<Rigidbody>().velocity += transform.TransformDirection(Vector3.forward * Time.deltaTime * bulltetSpeed *-1);
            Destroy(projectile, objLifeTime);
        }
        
    }
}
