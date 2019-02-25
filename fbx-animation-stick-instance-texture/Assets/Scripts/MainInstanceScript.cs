using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainInstanceScript : MonoBehaviour
{

	#region public property
	public GameObject InstanceTargetPrefabs;
	public GameObject ParentObject;
	#endregion

	#region private propety
	#endregion

	#region Unity Methods
	void Awake()
	{
		//Debug.Log ("Awake");

		for (int i = 0; i < 100; i++)
		{
			GameObject instance = Instantiate (InstanceTargetPrefabs, new Vector3 (0f, 0f, 0f), Quaternion.identity) as GameObject;

			instance.name = "cube_animation_" + (i +1);

			if (instance.name == "cube_animation_1") {
				instance.name = "cube_animation";
			}

			instance.transform.parent = ParentObject.transform;
		}
	}
	void Start()
	{
		//Debug.Log ("Start");
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