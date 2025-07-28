using TMPro;
using UnityEngine;
using UnityEngine.Localization;

public class StringLocalizer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private LocalizedString _localizedText;
    void OnEnable() => _localizedText.StringChanged += UpdateString;
    void OnDisable() => _localizedText.StringChanged -= UpdateString;
    void UpdateString(string s) => _text.text = s;
}
