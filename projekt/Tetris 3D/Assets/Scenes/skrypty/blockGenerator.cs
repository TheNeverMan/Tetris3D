using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
//do studni
public class blockGenerator : MonoBehaviour
{
    private List<GameObject> list_of_cubes = new List<GameObject>();
    public KeyCode restartKey = KeyCode.R;
    Vector3 blockSpawnPoint = new Vector3(0f, 0f, 0f);
    private float blockScale = 1.8f;
    float time = 0;
    private bool oneTime = true;
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

    void generateBlock(Vector3 startPos, int minRandom = 2, int maxRandom = 7)
    {
        if (minRandom < 2) minRandom = 2;
        if (maxRandom > 7) minRandom = 7;

        Color blockColor = randomColor();
        int blocksNumber = Random.Range(minRandom, maxRandom + 1);

        GameObject block1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        block1.transform.position = startPos;
        Rigidbody block1RigidBody = block1.AddComponent<Rigidbody>();
        box_control BoxControl = block1.AddComponent<box_control>();
        box_move BoxMove = block1.AddComponent<box_move>();

        block1RigidBody.mass = 20;
        block1RigidBody.drag = 3.0f;
        changeBlockColor(block1, blockColor);

        if (blocksNumber >= 2)
        {
            int random;

            GameObject block2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 block2Pos = nextBlock(startPos);
            block2.transform.position = block2Pos;
            block2.transform.SetParent(block1.transform);
            changeBlockColor(block2, blockColor);

            if (blocksNumber >= 3)
            {
                Vector3 block3Pos = block2Pos;

                while (block3Pos == block2Pos || block3Pos == startPos)
                {
                    random = Random.Range(1, 3);

                    if (random == 1) block3Pos = nextBlock(startPos);
                    if (random == 2) block3Pos = nextBlock(block2Pos);
                }
                GameObject block3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                block3.transform.position = block3Pos;
                block3.transform.SetParent(block1.transform);
                changeBlockColor(block3, blockColor);

                if (blocksNumber >= 4)
                {
                    Vector3 block4Pos = block3Pos;

                    while (block4Pos == block3Pos || block4Pos == block2Pos || block4Pos == startPos)
                    {
                        random = Random.Range(1, 4);

                        if (random == 1) block4Pos = nextBlock(startPos);
                        if (random == 2) block4Pos = nextBlock(block2Pos);
                        if (random == 3) block4Pos = nextBlock(block3Pos);
                    }

                    GameObject block4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    block4.transform.position = block4Pos;
                    block4.transform.SetParent(block1.transform);
                    changeBlockColor(block4, blockColor);

                    if (blocksNumber >= 5)
                    {
                        Vector3 block5Pos = block4Pos;

                        while (block5Pos == block4Pos || block5Pos == block3Pos || block5Pos == block2Pos || block5Pos == startPos)
                        {
                            random = Random.Range(1, 5);

                            if (random == 1) block5Pos = nextBlock(startPos);
                            if (random == 2) block5Pos = nextBlock(block2Pos);
                            if (random == 3) block5Pos = nextBlock(block3Pos);
                            if (random == 4) block5Pos = nextBlock(block4Pos);
                        }

                        GameObject block5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                        block5.transform.position = block5Pos;
                        block5.transform.SetParent(block1.transform);
                        changeBlockColor(block5, blockColor);

                        if (blocksNumber >= 6)
                        {
                            Vector3 block6Pos = block5Pos;

                            while (block6Pos == block5Pos || block6Pos == block4Pos || block6Pos == block3Pos || block6Pos == block2Pos || block6Pos == startPos)
                            {
                                random = Random.Range(1, 6);

                                if (random == 1) block6Pos = nextBlock(startPos);
                                if (random == 2) block6Pos = nextBlock(block2Pos);
                                if (random == 3) block6Pos = nextBlock(block3Pos);
                                if (random == 4) block6Pos = nextBlock(block4Pos);
                                if (random == 5) block6Pos = nextBlock(block5Pos);
                            }

                            GameObject block6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                            block6.transform.position = block6Pos;
                            block6.transform.SetParent(block1.transform);
                            changeBlockColor(block6, blockColor);

                            if (blocksNumber >= 7)
                            {
                                Vector3 block7Pos = block6Pos;

                                while (block7Pos == block6Pos || block7Pos == block5Pos || block7Pos == block4Pos || block7Pos == block3Pos || block7Pos == block2Pos || block7Pos == startPos)
                                {
                                    random = Random.Range(1, 7);

                                    if (random == 1) block7Pos = nextBlock(startPos);
                                    if (random == 2) block7Pos = nextBlock(block2Pos);
                                    if (random == 3) block7Pos = nextBlock(block3Pos);
                                    if (random == 4) block7Pos = nextBlock(block4Pos);
                                    if (random == 5) block7Pos = nextBlock(block5Pos);
                                    if (random == 6) block7Pos = nextBlock(block6Pos);
                                }

                                GameObject block7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                                block7.transform.position = block7Pos;
                                block7.transform.SetParent(block1.transform);
                                changeBlockColor(block7, blockColor);
                            }
                        }
                    }
                }
            }
        }
        block1.transform.localScale = new Vector3(1 * blockScale, 1 * blockScale, 1 * blockScale);
        list_of_cubes.Add(block1);
    }

    void Start()
    {
        generateBlock(new Vector3(0, 45, 0));
    }

    void Update()
    {
      if(!score.endGame)
      {
        int i = list_of_cubes.Count;
        score.scoreCount=i-1;
      }
        if (score.endGame && oneTime)
        {
            oneTime = false;
            Destroy(list_of_cubes[list_of_cubes.Count - 1]);
        }
        if (Input.GetKeyDown(restartKey))
        {
            foreach (GameObject obj in list_of_cubes)
            {
                Destroy(obj);
            }
            score.scoreCount = 0;
            score.endGame = false;

            generateBlock(new Vector3(0, 45, 0));
        }

        time = time + 1 * Time.deltaTime;

        if (box_control.spawnMore && time % 2 < 0.1 && !score.endGame)
            generateBlock(new Vector3(0, 45, 0));
    }
    void OnCollisionEnter(Collision col)
    {
        if (box_control.spawnMore && time % 2 < 0.1)
            generateBlock(new Vector3(0, 45, 0));
    }
}
