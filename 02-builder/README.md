# Builder

Imaginons le code suivant :

```C#
public class Pizza
{
    public Pizza(int size, bool onion, bool cheese, bool olives, bool tomato, bool corn, bool mushroom)
    { }
}
```

Puis tentons de l'utiliser :

```C#
var pizza = new Pizza(10, true, false, true, false, true, true);
```

Difficile de comprendre à quoi correspondent les paramètres d'initialisation :(

Essayons une autre implémentation :

```C#
public class Pizza
{
    public int Size { get; set; }
    public bool Onion { get; set; }
    public bool Cheese { get; set; }
    public bool Olives { get; set; }
    public bool Tomato { get; set; }
    public bool Corn { get; set; }
    public bool Mushroom { get; set; }

    public Pizza()
    { }
}
```

Puis tentons de l'utiliser :

```C#
var pizza = new Pizza
{
    Size = 10,
    Cheese = true,
    Corn = true,
    Mushroom = false,
    Olives = true,
    Onion = true,
    Tomato = true
};
```

Beaucoup plus lisible mais... on ne garantie plus que tout les paramètres soit passés pour initialiser notre objet.

```C#
var pizzaOups = new Pizza
{
    Onion = true,
    Tomato = true
};
```

Tentons de résoudre le problème avec un design pattern appelé Builder :

```C#
class PizzaBuilder
{
    private bool? _cheese;
    private bool? _corn;
    private bool? _mushroom;
    private bool? _olives;
    private bool? _onion;
    private bool? _tomato;
    private int? _size;

    public PizzaBuilder WithCheese(bool cheese)
    {
        _cheese = cheese;
        return this;
    }

    public PizzaBuilder WithCorn(bool corn)
    {
        _corn = corn;
        return this;
    }

    public PizzaBuilder WithMushroom(bool mushroom)
    {
        _mushroom = mushroom;
        return this;
    }

    public PizzaBuilder WithOlives(bool olives)
    {
        _olives = olives;
        return this;
    }

    public PizzaBuilder WithOnion(bool onion)
    {
        _onion = onion;
        return this;
    }

    public PizzaBuilder WithTomato(bool tomato)
    {
        _tomato = tomato;
        return this;
    }

    public PizzaBuilder WithSize(int size)
    {
        _size = size;
        return this;
    }

    public Pizza Build()
    {
        if (!_size.HasValue
            || !_onion.HasValue
            || !_cheese.HasValue
            || !_olives.HasValue
            || !_tomato.HasValue
            || !_corn.HasValue
            || !_mushroom.HasValue) throw new ArgumentNullException();

        return new Pizza(_size.Value, _onion.Value, _cheese.Value, _olives.Value, _tomato.Value, _corn.Value, _mushroom.Value);
    }
}
```

Utilisons le :

```C#
var pizza = new PizzaBuilder()
                    .WithtoutChesse(false)
                    .WithCorn(true)
                    .WithOnion(false)
                    .WithSize(10)
                    .WithMushroom(false)
                    .WithTomato(true)
                    .WithOlives(false)
                    .Build();
```

Le design pattern builder est un design pattern de création qui permet de configurer et créer des objets complexes étape par étape de manière simple et lisible.