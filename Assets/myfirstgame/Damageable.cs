using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Damageable : MonoBehaviour
{
    [SerializeField] public int hp = 5;
    [SerializeField] int maxhp = 5;
    [SerializeField] GameObject objectToEnableWhenDie;
    [SerializeField] TMP_Text uiText;
    [SerializeField] float invincibilityTime = 1;
    [SerializeField] float FlipDuration = 0.1f;
    bool isInvincible;

    void Start()
    {
        UpdateText();
    }



    void OnTriggerEnter(Collider other)
    {
        if (isInvincible)
            return;
        Damager damager = other.GetComponentInChildren<Damager>();



        if (damager != null && hp > 0)
        {
            hp -= Mathf.Min(damager.damage, hp);



            hp = Mathf.Clamp(hp, 0, maxhp);
            UpdateText();


            if (hp == 0)
            {
                DisableObjet();
                SetVisibility(false);
            }
            else
                StartCoroutine(StartInvisibility());
        }
    }

    IEnumerator StartInvisibility()
    {
        this.isInvincible = true;

        bool visible = false;
        float startTime = Time.time;
        while (startTime + invincibilityTime > Time.time)
        {
            SetVisibility(visible);
            yield return new WaitForSeconds(FlipDuration);
            visible = !visible;
        }
        this.isInvincible = false;
        SetVisibility(true);

    }

    void SetVisibility(bool visible)
    {

        MeshRenderer[] mrs = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer mr in mrs)
        {
            if (mr != null)
                mr.enabled = visible;
        }

    }

    void DisableObjet()
    {
        if (objectToEnableWhenDie != null)
            objectToEnableWhenDie.SetActive(true);
    }
    void UpdateText()
    {
        if (uiText != null)
        {
            uiText.text = $"HP: {hp}";
        }
    }
}
