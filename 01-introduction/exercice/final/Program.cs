using System.Reflection;
using Xunit;

namespace _01.HelloKebab
{
    public abstract class Kebab
    {
        public abstract bool IsVegetarian();
        public abstract Kebab RemoveOnion();
        public abstract Kebab DoubleCheese();
    }

    public class Bread : Kebab
    {
        public override bool IsVegetarian() => true;
        public override Kebab RemoveOnion() => this;
        public override Kebab DoubleCheese() => this;
    }

    public class Onion : Kebab
    {
        readonly Kebab _innerKebab;

        public Onion(Kebab innerKebab)
        {
            _innerKebab = innerKebab;
        }

        public override bool IsVegetarian() => _innerKebab.IsVegetarian();
        public override Kebab RemoveOnion() => _innerKebab.RemoveOnion();
        public override Kebab DoubleCheese() => new Onion(_innerKebab.DoubleCheese());
    }

    public class Tomato : Kebab
    {
        readonly Kebab _innerKebab;

        public Tomato(Kebab innerKebab)
        {
            _innerKebab = innerKebab;
        }

        public override bool IsVegetarian() => _innerKebab.IsVegetarian();
        public override Kebab RemoveOnion() => new Tomato(_innerKebab.RemoveOnion());
        public override Kebab DoubleCheese() => new Tomato(_innerKebab.DoubleCheese());

    }

    public class Meat : Kebab
    {
        readonly Kebab _innerKebab;

        public Meat(Kebab innerKebab)
        {
            _innerKebab = innerKebab;
        }

        public override bool IsVegetarian() => false;
        public override Kebab RemoveOnion() => new Meat(_innerKebab.RemoveOnion());
        public override Kebab DoubleCheese() => new Meat(_innerKebab.DoubleCheese());
    }

    public class Cheese : Kebab
    {
        readonly Kebab _innerKebab;

        public Cheese(Kebab innerKebab)
        {
            _innerKebab = innerKebab;
        }

        public override bool IsVegetarian() => _innerKebab.IsVegetarian();
        public override Kebab RemoveOnion() => new Cheese(_innerKebab.RemoveOnion());
        public override Kebab DoubleCheese() => new Cheese(new Cheese(_innerKebab.DoubleCheese()));
    }

    public class Playground
    {
        [Fact]
        public void un_kebab_sans_viande_est_vegetarien()
        {
            var kebab = new Tomato(new Bread());

            Assert.True(kebab.IsVegetarian());
        }

        [Fact]
        public void un_kebab_avec_viande_nest_vegetarien()
        {
            var kebab1 = new Meat(new Tomato(new Bread()));

            Assert.False(kebab1.IsVegetarian());

            var kebab2 = new Tomato(new Meat(new Bread()));

            Assert.False(kebab2.IsVegetarian());
        }

        [Fact]
        public void un_kebab_ne_doit_plus_avoir_doignon_apres_RemoveOnion()
        {
            var kebab = new Meat(new Onion(new Tomato(new Bread())));

            var kebab1 = kebab.RemoveOnion();
        }
        
        [Fact]
        public void un_kebab_doit_avoir_une_double_couche_de_fromage_apres_DoubleCheese()
        {
            var kebab = new Meat(new Cheese(new Onion(new Tomato(new Bread()))));

            var kebab1 = kebab.DoubleCheese();
        }
    }
}