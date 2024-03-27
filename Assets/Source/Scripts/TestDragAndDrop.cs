using UnityEngine;

public class TestDragAndDrop : MonoBehaviour
{
    private Vector2 _basePosition;

    private void Start()
    {
        _basePosition = transform.position;
    }

    private void OnMouseUp()
    {
        //transform.position = _basePosition;
    }

    private void OnMouseDrag()
    {
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectPos.z = 0;
        transform.position = objectPos;
    }
}
