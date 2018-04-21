using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickObject : Clickable {

    [SerializeField]
    private float _speed;

    private float _place;

    private Vector3 _Origin;    
	// Use this for initialization
	void Start () {
        _Origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void OnPointerEnter() {
        GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("Pointer Enter");
    }

    public override void OnPointerExit() {
        GetComponent<Renderer>().material.color = Color.white;
        Debug.Log("Pointer Exit");
    }

    public override void OnClick(int mouseButton) {
        Debug.Log("click button " + mouseButton);
        _place = Vector3.Distance(transform.position, Camera.main.transform.position);

    }

    public override void OnDrag() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(_place);
        transform.position = rayPoint;

        Debug.Log("Drag");
    }

    public override void OnDrop() {
        transform.position = _Origin;
        Debug.Log("Drop");
    }
}
