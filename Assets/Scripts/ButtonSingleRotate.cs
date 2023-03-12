
using UnityEngine;

public class ButtonSingleRotate : ButtonRotate
{
    private bool _isRotate;
    private void RotateButton()
    {
        if (!_isRotate)
        {
            if (_arrow != null)
            {
                _arrow.RotationTo(toRight);
                _isRotate = true;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        GameObject other = col.gameObject;
        if (other.GetComponent<ArrowMove>())
        {
            _arrow = other.GetComponent<ArrowMove>();
            RotateButton();
        }
    }
}
