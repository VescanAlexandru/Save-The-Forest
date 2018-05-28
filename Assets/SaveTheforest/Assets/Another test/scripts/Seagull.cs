using UnityEngine;
using System.Collections;

public class Seagull : MonoBehaviour 

{
    public GameObject Pipox;
	private const float AVERAGE_VELOCITY	= 0.5f;
	
	private static Vector3 ORIGIN			= new Vector3(46.2f, 11.05f, 12.7f);
	public float RADIUS				= 30f;

	private Vector3	_position				= Vector3.zero;	
	private Vector3	_direction				= Vector3.zero;

    public float _velocity = 0;
	
	


	void Start ()
	{
		_position			= gameObject.transform.position;
		_direction			= gameObject.transform.forward;



        //set an initial random velocity and drift
        _velocity = 0.08f;
		
	}


	void FixedUpdate () 
	{
		 UpdatePosition();
	}


	private void UpdatePosition()
	{
		//find the direction and distance to the origin of the flock bounds
		Vector3 direction_to_origin		= Vector3.Normalize(ORIGIN - gameObject.transform.position);
		float distance_to_origin		= Vector3.Distance(ORIGIN, gameObject.transform.position) - RADIUS * 1f;
		
		
		//interpolate the values for the new direction by how far the gull is from the edges of the origin
		float interpolation			= _velocity/RADIUS;

		if(distance_to_origin < RADIUS)
		{
			//pick a random direction and go there if within the radius
			_direction	=  Vector3.Lerp(_direction, Random.insideUnitCircle, interpolation * 10);
		}
		else
		{
			//else point back towards the origin
			_direction	=  Vector3.Lerp(_direction, direction_to_origin, interpolation);
		}
		
		
		_direction				= Vector3.Normalize(_direction);


		//look towards where the gull is flying
		gameObject.transform.LookAt(gameObject.transform.position + _direction);


		//move the gull forward along that path
		gameObject.transform.position	= gameObject.transform.position + _direction * _velocity;

		
	}
    void Update()
    {
        gameObject.GetComponentInChildren<BoxCollider>().enabled = false;
    }
}
