﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public GameObject[] waves;

    private int currentWave;

    IEnumerator Start()
    {
        if (waves.Length == 0) {
            yield break;
        }

        while (true) {
            GameObject wave = (GameObject) Instantiate (waves [currentWave], transform.position, Quaternion.identity);

            // WaveをEmitterの子要素にする
            wave.transform.parent = transform;

            // Waveの子要素のEnemyが全て削除されるまで待機する
            while (wave.transform.childCount != 0) {
                yield return new WaitForEndOfFrame ();
            }

            Destroy (wave);

            if (waves.Length <= ++currentWave) {
                currentWave = 0;
            }
        }
    }
}
