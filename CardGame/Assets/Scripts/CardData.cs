using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardData : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _topText;
    [SerializeField]
    private TextMeshProUGUI _bottomText;
    [SerializeField]
    private TextMeshProUGUI _leftText;
    [SerializeField]
    private TextMeshProUGUI _rightText;


    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        // Test to set text values
        _topText.text = Random.Range(1, 10).ToString();
        _bottomText.text = Random.Range(1, 10).ToString();
        _leftText.text = Random.Range(1, 10).ToString();
        _rightText.text = Random.Range(1, 10).ToString();

    }
}
