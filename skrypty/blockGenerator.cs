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

    void generateBlock(Vector3 startPos, int blocksNumber = 0)
    {
        if (blocksNumber == 0) blocksNumber = Random.Range(2, 6);

        Color blockColor = randomColor();

        GameObject block1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        block1.transform.position = startPos;

        changeBlockColor(block1, blockColor);

        if (blocksNumber >= 2)
        {
            Vector3 block2Pos = nextBlock(startPos);

            GameObject block2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            block2.transform.position = block2Pos;
            block2.transform.SetParent(block1.transform);

            changeBlockColor(block2, blockColor);

            if (blocksNumber >= 3)
            {
                Vector3 block3Pos = block2Pos;

                while (block3Pos == block2Pos || block3Pos == startPos)
                    block3Pos = nextBlock(block2Pos);

                GameObject block3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block3.transform.position = block3Pos;
                block3.transform.SetParent(block1.transform);

                changeBlockColor(block3, blockColor);

                if (blocksNumber >= 4)
                {
                    Vector3 block4Pos = block3Pos;

                    while (block4Pos == block3Pos || block4Pos == block2Pos || block4Pos == startPos)
                        block4Pos = nextBlock(block3Pos);

                    GameObject block4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    block4.transform.position = block4Pos;
                    block4.transform.SetParent(block1.transform);

                    changeBlockColor(block4, blockColor);

                    if (blocksNumber >= 5)
                    {
                        Vector3 block5Pos = block3Pos;

                        while (block5Pos == block4Pos || block5Pos == block3Pos || block5Pos == block2Pos || block5Pos == startPos)
                            block5Pos = nextBlock(block4Pos);

                        GameObject block5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        block5.transform.position = block5Pos;
                        block5.transform.SetParent(block1.transform);

                        changeBlockColor(block5, blockColor);
                    }
                }
            }
        }
        Rigidbody block1RigidBody = block1.AddComponent<Rigidbody>();
        block1RigidBody.velocity = new Vector3(0, 10, 0);
        block1RigidBody.mass = 1;
    }

    void Start()
    {
        /*
        for (int i = 1; i < 50; i++)
            for(int j = 1; j < 5; j++)
                generateBlock(new Vector3(i * 6, j * 5, 0), j + 1);
        */

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            generateBlock(new Vector3(25, 30, 25));
        
    }
}
