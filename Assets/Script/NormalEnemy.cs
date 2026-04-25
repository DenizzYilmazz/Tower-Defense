using UnityEngine;

public class NormalEnemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    private void Start()
    {
        target = EnemyWayPoints.enemyWayPoint[0];
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavepointIndex >= EnemyWayPoints.enemyWayPoint.Length - 1)
        {
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = EnemyWayPoints.enemyWayPoint[wavepointIndex];
    }
}
