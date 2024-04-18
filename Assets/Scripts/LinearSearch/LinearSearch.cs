using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearSearch : MonoBehaviour
{
    public InputField selectRangeInputField;
    public InputField addInputField;
    public InputField searchInputField;

    private int arrayRange;

    public void ChangeArrayRange()
    {
        arrayRange = int.Parse(searchInputField.text);
        Debug.Log(arrayRange);
    }
}
