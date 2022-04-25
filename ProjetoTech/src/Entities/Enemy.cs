namespace ProjetoTech.src.Entities
{
    public class Enemy
    {
        private bool isAlive;
        private string Name;
        private int HP = 30;
        private int MaxHP = 30;
        private int Dmg = 7;
        private int critDmg = 2;


        public void SpawnEnemy(string name)
        {
            this.Name = name;
            this.MaxHP += 5;
            this.HP = this.MaxHP;
            this.Dmg += 2;
            this.critDmg += 1;
            this.isAlive = true;
        }

        public void SpawnBoss()
        {
            //BOSS
            this.Name = "Rei da Cocada Preta";
            this.MaxHP = this.MaxHP + 10;
            this.HP = this.MaxHP;
            this.Dmg += 3;
            this.critDmg += this.critDmg;
            this.isAlive = true;
        }

        public int GetHP()
        {
            return this.HP;
        }

        public bool GetAliveStatus()
        {
            return this.isAlive;
        }

        public int Attack(int hpHero)
        {
            if (hpHero > 0)
            {
                int damage;

                Random rnd = new Random();

                if (rnd.Next(11) % 2 == 0)
                {
                    Console.WriteLine($"\n{this.Name} realizou um golpe com acerto crítico!\n");
                    damage = this.Dmg + this.critDmg;
                    return damage;
                }

                else
                {
                    Console.WriteLine($"\n{this.Name} atacou!\n");
                    damage = this.Dmg;
                    return damage;
                }
            
            }

            else {
                return 0;
            }
        }

        public void TakeDamage(int dmg)
        {
            this.HP -= dmg;
            if (this.HP <= 0)
            {
                this.isAlive = false;
                this.HP = 0;
                Console.WriteLine($"Você derrotou {this.Name}!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"\n{this.Name} recebeu {dmg} de dano!");
                Console.WriteLine(ToString());
                Console.ReadLine();
            }
        }

        public override string ToString()
        {
            return $"\nInimigo: {this.Name} \nHP: {this.HP}     Ataque: {this.Dmg}";
        }
    }
}