using System;

public class Pokemon
{
	// array(0) = base array(1) = IV array(2) = EV array(3) = total/max
	private int Hp();
	private int attack();
	private int defence();
	private int speed();
	private int special();
	private string name;
	private int level;
	private int currentHp;
	private bool fainted;

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

	public void setMaxHealth()
    {
		Hp(3) = ((((Hp(0) + Hp(1)) * 2) + ((Hp(2)^(1/2)) / 4)) / 100 * level) + level + 10;
    }

	public void setMaxAttack()
    {
		attack(3) = ((attack(0) + attack(1)) * 2 + ((attack(2) ^ (1 / 2) / 4)) / 100 * level) + 5; 
    }

	public void setMaxDefence()
    {
		defence(3) = ((defence(0) + defence(1)) * 2 + ((defence(2) ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public void setMaxSpeed()
    {
		speed(3) = ((speed(0) + speed(1)) * 2 + ((speed(2) ^ (1 / 2) / 4)) / 100 * level) + 5;
	}

	public void setMaxSpecial()
    {
		special(3) = ((special(0) + special(1)) * 2 + ((special(2) ^ (1 / 2) / 4)) / 100 * level) + 5;
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
}
