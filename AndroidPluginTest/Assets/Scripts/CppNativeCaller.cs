using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class CppNativeCaller : MonoBehaviour
{
    private const string LIB_NAME = "__Internal";

    [DllImport(LIB_NAME)]
    private static extern int Add(int a, int b);

    [SerializeField] private TMP_Text _text;
    
    private void Start()
    {
        int a = 5;
        int b = 18;
        int result = Add(a, b);

        _text.text = $"Result: {result.ToString()}";
    }
}
