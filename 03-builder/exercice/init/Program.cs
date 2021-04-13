using System;
using Xunit;

namespace _03.Builder
{
    // CODER ICI
    
    public class Enonce
    {
        /*[Fact]
        public void _01_Creer_une_classe_User()
        {
            var firstname = "Mickael";
            var lastname = "Metesreau";
            var email = "mickael.metesreau@softcraft.fr";
            var birthYear = 1988;
            var birthMonth = 1;
            var birthDay = 17;

            User user = new User(firstname, lastname, email, birthYear, birthMonth, birthDay);

            Assert.NotNull(user);

            Assert.Equal(firstname, user.Firstname);
            Assert.Equal(lastname, user.Lastname);
            Assert.Equal(email, user.Email);
            Assert.Equal(birthYear, user.BirthYear);
            Assert.Equal(birthMonth, user.BirthMonth);
            Assert.Equal(birthDay, user.BirthDay);
        }*/

        /*[Fact]
        public void _02_Creer_une_classe_UserBuilder()
        {
            UserBuilder userBuilder = new UserBuilder();

            Assert.NotNull(userBuilder);
        }*/

        /*[Fact]
        public void _03_Creer_une_methode_pour_stocker_le_prenom_d_un_user()
        {
            UserBuilder userBuilder = new UserBuilder();

            userBuilder = userBuilder
                                .WithFirstname("Mickael");

            Assert.NotNull(userBuilder);
        }*/

        /*[Fact]
        public void _04_Creer_une_methode_build_qui_renvoit_un_user_initialise_avec_le_prenom_d_un_user()
        {
            var firstname = "Mickael";

            UserBuilder userBuilder = new UserBuilder();

            User user =
                    userBuilder
                        .WithFirstname(firstname)
                        .Build();

            Assert.Equal(firstname, user.Firstname);
        }*/

        /*[Fact]
        public void _05_Repeter_pour_les_proprietes_manquantes()
        {
            var firstname = "Mickael";
            var lastname = "Metesreau";
            var email = "mickael.metesreau@softcraft.fr";
            var birthYear = 1988;
            var birthMonth = 1;
            var birthDay = 17;

            UserBuilder userBuilder = new UserBuilder();

            User user =
                    userBuilder
                        .WithFirstname(firstname)
                        .WithLastname(lastname)
                        .WithEmail(email)
                        .WithBirthYear(birthYear)
                        .WithBirthMonth(birthMonth)
                        .WithBirthDay(birthDay)
                        .Build();

            Assert.Equal(firstname, user.Firstname);
            Assert.Equal(lastname, user.Lastname);
            Assert.Equal(email, user.Email);
            Assert.Equal(birthYear, user.BirthYear);
            Assert.Equal(birthMonth, user.BirthMonth);
            Assert.Equal(birthDay, user.BirthDay);
        }*/
    }
}
