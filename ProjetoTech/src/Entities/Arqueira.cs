namespace ProjetoTech.src.Entities
{
    public class Arqueira : Hero
    {
        public Arqueira(string Name)
        {
            this.Name = Name; 
            this.classe = "Arqueira";

        }

        public override int Attack()
        {
            int damage;

            Random rnd = new Random();

            if (rnd.Next(11) % 2 == 0)
            {
                Console.WriteLine($"\nVocê atirou com precisão uma Rajada de Flechas Flamejantes!");
                damage = this.Damage + this.critDmg;
                return damage;
            }

            else
            {
                Console.WriteLine($"\nVocê atirou uma flecha certeira!");
                damage = this.Damage;
                return damage;
            }
        }
    }
}