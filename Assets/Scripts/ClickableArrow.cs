using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickableArrow : MonoBehaviour, IPointerClickHandler
{
    public Directions ArrowDirection;

    private PlayerController _PlayerController;

    void Start()
    {
        _PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    
    public void OnPointerClick(PointerEventData eventData)
    {
        // OnClick code goes here ...
        if (ArrowDirection == Directions.Forward)
        {
            _PlayerController.MoveForward();
        } else
        {
            _PlayerController.Rotate(ArrowDirection);
        }
        
    }
}


