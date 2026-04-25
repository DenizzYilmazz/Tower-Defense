using UnityEngine;

public class EnemyWayPoints : MonoBehaviour
{
    public static Transform[] enemyWayPoint;

    void Awake()
    {
        enemyWayPoint = new Transform[transform.childCount];
        for (int i = 0; i < enemyWayPoint.Length; i++)
        {
            enemyWayPoint[i] = transform.GetChild(i);
        }
    }
}
