namespace ProjetoTech.src.Entities
{
    public class Cavaleira : Hero
    {
        public Cavaleira(string Name) // Constructor
        {
            this.Name = Name; 
            this.classe = "Cavaleira";
      
        }

        public override int Attack()
        {
            int damage;

            Random rnd = new Random();

            if (rnd.Next(11) % 2 == 0)
            {
                Console.WriteLine($"\nVocê brandiu sua espada com vigor e realizou um Golpe Estilhaçador!");
                damage = this.Damage + this.critDmg;
                return damage;
            }

            else
            {
                Console.WriteLine($"\nVocê realizou um corte com sua espada!");
                damage = this.Damage;
                return damage;
            }
        }

    }
}