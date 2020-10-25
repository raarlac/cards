using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; using TMPro;

public class CardScript : MonoBehaviour
{
    [SerializeField] GameObject cardTemplate;
    GameObject currentCard;
    [SerializeField] TextAsset text;
    string[] linesInFile;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        int i = 0;
        yield return new WaitForSeconds(1f);
        while (i<10)
        {
            yield return new WaitForSeconds(0.1f);
            currentCard = Instantiate(cardTemplate);
            i++;
        }
        linesInFile = new string[] { "egbwrkjgbwrgwkg wrhk gt\na) rjkgbrkjghet\nheht\nethethteh ","2 ", " \ndhdhdthdfs\n" };
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            currentCard.GetComponent<Animator>().SetTrigger("turn");
            currentCard.GetComponentInChildren<TextMeshProUGUI>().text = linesInFile[0];
        }
    }
}
