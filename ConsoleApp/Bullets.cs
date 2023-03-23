using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Bullets
    {
        public static void Main(string[] args)
        {
            int totalBullets = 50;
            int bulletNumberFired = 0;
            Hero hero = new Hero(ref totalBullets, ref bulletNumberFired);
            Villian villian = new Villian(ref totalBullets, ref bulletNumberFired);

            hero.shoot();
            villian.shoot();
            hero.shoot();

        }
    }

    public class Hero
    {
        int bulletNumber;
        int totalBullets;
        public Hero(ref int totalBullets, ref int bulletFired)
        {
            this.bulletNumber = bulletFired;
            this.totalBullets = totalBullets;
        }

        public void shoot() {
            this.totalBullets--;
            this.bulletNumber++;
            Console.WriteLine($"The bullet number fired ny the hero is {this.bulletNumber}");
            Console.WriteLine($"The bullets remaining is {this.totalBullets}");
        }
    }

    public class Villian
    {
        int bulletNumber;
        int totalBullets;
        public Villian(ref int totalBullets, ref int bulletFired)
        {
            this.bulletNumber = bulletFired;
            this.totalBullets = totalBullets;
        }

        public void shoot()
        {
            this.totalBullets = this.totalBullets - 3;
            for(int i = 0; i < 3; i++) {
                this.bulletNumber++;
                Console.WriteLine($"The bullet number fired by the villian is {this.bulletNumber}");
            }
            Console.WriteLine($"Shot fired by villian and the bullets remaining is {this.totalBullets}");
        }
    }

    

}
