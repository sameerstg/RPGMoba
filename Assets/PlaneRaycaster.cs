using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRaycaster : MonoBehaviour
{
    public Vector3 leftClickedPosition;
    Plane plane = new Plane(Vector3.up, 0);
    public GameObject pointer;
    internal InputSystem.DelegateAction leftclickAction;
    private void Awake()
    {
        leftclickAction = RaycastPlane;
    }
    void RaycastPlane()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out float distance))
        {
            leftClickedPosition = ray.GetPoint(distance);
            Instantiate(pointer, leftClickedPosition, Quaternion.identity);

        }


    }

}
