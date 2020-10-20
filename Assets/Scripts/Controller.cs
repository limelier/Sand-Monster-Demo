using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator _animator;

    private static readonly int Buried = Animator.StringToHash("Buried");
    private static readonly int Swipe = Animator.StringToHash("Swipe");

    // Start is called before the first frame update
    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetBool(Buried, !_animator.GetBool(Buried));
        }

        if (Input.GetKeyDown(KeyCode.A) && _animator.GetBool(Buried))
        {
            _animator.SetTrigger(Swipe);
        }
    }
}
