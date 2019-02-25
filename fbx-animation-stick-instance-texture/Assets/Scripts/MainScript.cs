using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{

	#region public property
	public GameObject parent;
	#endregion

	#region private propety
	#endregion

	#region Unity Methods
	void Awake()
	{
		//Debug.Log ("Awake");
	}
	void Start()
	{
		//Debug.Log ("Start");

		parent.SetActive (true);
	}
	void OnEnable()
	{
		//Debug.Log ("OnEnable");
		//オブジェクトがアクティブになった時
	}
	void OnDisable()
	{
		//Debug.Log ("OnDisable");
		//オブジェクトが非アクティブになった時
	}
	void Update()
	{
		//Debug.Log ("Update");
	}
	void FixedUpdate()
	{
		//Debug.Log ("FixedUpdate");
	}
	#endregion

	#region public method
	#endregion

	#region private method
	#endregion
}