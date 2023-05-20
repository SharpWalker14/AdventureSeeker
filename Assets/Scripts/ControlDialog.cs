using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlDialog : MonoBehaviour
{
    [SerializeField] DialogPlane blueprint;
    [SerializeField] DialogZone[] blueprintArrays;
    [SerializeField] Text textNarrative;
    [SerializeField] Text AltLeft;
    [SerializeField] Text AltCentral;
    [SerializeField] Text AltRight;

    [HideInInspector]
    public bool clickable;
    [HideInInspector]
    public bool onChatting;
    [SerializeField] GameObject buttons, narrative;
    public Font playableCharacter, nonPlayableCharacter;
    [HideInInspector]
    public int actNumber;

    private GameObject[] backgrounds;
    void Start()
    {

        onChatting = false;
        clickable = false;
        backgrounds= GameObject.FindGameObjectsWithTag("Background");
        for (int i = 0; i < backgrounds.Length; i++)
        {
            backgrounds[i].name += " (" + i + ")";
        }
        Trayectory();
    }
    void TextMood()
    {
        onChatting = true;
        textNarrative.text = blueprint.narrativeText;
        if (blueprint.protagonist)
        {
            textNarrative.font = playableCharacter;
        }
        else
        {
            textNarrative.font = nonPlayableCharacter;
        }
        switch (blueprint.alternative.Length)
        {
            case 0:
                AltCentral.transform.parent.gameObject.SetActive(false);
                AltLeft.transform.parent.gameObject.SetActive(false);
                AltRight.transform.parent.gameObject.SetActive(false);
                clickable = true;
                break;
            case 1:
                AltLeft.transform.parent.gameObject.SetActive(false);
                AltRight.transform.parent.gameObject.SetActive(false);
                AltCentral.transform.parent.gameObject.SetActive(true);
                AltCentral.text = blueprint.alternative[0];

                clickable = false;
                break;
            case 2:

                AltCentral.transform.parent.gameObject.SetActive(false);
                AltLeft.transform.parent.gameObject.SetActive(true);
                AltRight.transform.parent.gameObject.SetActive(true);
                AltLeft.text = blueprint.alternative[0];
                AltRight.text = blueprint.alternative[1];
                clickable = false;
                break;
            case 3:
                AltCentral.transform.parent.gameObject.SetActive(true);
                AltLeft.transform.parent.gameObject.SetActive(true);
                AltRight.transform.parent.gameObject.SetActive(true);
                AltLeft.text = blueprint.alternative[0];
                AltCentral.text = blueprint.alternative[1];
                AltRight.text = blueprint.alternative[2];
                clickable = false;
                break;
        }
        Trayectory();
    }
    void Update()
    {

    }

    public void Clicker()
    {
        if (Input.GetMouseButtonDown(0) && clickable)
        {
            if (blueprint.dialogEnd)
            {
                onChatting = false;
                Trayectory();
            }
            else
            {
                blueprint = blueprintArrays[actNumber].blueprint[blueprint.arrayReferences[0]];
                TextMood();
            }
        }
    }
    public void ButtonControl(int index)
    {
        if (blueprint.alternative.Length == 1)
        {
            index = 0;
        }
        else if (blueprint.alternative.Length == 2 && index == 2)
        {
            index = 1;
        }
        blueprint = blueprintArrays[actNumber].blueprint[blueprint.arrayReferences[index]];
        TextMood();
    }
    public void StartChat(string codeTitle)
    {
        for (int i = 0; i < blueprintArrays.Length; i++)
        {
            if (codeTitle == blueprintArrays[i].dialogName && blueprintArrays[i].blueprint.Length != 0)
            {
                Debug.Log("Nom");
                blueprint = blueprintArrays[i].blueprint[0];
                actNumber = i;
                TextMood();
                i += blueprintArrays.Length;
            }
        }
    }
    void Trayectory()
    {
        if (onChatting)
        {
            Time.timeScale = 0;
            narrative.SetActive(true);
            buttons.SetActive(false);
            BackgroundShow(true);
        }
        else
        {
            Time.timeScale = 1;
            narrative.SetActive(false);
            buttons.SetActive(true);
            BackgroundShow(false);
        }
    }

    void BackgroundShow(bool open)
    {
        SpriteRenderer[] backgrounders = new SpriteRenderer[backgrounds.Length];
        for (int i = 0; i < backgrounders.Length; i++)
        {
            backgrounders[i] = backgrounds[i].GetComponent<SpriteRenderer>();
            if (open)
            {
                backgrounders[i].sortingOrder = 1;
            }
            else
            {
                backgrounders[i].sortingOrder = -1;
            }
        }
    }
}
