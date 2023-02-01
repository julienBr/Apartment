using UnityEngine;

public class DemiDoors : MonoBehaviour, IUsable
{
    [SerializeField] private Animator _animator;
    private bool isOpened;
    
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