
using UnityEngine;
using UnityEngine.UI;

public class JampButton : MonoBehaviour
{
    [SerializeField] private Button _jumpButton;

    private void OnEnable()
    {
        _jumpButton.onClick.AddListener(Jump);
        _jumpButton.onClick.AddListener(Fight);
        Debug.Log("ENABLE");
    }
    // Update is called once per frame
   private  void Jump()
    {
        Debug.Log("JUMP");
    }

    private void Fight()
    {
        Debug.Log("Fight!");
    }

    private void OnDisable()
    {
       // _jumpButton.onClick.RemoveListener(Jump);
        _jumpButton.onClick.RemoveAllListeners();
        Debug.Log("DISABLE");
    }
}
