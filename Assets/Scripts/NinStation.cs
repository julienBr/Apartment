using UnityEngine;

public class NinStation : MonoBehaviour, IUsable
{
    [SerializeField] private GameObject _screenOff;
    [SerializeField] private GameObject _screenOn;
    [SerializeField] private GameObject _voyantOff;
    [SerializeField] private GameObject _voyantOn;
    private bool isOn;

    public void UseObject()
    {
        if (isOn)
        {
            isOn = false;
            _screenOn.SetActive(false);
            _voyantOn.SetActive(false);
            _screenOff.SetActive(true);
            _voyantOff.SetActive(true);
        }
        else
        {
            isOn = true;
            _screenOn.SetActive(true);
            _voyantOn.SetActive(true);
            _screenOff.SetActive(false);
            _voyantOff.SetActive(false);
        }
    }
}