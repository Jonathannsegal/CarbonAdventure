using UnityEngine;

using System.Collections;

public class Spin : MonoBehaviour{
	
	public float speed;
    public Vector3 rotationVector;
	
	void Update ()
	{
		transform.Rotate(rotationVector, speed * Time.deltaTime);
	}
}
