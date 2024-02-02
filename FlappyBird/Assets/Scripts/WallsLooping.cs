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

    private void Start()
    {
        this.StartCoroutine(this.SpawnWalls(this._timeBtwnWallsSpawn));
    }

    private IEnumerator SpawnWalls(float timeToWait)
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait);
            this._randomHeight = Random.Range(this._startHeightMin, this._startHeightMax);
            this._clonedWall = Instantiate(this._walls, new Vector3(12, this._randomHeight, 0), Quaternion.identity);
        }
    }
}
