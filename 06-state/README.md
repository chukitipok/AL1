# State

Imaginons le code suivant :

```C#
public class Video
{
	public void Start()
	{
		Console.WriteLine("start");
	}

	public void Stop()
	{
		Console.WriteLine("stop");
	}
}
```

Après quelques temps, on nous fait remarquer que cela n'a pas de sens de pouvoir appeler stop si on a déjà stoppé et la meme chose pour start.

Nous modifions donc notre code de la manière suivante :

```C#
public class Video
{
	public string state;

	public Video
	{
		state = "stopped";
	}

	public void Start()
	{
		if (state != "started")
		{
			Console.WriteLine("start");
			state = "started";
		}
	}

	public void Stop()
	{
		if (state != "stopped")
		{
			Console.WriteLine("stop");
			state = "stopped";
		}
	}
}
```

En fait ceci est une machine à état avec les transitions suivantes stop -> start et start -> stop. 

Le nombre de transitions est ici assez limité mais il est facile d'appercevoir que plus le nombre d'états et de conditions de transition vont augmenter, plus notre code va ressembler à du code spaghetti...

Tentons donc d'améliorer notre code en isolant les comportements en fonction des états :

```C#
public abstract class State
{
	public abstract State Start();
	public abstract State Stop();
}

public class StartedState : State
{
	public State Start()
	{
		return this;
	}

	public State Stop()
	{
		Console.WriteLine("stop");
		return new StoppedState();
	}
}

public class StoppedState : State
{
	public State Start()
	{
		Console.WriteLine("start");
		return new StartedState();
	}

	public State Stop()
	{
		return this;
	}
}
```

Maintenant modifions notre classe Video pour utiliser ces nouveaux états 

```C#
public class Video
{
	public State state;

	public Video()
	{
		state = new StoppedState();
	}

	public void Start()
	{
		state = state.Start();
	}

	public void Stop()
	{
		state = state.Stop();
	}
}
```

Le design pattern state est un design pattern de comportement qui permet de modéliser une machine à états en isolant les comportements et les transitions en fonction d'un état.