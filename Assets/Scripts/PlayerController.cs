using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Directions
{
    Forward,
    Left,
    Right,
    Backward
};


public class PlayerController : MonoBehaviour
{
    private Transform _TransformPlayer;

    // Start is called before the first frame update
    void Start()
    {
        _TransformPlayer = gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveForward();
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Rotate(Directions.Left);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Rotate(Directions.Right);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Rotate(Directions.Backward);
        }

    }

    public void MoveForward()
    {
        _TransformPlayer.Translate(new Vector3(0f, 0f, 1f));
    }


    public void Rotate(Directions direction)
    {

        if (direction == Directions.Left)
        {
            _TransformPlayer.forward =  - _TransformPlayer.right;
        } else if (direction == Directions.Backward)
        {
            _TransformPlayer.forward = -_TransformPlayer.forward;

        }
        else
        {
            _TransformPlayer.forward = _TransformPlayer.right;

        }

    }


    public void Restart()
    {
        _TransformPlayer.SetPositionAndRotation(new Vector3(0f, 0.5f, 0f), Quaternion.identity);
    }

}
