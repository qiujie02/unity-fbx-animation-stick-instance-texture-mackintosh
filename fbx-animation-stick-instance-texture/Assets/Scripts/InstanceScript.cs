using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceScript : MonoBehaviour
{

	#region public property
	public GameObject target;
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

		//GameObject TargetInstance = Instantiate (target, new Vector3 (0f, 0f, 0f), Quaternion.identity) as GameObject;
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

		if(Input.GetKeyDown("space"))
		{
			if(GameObject.Find("Main"))
			{
				Destroy(GameObject.Find("Main"));
			}
			GameObject TargetInstance = Instantiate (target, new Vector3 (0f, 0f, 0f), Quaternion.identity) as GameObject;
			TargetInstance.name = "Main";
		}
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