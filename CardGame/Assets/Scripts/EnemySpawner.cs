using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject _enemyPrefab;

    [SerializeField]
    SOEnemy[] _enemyScriptableObjects;

    TileManager _tm;
    TileData[] _tiles;

    

    private void Awake()
    {
        _tm = FindObjectOfType<TileManager>();
        if(_tm != null)
        {
            _tiles = _tm.GetAllTiles();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        foreach (var tile in _tiles)
        {
            int[] coordinates = tile.GetCoordinates();

            if (coordinates[0] == 0 && coordinates[1] == 4)
            {

            }
            else
            {
                GameObject go = Instantiate(_enemyPrefab, tile.transform.position, Quaternion.identity, tile.transform);
                EnemyData enemy = go.GetComponent<EnemyData>();
                int enemyIndex = Random.Range(0, _enemyScriptableObjects.Length);
                enemy.SetScriptableObject(_enemyScriptableObjects[enemyIndex]);
                go.transform.localScale = new Vector3(0.66f, 0.66f, 0.66f);
                tile._hasEnemy = true;
                tile.enemyData = enemy;
            }
        }
    }
}
