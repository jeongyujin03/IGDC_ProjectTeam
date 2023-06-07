using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropdownController_graghic : MonoBehaviour
{
    TMP_Dropdown options;

    List<string> optionList = new List<string>();

    void Start()
    {
        options = this.GetComponent<TMP_Dropdown>();

        options.ClearOptions();

        optionList.Add("Option 1");
        optionList.Add("Option 2");
        optionList.Add("Option 3");
        optionList.Add("Option 4");

        options.AddOptions(optionList);
    }
}
