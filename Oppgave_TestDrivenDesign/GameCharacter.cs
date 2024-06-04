namespace Oppgave_TestDrivenDesign.Main
{
    public class GameCharacter
    {
        public int Health { get; private set; }
        public int MaxHealth { get; }
        public int Strength { get; private set; }
        public int Stamina { get; private set; }
        public int MaxStamina { get; }

        public GameCharacter(int health, int strength, int stamina)
        {
            Strength = strength;
            Stamina = stamina;
            MaxStamina = stamina;
            Health = health;
            MaxHealth = health;
        }

        public void Fight(GameCharacter character)
        {
            if (Stamina >= 10)
            {
                character.Health -= Strength;
                DrainStamina(10);
            }
            else Recharge();
        }

        public void Fight(GameCharacter character, int dmg)
        {
            if (Stamina >= 10)
            {
                character.Health -= dmg;
                DrainStamina(10);
            }
            else Recharge();
        }

        public void DrainStamina(int staminaDrain)
        {
            Stamina -= staminaDrain;
        }

        public void Recharge()
        {
            Stamina = MaxStamina;
        }

        public void DrinkHealthPotion()
        {
            Health = MaxHealth;
        } 
        
        
        public void DrinkStaminaPotion()
        {
            Recharge();
        }  
        
        public void DrinkStrengthPotion(GameCharacter enemyCharacter)
        {
            Fight(enemyCharacter, (Strength + 10));
        }

    }
}
