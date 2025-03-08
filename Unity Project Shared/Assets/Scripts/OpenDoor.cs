using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    private Animator anim;

    private bool IsAtDoor = false;

    [SerializeField] private TextMeshProUGUI CodeText;
    private string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        CodeText.text = codeTextValue;

        if(codeTextValue == safeCode)
        {
            anim.SetTrigger("OpenDoor");
            CodePanel.SetActive(false);
        }

        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if(Input.GetKey(KeyCode.E) && IsAtDoor == true)
        {
            CodePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        CodePanel.SetActive(false);
    }
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}