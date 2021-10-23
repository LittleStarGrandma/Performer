using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float movementInputDirection;
    private Rigidbody2D rb;

    public float movementSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        if (Input.GetKeyDown(KeyCode.B))
        {
            if(UIManager.Instance.GetPanel<DebugPanel>()==null)
            UIManager.Instance.ShowPanel<DebugPanel>("Debug/");
            else
            {
                UIManager.Instance.HidePanel<DebugPanel>(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (UIManager.Instance.GetPanel<PausePanel>() == null)
            {
                UIManager.Instance.ShowPanel<PausePanel>();
                
            }
        }
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if (UIManager.Instance.GetPanel<PhoneMemoPanel>() == null)
                UIManager.Instance.ShowPanel<PhoneMemoPanel>("Phone/Res/");
            else
            {
                UIManager.Instance.HidePanel<PhoneMemoPanel>(false);
            }
        }
    }
    private void FixedUpdate()
    {
        ApplyMovement();
    }
    private void CheckInput()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }
    private void ApplyMovement()
    {
        rb.velocity = new Vector2(movementSpeed*movementInputDirection,rb.velocity.y);

    }

}
