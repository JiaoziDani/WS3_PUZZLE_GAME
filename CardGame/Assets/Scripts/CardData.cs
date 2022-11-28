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

    public int topValue;
    public int bottomValue;
    public int leftValue;
    public int rightValue;


    // Start is called before the first frame update
    void Awake()
    {
        if(GetComponent<EnemyData>() == null)
        {
            Init();
        }

    }

    // Update is called once per frame
    void Update()
    {
        _topText.text = topValue.ToString();
        _bottomText.text = bottomValue.ToString();
        _leftText.text = leftValue.ToString();
        _rightText.text = rightValue.ToString();
    }

    private void Init()
    {
        // Test to set text values
        
        topValue = Random.Range(1, 10);
        bottomValue = Random.Range(1, 10);
        leftValue = Random.Range(1, 10);
        rightValue = Random.Range(1, 10);

        _topText.text = topValue.ToString();
        _bottomText.text = bottomValue.ToString();
        _leftText.text = leftValue.ToString();
        _rightText.text = rightValue.ToString();

    }
}
