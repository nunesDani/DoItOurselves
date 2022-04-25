namespace ProjetoTech.src.Entities
{
    public class Lutadora : Hero
    {
        public Lutadora(string Name)
        {
            this.Name = Name;
            this.classe = "Lutadora";

        }

        public override int Attack()
        {
            int damage;

            Random rnd = new Random();

            if (rnd.Next(11) % 2 == 0)
            {
                Console.WriteLine($"\nVocê reuniu suas forças e desferiu o golpe Punho do Dragão!");
                damage = this.Damage + this.critDmg;
                return damage;
            }

            else
            {
                Console.WriteLine($"\nVocê realizou um soco esmagador!");
                damage = this.Damage;
                return damage;
            }
        }

    }
}