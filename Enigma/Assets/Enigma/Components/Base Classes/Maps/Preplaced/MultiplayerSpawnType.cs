﻿using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Enigma.Components.Base_Classes.Maps.Preplaced
{
    /// <summary>
    /// The Network manager spawns a prefab at the position of this.
    /// </summary>
    public class MultiplayerSpawnType : MonoBehaviour
    {
        public GameObject SpawnEntity;

        public void SpawnObject()
        {
            var spawnObj = (GameObject)Instantiate(SpawnEntity, transform.position, transform.rotation);
            NetworkServer.Spawn(spawnObj);
            Destroy(this.gameObject);
        }
    }
}
