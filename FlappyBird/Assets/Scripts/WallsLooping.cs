using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsLooping : MonoBehaviour
{
    [SerializeField]
    private float _startHeightMin;
    [SerializeField]
    private float _startHeightMax;

    private float _randomHeight;

    [SerializeField]
    private float _timeBtwnWallsSpawn;

    [SerializeField]
    private GameObject _walls;

    private GameObject _clonedWall;



    void Start()
    {
        StartCoroutine(SpawnWalls(_timeBtwnWallsSpawn));
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator SpawnWalls(float TimeToWait)
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToWait);
            _randomHeight = Random.Range(_startHeightMin, _startHeightMax);
            _clonedWall = Instantiate(_walls, new Vector3(12, _randomHeight, 0), Quaternion.identity);
            //Debug.Log("Un mur est cr��");
        }
    }
}