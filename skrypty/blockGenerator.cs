using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class blockGenerator : MonoBehaviour
{
    Color randomColor()
    {
        int kolor = Random.Range(0, 6);

        if (kolor == 0) return Color.yellow;
        else if (kolor == 1) return Color.blue;
        else if (kolor == 2) return Color.cyan;
        else if (kolor == 3) return Color.green;
        else if (kolor == 4) return Color.magenta;
        else if (kolor == 5) return Color.red;
        else return Color.black;
    }

    Vector3 nextBlock(Vector3 vec3Value)
    {
        int diff; 
        if ((diff = Random.Range(0, 2)) == 0) --diff;

        int direction = Random.Range(0, 3);
        if (direction == 0) vec3Value.x -= diff;
        else if (direction == 1) vec3Value.y -= diff;
        else if (direction == 2) vec3Value.z -= diff;

        return vec3Value;
    }

    void changeBlockColor(GameObject Object, Color kolor)
    {
        var blockRenderer = Object.GetComponent<Renderer>();
        blockRenderer.material.SetColor("_Color", kolor);
    }

    void generateBlock(Vector3 startVec3, int blocksNumber = 0)
    {
        if (blocksNumber == 0) blocksNumber = Random.Range(2, 6);

        Color blockColor = randomColor();

        GameObject block1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        block1.transform.position = startVec3;

        changeBlockColor(block1, blockColor);

        if (blocksNumber >= 2)
        {
            Vector3 block2Pos = nextBlock(startVec3);

            GameObject block2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            block2.transform.position = block2Pos;

            changeBlockColor(block2, blockColor);

            if (blocksNumber >= 3)
            {
                Vector3 block3Pos = block2Pos;

                while (block3Pos == block2Pos || block3Pos == startVec3)
                    block3Pos = nextBlock(block2Pos);

                GameObject block3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block3.transform.position = block3Pos;

                changeBlockColor(block3, blockColor);

                if (blocksNumber >= 4)
                {
                    Vector3 block4Pos = block3Pos;

                    while (block4Pos == block3Pos || block4Pos == block2Pos || block4Pos == startVec3)
                        block4Pos = nextBlock(block3Pos);

                    GameObject block4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    block4.transform.position = block4Pos;

                    changeBlockColor(block4, blockColor);

                    if (blocksNumber >= 5)
                    {
                        Vector3 block5Pos = block3Pos;

                        while (block5Pos == block4Pos || block5Pos == block3Pos || block5Pos == block2Pos || block5Pos == startVec3)
                            block5Pos = nextBlock(block4Pos);

                        GameObject block5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        block5.transform.position = block5Pos;

                        changeBlockColor(block5, blockColor);
                    }
                }
            }
        }
    }

    void Start()
    {
        for (int i = 1; i < 50; i++)
            for(int j = 1; j < 5; j++)
                generateBlock(new Vector3(i * 6, j * 5, 0), j + 1);

    }
}
