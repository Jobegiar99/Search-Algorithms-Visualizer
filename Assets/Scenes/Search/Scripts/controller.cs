using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject goal = null;
    public GameObject start = null;

    public GameObject floor;
    public List<Sprite> sprites = new List<Sprite>();

    public string selectedFloorType = "Path";

    public int selectedSpriteIndex = 0;

    void Start()
    {
        for(int row = -50; row < 51;  row++)
        {
            for(int column = -25; column < 26; column++)
            {

                GameObject tempFloor = Instantiate(floor, new Vector2(row, column), Quaternion.identity);
                tempFloor.name = row.ToString() + "," + column.ToString();

            }
        }
    }

    public void updateSelectedFloorType(string newSelectedFloorType)
    {
        selectedFloorType = newSelectedFloorType;
        handleTypeChange();
    }

    public void checkSprite()
    {
        switch (selectedFloorType )
        {
            case "Normal":
                {
                    selectedSpriteIndex = 0;
                }
                break;
            case "Path":
                {
                    selectedSpriteIndex = 1;
                }
                break;

            case "Wall":
                {
                    selectedSpriteIndex = 2;
                }
                break;

            case "Start":
                {
                    selectedSpriteIndex = 3;
                }
                break;

            case "Goal":
                {
                    selectedSpriteIndex = 4;
                }
                break;
        }
    }

    void handleTypeChange( )
    {
        checkSprite();
        GameObject.Find("Selected").GetComponent<Image>().sprite = sprites[selectedSpriteIndex];
    }

}
