using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<TestDragAndDrop>())
        {
            collision.transform.position = transform.position;
        }
    }
}
