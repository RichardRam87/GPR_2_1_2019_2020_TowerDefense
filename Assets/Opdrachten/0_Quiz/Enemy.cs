using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Opdrachten
{
    /* vragen
           1. Deze class erft over van MonoBehaviour, wat houdt dat precies in?
           2. Wat is het verschil tussen de Start() en Update() functie?
           3. Waarom gaat de start() functie in dit script niet werken?
           4. O.a. voor de health variable staat het woord 'private'; dit noem je een 
              Access Modifier. Waar zorgt deze Acces Modifier voor?
           5. Welke Acces Modifiers ken je nog meer? Wat houden deze in?
           6. Voor o.a. de Attack() en TargetsInRange() functies staat 'void' of 'bool'. 
              Wat betekend dit?
           7. Heb je vragen aan de hand van deze Class? Zo ja, welke dan?
        */


    public class Enemy : MonoBehaviour
    {
        private float health = 100;

        private Player player;

        void start()
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        }

        void Update()
        {
            if (TargetInRange())
                Attack();
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;

            if (health <= 0)
            {
                // todo: Make something when the enemy dies
            }
        }

        private bool TargetInRange()
        {
            // ToDo: Implement this function
        }

        private void Attack()
        {
            // ToDo: Implement this function
        }
    }
}
