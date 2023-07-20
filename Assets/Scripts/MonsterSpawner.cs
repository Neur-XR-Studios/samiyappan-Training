using System.Collections;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] MonsterRef;

    private GameObject SpawnMonster;

    [SerializeField]
    private Transform Leftpos, RightPos;


    private int randomIndex;
    private int randomSide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    
    }
    IEnumerator SpawnMonsters()
    {
       while (true) 
        {
            yield return new WaitForSeconds(Random.Range(0, MonsterRef.Length));

            randomIndex = Random.Range(0, MonsterRef.Length);
            randomSide = Random.Range(0, 2);

            SpawnMonster = Instantiate(MonsterRef[randomIndex]);

            if (randomSide == 0)
            {
                SpawnMonster.transform.position = Leftpos.position;
                SpawnMonster.GetComponent<Monster>().Speed = Random.Range(4, 8);
            }
            else
            {
                SpawnMonster.transform.position = RightPos.position;
                SpawnMonster.GetComponent<Monster>().Speed = -Random.Range(4, 8);
                SpawnMonster.transform.localScale = new Vector3(-1f, 1f, 1f);

            }
        }

    }




    
}
