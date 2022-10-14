﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Conditionals__HUD_v1._2_
{
    internal class Program
    {
        static int health;
        static string status;
        static int weapon;
        static string WeaponName;
        static int live;
        static int shield;
        static void Main(string[] args)
        {
            health = 100;
            status = "Perfect Health";
            weapon = 0;
            WeaponName = "pistol";
            live = 3;
            shield = 100;

            
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);

            TakeDamge(99999);
            ShowHUD();
            Console.ReadKey(true);



        }

      
        static void TakeDamge(int damge)
        {
            shield = shield - damge;

            //shield
            if (shield < 0)
            {
                health = health + shield;
                shield = 0;
            }

            //hp range
            if (health <= 0)
            {
                health = 0;
            }
            if (health >= 100)
            {
                health = 100;
            }

            //live to hp
            if (health == 0)
            {
                live = live - 1;
                health = health + 100;
            }
            //live range
            if (live <= 0)
            {
                live = 0;
            }
            if (live >= 99)
            {
                live = 99;
            }

            //die
            if (live == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Game over");
                Console.ReadKey(true);
                Environment.Exit(0);
            }

        }
        static void Heal(int hp)
        {
            health = health + hp;

            //hp
            if (health <= 0)
            {
                health = 0;
            }
            if (health > 100)
            {
                health = 100;
                lives(1);
            }
            if ((health >= 75) && (health <= 90))
            {
                status = "Heathly";
            }
            if ((health >= 50) && (health <= 74))
            {
                status = "Hurt";
            }
            if ((health >= 10) && (health <= 49))
            {
                status = "Badly Hurt";
            }
            if ((health >= 0) && (health <= 9))
            {
                status = "Imminent Danger";
            }


        }
        static void ChangeWeapon(int gun)
        {
            weapon = weapon + gun;

            //gun
            if (weapon <= 0)
            {
                weapon = 0;
            }
            if (weapon >= 5)
            {
                weapon = 5;
            }

            if (weapon == 0)
            {
                WeaponName = "pistol";
            }
            if (weapon == 1)
            {
                WeaponName = "shot gun";
            }
            if (weapon == 2)
            {
                WeaponName = "spreader";
            }
            if (weapon == 3)
            {
                WeaponName = "laser";
            }
            if (weapon == 4)
            {
                WeaponName = "sniper";
            }
            if (weapon == 5)
            {
                WeaponName = "BFG?";

            }
        }
        static void lives(int lup)
        {
            live = live + lup;

            //live
            if (live <= 0)
            {
                live = 0;
            }
            if (live >= 99)
            {
                live = 99;
            }

            
        }

        static void RegenerateShield(int hp)
        {
            shield = shield + hp;

            //hp range
            if (shield <= 0)
            {
                shield = 0;
            }
            if (shield >= 100)
            {
                shield = 100;
            }
        }

        static void ShowHUD()
        {
            Console.WriteLine("");
            Console.WriteLine("lives = " + live);
            Console.WriteLine("Shield = " + shield);
            Console.WriteLine("Hp = " + health);
            Console.WriteLine("Health status = " + status);
            Console.WriteLine("weapon = " + WeaponName);
        }
        

    }
}
