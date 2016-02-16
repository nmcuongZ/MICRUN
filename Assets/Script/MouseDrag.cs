using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {

    private bool small = false;
    private Vector3 dragStartPosition;
    private float dragStartDistance;
    private Vector3 dragEndPosition;
    private Vector3 originPosition;

    public GameObject hero;

    void Start() 
    {
        originPosition = hero.transform.localScale;
    }

    void OnMouseDown()
    {
        
        //dragStartDistance = (Camera.main.transform.position - transform.position).magnitude;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            //small = true;
            dragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))
        {
            //dragEnabled = false;
            dragEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if (dragStartPosition.y - dragEndPosition.y > 2)
        {
            StartCoroutine(TimeScaling());
            dragStartPosition = Vector3.zero;
            dragEndPosition = Vector3.zero;
            
        }

        
    }

    void OnMouseDrag()
    {
        //if (dragEnabled)
        //{
            Vector3 worldDragTo = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, dragStartDistance));
            transform.position = new Vector3(worldDragTo.x, dragStartPosition.y, dragStartPosition.z);
            
        //}
    }

    //Time to scale
    IEnumerator TimeScaling() 
    {
        hero.transform.localScale = originPosition/2;
        yield return new WaitForSeconds(2);
        hero.transform.localScale = originPosition;
    }
    
}
