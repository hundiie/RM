using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHealth : MonoBehaviour
{
    private MonsterStatus _MonsterStatus;

    [SerializeField] private float MaxHP;
    [SerializeField] private float HP;
    [SerializeField] private Slider HpSlider;

    
    private void Awake()
    {
        _MonsterStatus = GetComponent<MonsterStatus>();
        MaxHP = _MonsterStatus.HP;
        HP = MaxHP;
    }

    private void Update()
    {
        HpSlider.transform.LookAt(Camera.main.transform);

        if (Input.GetKey(KeyCode.H))
        {
            Hit(0.1f);
        }
    }
    public void Hit(float Damage)
    {
        HP -= Damage;
        HpSlider.value = HP / (MaxHP / 100);

        if (HP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
