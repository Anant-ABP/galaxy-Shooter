using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [SerializeField] string[] Nextdialogue;
    [SerializeField] TMP_Text DiaglogueSpeak;
    int current = 0;
    public void nextdialogueupdate()
    {
        current++;
        DiaglogueSpeak.text = Nextdialogue[current];
    }
}
