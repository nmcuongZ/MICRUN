using UnityEngine;
using System.Collections;

public class SwitchMap : MonoBehaviour {

    public Camera camera;

    public GameObject[] map;

    public GameObject mapWorking;

	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 camerapos = camera.transform.position;
        Vector3 mappos = mapWorking.transform.position;
        
	    if(mappos.x < camerapos.x)
        {
            int k = Random.Range(0 , map.Length);

            Vector3 campos = camera.ScreenToWorldPoint(new Vector3(0,Screen.height/2,0));

            mapWorking = (GameObject) Instantiate( map[k] ,new Vector3( mapWorking.transform.position.x + 100 , campos.y ,0), Quaternion.identity);
            
            
        }
	}
}
