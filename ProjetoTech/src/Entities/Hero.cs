using ProjetoTech.src.Entities;
using ProjetoTech.src;

namespace ProjetoTech.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType) // Constructor
        {
            this.Name = Name; // this -> indica que a propriedade Name declarada lá embaixo, irá receber o Name informado no parâmetro
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Hero()
        {

        }

        protected string Name;
        protected string HeroType;
        protected int Level = 1;

        protected int HP = 25;
        protected int MaxHP = 25;
        protected int HPPerLevel = 5;
        protected int Damage = 11; 
        protected int critDmg = 6;
        protected int DmgPerLevel = 4;

        protected int cura = 15;
        protected string classe;


        public override string ToString()
        {
            return $"Name: {this.Name}      Classe: {this.classe}       Nível: {this.Level}\nHP: {this.HP}       Ataque: {this.Damage}";
        }

        public virtual void LevelUp()
        {
            this.Level++;
            this.MaxHP += HPPerLevel;
            this.HP = MaxHP;
            this.Damage += DmgPerLevel;
            this.critDmg++;
            this.cura += 3;

            Console.WriteLine("\nSUBIU DE NÍVEL!");

            Console.WriteLine(ToString());
        }

        public virtual void TakeDamage(int dmg)
        {
            if (this.HP > 0 && dmg > 0)
            {
                this.HP -= dmg;
                Console.WriteLine($"Você recebeu {dmg} de dano!");
                if (this.HP <= 0)
                {
                    this.HP = 0;
                    Die();
                }            
            }
        }

        public virtual int Attack()
        {
            if (this.GetHP() > 0)
            {
                int damage;

                Random rnd = new Random();

                if (rnd.Next(11) % 2 == 0)
                {
                    Console.WriteLine($"Você realizou um golpe com acerto crítico!");
                    Console.ReadLine();
                    damage = this.Damage + this.critDmg;
                    return damage;
                }

                else
                {
                    Console.WriteLine($"Você atacou!");
                    Console.ReadLine();
                    damage = this.Damage;
                    return damage;
                }
            }

            else{
                return 0;
            }
        }

        public int GetHP()
        {
            return this.HP;
        }

        public void Heal()
        {
            if (this.HP + this.cura > this.MaxHP)
            {
                this.HP = this.MaxHP;
            }
            else
            {
                this.HP += this.cura;
            }

        }

        public int GetHeal() // 
        {
            return cura;
        }

        private void Die()
        {
            Console.WriteLine($"\nVocê morreu!");

            Console.WriteLine("\nPressione [ENTER] para voltar para a tela de início.");
            Console.ReadLine();

            Console.Clear();
            GamePhase.Start();

        }

    }
}