using UnityEngine;
using TMPro;

public class DisplayText : MonoBehaviour
{
    // Reference to the TextMeshProUGUI component in the Unity UI
    public TextMeshProUGUI textBox;
    private float clearDelay = 5f;
    public AudioSource writer;
    public AudioClip typeDing;

    public void fishInfo(string info)
    {
        // Check if the TextMeshProUGUI component is assigned
        if (textBox == null)
        {
            Debug.LogError("Text Box not assigned. Please assign a TextMeshProUGUI component in the inspector.");
        }
        else
        {
            // Set the text of the TextMeshProUGUI component to the desired string
            textBox.text = info;
            writer.PlayOneShot(typeDing, 0.7f);
            Invoke("ClearText", clearDelay);
        }
    }

    private void ClearText()
    {
        // Clear the text of the TextMeshProUGUI component
        textBox.text = "";
    }
}
