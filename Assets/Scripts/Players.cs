using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class Players : MonoBehaviour
{
   private int health;
   private int maxHealth = 100;
   public HpBarUi hpBarUi;

   PhotonView view;

   private void Start()
   {
      health = maxHealth;
   }

   public void PlayerHealth()
   {
        // hpBarUi.Attack(10);
   }

   public void TakeDamage(int damage)
   {
      health -= damage;
      Debug.Log("Updated health is: " + health);
   }
}
