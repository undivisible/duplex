using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorandomisespawn : MonoBehaviour
{
		public float minX = -10f; // Minimum X coordinate
		public float maxX = 10f; // Maximum X coordinate
		public float minZ = -10f; // Minimum Z coordinate
		public float maxZ = 10f; // Maximum Z coordinate
		public float spawnRadius = 2f; // Minimum distance between the object and other objects

		private void Start()
		{
			// Generate initial random position
			GenerateRandomPosition();
		}

		private void Update()
		{
			// Check if you want to change the object's position (e.g., by pressing a key or based on some condition)
			if (Input.GetKeyDown(KeyCode.Space))
			{
				GenerateRandomPosition();
			}
		}

		private void GenerateRandomPosition()
		{
			// Generate random X and Z coordinates
			float randomX = Random.Range(minX, maxX);
			float randomZ = Random.Range(minZ, maxZ);

			// Create a temporary position
			Vector3 tempPosition = new Vector3(randomX, transform.position.y, randomZ);

			// Check if the temporary position is overlapping with any other colliders
			Collider[] colliders = Physics.OverlapSphere(tempPosition, spawnRadius);
			bool overlap = colliders.Length > 0;

			// If there is an overlap, regenerate the position
			while (overlap)
			{
				randomX = Random.Range(minX, maxX);
				randomZ = Random.Range(minZ, maxZ);

				tempPosition = new Vector3(randomX, transform.position.y, randomZ);

				colliders = Physics.OverlapSphere(tempPosition, spawnRadius);
				overlap = colliders.Length > 0;
			}

			// Update the object's position
			transform.position = tempPosition;
		}
}