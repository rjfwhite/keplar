using NUnit.Framework;

namespace Lib.Tests
{
    public class PlayerTests {

        // Each test will be a method marked with [Test]
        [Test]
        public void Player_TakeDamage_HealthDecreases() {
            // Arrange
            var player = new Player(10);  // Create a player with 10 health

            // Act
            player.TakeDamage(5);  // Player takes 5 damage

            // Assert
            Assert.AreEqual(5, player.Health);  // Player health should be 5
        }

        [Test]
        public void Player_TakeDamage_HealthCannotGoBelowZero() {
            // Arrange
            var player = new Player(10);  // Create a player with 10 health

            // Act
            player.TakeDamage(15);  // Player takes 15 damage, more than total health

            // Assert
            Assert.AreEqual(0, player.Health);  // Player health should be 0, not negative
        }
    }
}
