using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fruit : MonoBehaviour
{
    public Text ThisText;
    public Image imagePrefab;
    public List<string> itemList = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    public Sprite Apple;
    public Sprite Orage;
    public Sprite Carrot;
    public Sprite Strawberry;
    public Sprite Banana;


    // Start is called before the first frame update
    void Start()
    {
        images.Add(Apple);
        images.Add(Orage);
        images.Add(Carrot);
        images.Add(Strawberry);
        images.Add(Banana);

        itemList.Add("Apple");
        itemList.Add("Orage");
        itemList.Add("Carrot");
        itemList.Add("Strawberry");
        itemList.Add("Banana");
  
        ThisText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return))
        {
            imagePrefab.GetComponent<Image>().sprite = images[0];
            itemList.RemoveAt(0);
            images.RemoveAt(0);
            itemList.Add("");
        }
        foreach (string str in itemList)
        {
            ThisText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }
    }


}