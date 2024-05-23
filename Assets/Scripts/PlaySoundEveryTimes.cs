using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEveryTimes : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public AudioClip soundClip; // Аудиоклип, который будет проигрываться
    public float interval = 20; // Интервал в секундах (2 минуты = 120 секунд)

    private AudioSource audioSource;
    private float timer;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = soundClip;
        timer = interval; // Устанавливаем начальное значение таймера
    }

    void Update()
    {
        timer -= Time.deltaTime; // Уменьшаем таймер каждый кадр

        PlaySoundMonster();
        if (enemyHealth.value <= 0)
        {
            Destroy(audioSource);
        }
    }

    private void PlaySoundMonster()
    {
        if (timer <= 0f)
        {
            audioSource.Play(); // Проигрываем звук
            timer = interval; // Сбрасываем таймер
        }
    }
}
