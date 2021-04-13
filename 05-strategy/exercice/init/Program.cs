using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace _05.Strategy
{
    // CODER ICI

    public class Enonce
    {
        /*[Fact]
        public void _01_Creer_une_classe_CreditCard_avec_une_methode_Pay()
        {
            CreditCard creditCard = new CreditCard();

            string transaction = creditCard.Pay(10);

            Assert.Equal("10 has been charged to my credit card", transaction);
        }*/

        /*[Fact]
        public void _02_Creer_une_classe_Paypal_avec_une_methode_Pay()
        {
            Paypal paypal = new Paypal();

            string transaction = paypal.Pay(10);

            Assert.Equal("10 has been charged to my paypal account", transaction);
        }*/

        /*[Fact]
        public void _03_Creer_une_interface_IPaiement_avec_une_methode_Pay_pour_unifier_CreditCard_et_Paypal()
        {
            IPayement creditCard = new CreditCard();

            string creditCardTransaction = creditCard.Pay(100);

            IPayement paypal = new Paypal();

            string paypalTransaction = paypal.Pay(1000);

            Assert.Equal("100 has been charged to my credit card", creditCardTransaction);

            Assert.Equal("1000 has been charged to my paypal account", paypalTransaction);
        }*/

        /*[Fact]
        public void _04_Creer_une_classe_ShoppingCard_avec_une_methode_AddItem()
        {
            ShoppingCard shoppingCard = new ShoppingCard();

            shoppingCard.AddItem("apple", 10);
            shoppingCard.AddItem("banana", 10);

            Assert.NotNull(shoppingCard);
        }*/

        /*[Fact]
        public void _05_Creer_une_methode_Pay_qui_prend_en_paramètre_une_strategie_de_paiement()
        {
            ShoppingCard shoppingCard = new ShoppingCard();

            shoppingCard.AddItem("apple", 10);
            shoppingCard.AddItem("banana", 10);

            string transaction = shoppingCard.Pay(new CreditCard());

            Assert.Equal("20 has been charged to my credit card", transaction);

            shoppingCard = new ShoppingCard();

            shoppingCard.AddItem("Manga", 15);

            transaction = shoppingCard.Pay(new Paypal());

            Assert.Equal("15 has been charged to my paypal account", transaction);
        }*/
    }
}
