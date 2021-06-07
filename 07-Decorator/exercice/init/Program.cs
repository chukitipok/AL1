using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace _07.Decorator
{
    // CODER ICI

    public class Enonce
    {        
        /*[Fact]
        public void _01_Creer_une_classe_Book_avec_une_propriete_Name_et_Price()
        {
            Book book = new Book("Dune", 10M);

            Assert.Equal("Dune", book.Name);
            Assert.Equal(10M, book.Price);
        }*/

        /*[Fact]
        public void _02_Creer_une_classe_Coffee_avec_une_propriete_Name_et_Price()
        {
            Coffee coffee = new Coffee("Expresso", 1M);

            Assert.Equal("Expresso", coffee.Name);
            Assert.Equal(1M, coffee.Price);
        }*/

        /*[Fact]
        public void _03_Creer_une_interface_Item_avec_une_propriete_get_Name_et_get_Price_pour_unifier_Book_et_Coffee()
        {
            Item book = new Book("Dune", 10M);

            Assert.Equal("Dune", book.Name);
            Assert.Equal(10M, book.Price);

            Item coffee = new Coffee("Expresso", 1M);

            Assert.Equal("Expresso", coffee.Name);
            Assert.Equal(1M, coffee.Price);
        }*/

        /*[Fact]
        public void _04_Creer_une_classe_SpecialOffer_initialisable_avec_un_item_et_un_pourcentage_de_reduction()
        {
            Item book = new Book("Dune", 10M);

            SpecialOffer offer1 = new SpecialOffer(book, 10);

            Assert.Equal("Dune", offer1.Name);
            Assert.Equal(9M, offer1.Price);

            Item coffee = new Coffee("Expresso", 1M);

            SpecialOffer offer2 = new SpecialOffer(coffee, 5);

            Assert.Equal("Expresso", offer2.Name);
            Assert.Equal(0.95M, offer2.Price);
        }*/

        /*[Fact]
        public void _05_Creer_une_classe_abstraite_ItemDecorator_implementant_l_interface_item_et_initialisable_avec_un_item_et_faire_heriter_SpecialOffer_de_ItemDecorator()
        {
            Item offer = new SpecialOffer(new Book("Dune", 10M), 10);

            Assert.IsAssignableFrom<Item>(offer);
            Assert.IsAssignableFrom<ItemDecorator>(offer);
        }*/
    }
}
