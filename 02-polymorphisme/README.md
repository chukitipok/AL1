# Rappels

## Classe 

```C#
public class MaClasse
{
    private int unAttribut;

    public int UneProprietePourAccederAAttribut
    {
        get { return unAttribut; }
        private set { unAttribut = value; }
    }

    public int UneAutoPropriete { get; set;}

    public MaClasse()
    {
        // Code pour initialiser votre classe
    }

    public void UneMethode(string unParametre)
    {
        Console.WriteLine($"{unParametre} {UnePropriete} {unAttribut}");
    }
}
```

## Héritage 

```C#
public abstract class MaClasseDeBase
{
    public void UneMethodeDeBase() { }
    
    public virtual void UneMethodePouvantEtreSpecialiseeAvecUnComportementParDefault()
    {
        // Comportement par default
    }

    public abstract void UneMethodePouvantEtreSpecialiseeSansUnComportementParDefault();
}

public class UneClasseSpecialisee : MaClasseDeBase
{
    public override void UneMethodePouvantEtreSpecialiseeAvecUnComportementParDefault() { }
    public void UneMethodePouvantEtreSpecialiseeSansUnComportementParDefault() { }
}
```

## Interface 

```C#
public interface IUneInterface
{
    void UneMethode();
    void UneAutreMethode(string unParametre);
}

public class UneClasse : IUneInterface
{
    public void UneMethode() { }
    public void UneAutreMethode(string unParametre) { }
}
```

## Polymorphisme

Imaginons le code suivant :

```C#
public abstract class Personnage
{
	public abstract void AttaqueSpeciale();
}

public class Sorcier : Personnage
{
	public void AttaqueSpeciale() 
	{ 
		Console.WriteLine("Boule de feu");
	}
}

public class Guerrier : Personnage
{
	public void AttaqueSpeciale() 
	{ 
		Console.WriteLine("Coup de boule");
	}
}
```

Comme Sorcier et Guerrier sont des personnages il est possible de constituer une équipe composée de personnages qui auront leurs propres spécificités et comportements sans jamais que cela n'apparaisse au niveau de l'équipe.

```C#
public class Equipe
{
	private List<Personnage> personnages;

	public Equipe(List<Personnage> personnages)
	{
		this.personnages = personnages;
	}

	public void AttaqueSpecialeGroupee()
	{
		foreach (var personnage in personnages)
		{
			personnage.AttaqueSpeciale();
		}
	}
}
```

L'interet est de pouvoir manipuler des objets selon leurs formes de base ou leurs de contrats tout en les laissant se comporter de manière spécifique.
