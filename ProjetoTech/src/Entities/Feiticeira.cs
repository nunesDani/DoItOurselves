namespace ProjetoTech.src.Entities
{
    public class Feiticeira : Hero
    {

        public Feiticeira(string Name)
        {
            this.Name = Name; 
            this.classe = "Feiticeira";

        }

        public override int Attack()
        {
            int damage;

            Random rnd = new Random();

            if (rnd.Next(11) % 2 == 0)
            {
                Console.WriteLine($"\nVocê concentrou magia e conjurou uma Explosão Mística!");
                damage = this.Damage + this.critDmg;
                return damage;
            }

            else
            {
                Console.WriteLine($"\nVocê lançou uma bola de fogo!");
                damage = this.Damage;
                return damage;
            }
        }


    }
}