using System;

public class Pokemon
{
	// array(0) = IV array(1) = EV array(2) = total/max
	private int Hp = new int[2];
	private int attack = new int[2];
	private int defence = new int[2];
	private int specialAttack = new int[2];
	private int specialDefence = new int[2];
	private int speed = new int[2];
	private int exp;
	private string name;
	private int level;
	private int currentHp;
	private bool fainted;
	private int ID;
	private bool wild;
	private string gender;

	public Pokemon()
	{
		
	}

	public void levelUp()
    {
		level += 1;
		setMaxHealth;
		setMaxAttack;
		setMaxDefence;
		setMaxSpeed;
		setMaxSpecial;
    }

	public void gainEXP(int enemyEXPyeild, int enemyLevel, bool enemyWild, int numOfPokemon)
    {
		if (enemyWild = true)
        {
			exp += Math.Ceiling((enemyEXPyeild * enemyLevel) / (7 * numOfPokemon));
        }
		else
        {
			exp += Math.Ceiling((enemyEXPyeild * enemyLevel * 1.5) / (7 * numOfPokemon)); 
		}
    }

	public void takePhisicalDammage(int enemyAttack, int enemyLevel, int power)
    {
		
    }

	public void takeSpecialDammage(int enemyAttack, int enemyLevel, int power)
    {

    }

	public void setMaxHealth()
    {
		Hp[3] = ((((Hp[0] + Hp[1]) * 2) + ((Hp[2]^(1/2)) / 4)) / 100 * level) + level + 10;
    }

	public void setMaxAttack()
    {
		attack[3] = ((attack[0] + attack[1]) * 2 + ((attack[2] ^ (1 / 2) / 4)) / 100 * level) + 5; 
    }

	public void setMaxDefence()
    {
		defence[3] = ((defence[0] + defence[1]) * 2 + ((defence[2] ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public void setMaxSpeed()
    {
		speed[3] = ((speed[0] + speed[1]) * 2 + ((speed[2] ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public void setMaxSpecialAttack()
    {
		specialAttack[3] = ((specialAttack[0] + specialAttack[1]) * 2 + ((specialAttack[2] ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public void setMaxSpecialDefence()
    {
		specialDefence[3] = ((specialDefence[0] + specialDefence[1]) * 2 + ((specialDefence[2] ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public int getBaseHp()
    {
		return Hp(0);
    }

	public int getBaseAttack()
    {
		return attack(0);
    }

	public int getBaseDefence()
    {
		return defence(0);
    }

	public int getBaseSpeed()
    {
		return speed(0);
    }

	public int getBaseSpecial()
    {
		return special(0);
    }

    private string getStats()
    {
       
    }

}
