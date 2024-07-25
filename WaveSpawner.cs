using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {

	public static int EnemiesAlive = 0;

	public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

	public GameManager gameManager;

	private int waveIndex = 0;

	void Update ()
	{
		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;

		//countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		//waveCountdownText.text = string.Format("{0:00.00}", countdown);
	}

	IEnumerator SpawnWave ()
	{
		//PlayerStats.Rounds++;
		//Wave wave = waves[waveIndex];
		//EnemiesAlive = wave.count;

		waveIndex++;

		for (int i = 0; i < waveIndex; i++)
		{
			SpawnEnemy(wave.enemy);
			yield return new WaitForSeconds(0.5f);
		}

	}

	void SpawnEnemy (GameObject enemy)
	{
		Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
	}

}