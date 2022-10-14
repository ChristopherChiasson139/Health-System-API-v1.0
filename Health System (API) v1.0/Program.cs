using System;
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
        static void Main(string[] args)
        {
            health = 100;
            status = "Perfect Health";
            weapon = 0;
            WeaponName = "pistol";

            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("start");
            Console.WriteLine("");
            Console.ReadKey(true);


            ChangeWeapon(0);
            Heal(0);
            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("You find a shotgun then you lick a nuke");
            Console.ReadKey(true);

            Console.WriteLine("");
            TakeDamge(99);
            ChangeWeapon(1);
            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("The shotgun gets obliterated.");
            Console.WriteLine("You find a health pack and a zombie then shows up at the scene.");
            Console.WriteLine("You reach into your pocket and get your emergency weapon.");
            Console.ReadKey(true);

            Console.WriteLine("");
            ChangeWeapon(7);
            Heal(40);
            ShowHUD();
            Console.WriteLine("");
            Console.WriteLine("big friendly giant: hello there.");
            Console.ReadKey(true);
        }

        static void TakeDamge(int damge)
        {
            health = health - damge;
        }
        static void Heal(int hp)
        {
            health = health + hp;

            //hp
            if (health <= 0)
            {
                health = 0;
            }
            if (health >= 100)
            {
                health = 100;
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
        static void Code()
        {


        }



        static void ShowHUD()
        {

            Console.WriteLine("Hp = " + health);
            Console.WriteLine("Health status = " + status);
            Console.WriteLine("weapon = " + WeaponName);
        }

    }
}
