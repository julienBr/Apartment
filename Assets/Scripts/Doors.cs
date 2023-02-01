using UnityEngine;

public class Doors : MonoBehaviour, IUsable
{
    private Animator _animator;
    private bool isOpened;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void UseObject()
    {
        if (isOpened)
        {
            _animator.SetBool("OpenClose", false);
            isOpened = false;
        }
        else
        {
            _animator.SetBool("OpenClose", true);
            isOpened = true;
        }
    }
}