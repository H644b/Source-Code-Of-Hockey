using UnityEngine;

public class Puck : MonoBehaviour {

    // Note: use circle colliders on goalies for simple and effective bounce effect
	private Rigidbody2D body;

    private Vector2 startPos;

	// Use this for initialization
	void Start () {
            startPos =  transform.position;
            body = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
               if (Input.GetMouseButtonDown(0))
                   body.AddForce(transform.right * 5f);

		
		// on the Space bar press, call ReCenter()
	}

	public void ReCenter() {

        if (body != null)
        {
            body.velocity = new Vector2(0f, 0f);
            body.angularVelocity = 0f;
        }
        // starPos in the center of the ice ring, but not necessarily in the center
        // of the camera's viewport (which would be 0,0)
        transform.position = startPos;
        transform.rotation = Quaternion.identity;   // so that it goes in the same exact direction
    }

}
