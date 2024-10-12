using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public int MoveSpeed;

    public Vector3 Point1;
    public Vector3 Point2;

    public bool MovingtoPoint1;

    public bool MovingtoPoint2;

    private void Update()
    {
        if(gameObject.transform.position == Point2)
        {
            MovingtoPoint1 = true;
            MovingtoPoint2 = false;
        }

        if (gameObject.transform.position == Point1)
        {
            MovingtoPoint2 = true;
            MovingtoPoint1 = false;
        }

        if(MovingtoPoint1)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, Point1, MoveSpeed * Time.deltaTime);
        }

        if (MovingtoPoint2)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, Point2, MoveSpeed * Time.deltaTime);
        }
    }
}
