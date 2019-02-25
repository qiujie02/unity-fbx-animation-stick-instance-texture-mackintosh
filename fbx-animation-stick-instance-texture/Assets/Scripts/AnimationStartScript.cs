using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStartScript : MonoBehaviour
{
	
	#region public property
	public Animator animator;
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

		//animator = GetComponent<Animator> ();
		animator.Play("CINEMA_4D_Main");
	}
	void OnEnable()
	{
		//Debug.Log ("OnEnable");
		//オブジェクトがアクティブになった時

		animator.Play("CINEMA_4D_Main");
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