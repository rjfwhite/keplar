namespace Lib
{
    public class Player {
        public int Health { get; private set; }

        public Player(int initialHealth) {
            Health = initialHealth;
        }

        public void TakeDamage(int damage) {
            Health -= damage;
            if (Health < 0) {
                Health = 0;
            }
        }
    }
}