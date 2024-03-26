using UnityEngine;

public class TestDragAndDrop : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        objectPos.z = 0;
        transform.position = objectPos;
    }
}
