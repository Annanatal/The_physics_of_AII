using UnityEngine;

public class FireShell : MonoBehaviour {

    public GameObject bullet;
    public GameObject turret;

    void CreateBullet() {

        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space)) {
        
            CreateBullet();
        }
    }
}
