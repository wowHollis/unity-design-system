using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

[UxmlElement]
public partial class MyRadioButton : VisualElement
{
    private string buttonUssClassName = "procsButton";
    RadioButton _radioButton;
    public RadioButtonGroup _radioButtonGroup;

    public MyRadioButton()
    {
        _radioButton = new RadioButton();
        _radioButtonGroup = new RadioButtonGroup();

        Add(_radioButton);
        Add(_radioButtonGroup);

        Button button1 = new Button() { text = "Button1" };
        button1.clicked += OnButtonClick;
        button1.AddToClassList(buttonUssClassName);

        _radioButtonGroup.Add(button1);
        
        Button button2 = new Button() { text = "Button2" };
        button2.clicked += OnButtonClick;
        button2.AddToClassList(buttonUssClassName);
        _radioButtonGroup.Add(button2);

        // _radioButtonGroup.value = new ToggleButtonGroupState(0x01, _radioButtonGroup.value.length);
        // _radioButtonGroup.value = 1;
    }

    private void OnButtonClick()
    {
        Debug.Log("OnButtonClick");
    }
}
