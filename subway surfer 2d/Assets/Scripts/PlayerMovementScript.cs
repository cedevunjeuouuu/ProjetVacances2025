using NUnit.Framework.Constraints;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    [SerializeField] private Vector3[] positions;
    private int actualPos = 0;

    public void Start()
    {
        if (positions.Length % 2 == 0)
        {
            Debug.LogError("The number of positions must be odd");
            return;
        }
        actualPos = positions.Length / 2;
    }

    public void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
    }

    public void MoveLeft()
    {
        if (actualPos > 0)
        {
            actualPos--;
            transform.position = positions[actualPos];
        }
    }
    public void MoveRight()
    {
        if (actualPos < positions.Length - 1)
        {
            actualPos++;
            transform.position = positions[actualPos];
        }
    }
}
