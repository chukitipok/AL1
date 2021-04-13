using System;
using Xunit;

namespace _03.Builder
{
    // CODER ICI

    public class User
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string Email { get; }
        public int BirthYear { get; }
        public int BirthMonth { get; }
        public int BirthDay { get; }

        public User(string firstname, string lastname, string email, int birthYear, int birthMonth, int birthDay)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            BirthYear = birthYear;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
    }

    public class UserBuilder
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private int _birthYear;
        private int _birthMonth;
        private int _birthDay;
        
        public UserBuilder WithFirstname(string firstname)
        {
            _firstname = firstname;
            return this;
        }

        public UserBuilder WithLastname(string lastname)
        {
            _lastname = lastname;
            
            return this;
        }
        
        public UserBuilder WithEmail(string email)
        {
            _email = email;
            
            return this;
        }
        
        public UserBuilder WithBirthYear(int birthYear)
        {
            _birthYear = birthYear;
            
            return this;
        }
        
        public UserBuilder WithBirthMonth(int birthMonth)
        {
            _birthMonth = birthMonth;
            
            return this;
        }
        
        public UserBuilder WithBirthDay(int birthDay)
        {
            _birthDay = birthDay;
            
            return this;
        }
        
        public User Build()
        {
            return new User(_firstname, _lastname, _email, _birthYear, _birthMonth, _birthDay);
        }
    }

    public class Enonce
    {
        [Fact]
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
        }

        [Fact]
        public void _02_Creer_une_classe_UserBuilder()
        {
            UserBuilder userBuilder = new UserBuilder();

            Assert.NotNull(userBuilder);
        }

        [Fact]
        public void _03_Creer_une_methode_pour_stocker_le_prenom_d_un_user()
        {
            UserBuilder userBuilder = new UserBuilder();

            userBuilder = userBuilder
                                .WithFirstname("Mickael");

            Assert.NotNull(userBuilder);
        }

        [Fact]
        public void _04_Creer_une_methode_build_qui_renvoit_un_user_initialise_avec_le_prenom_d_un_user()
        {
            var firstname = "Mickael";

            UserBuilder userBuilder = new UserBuilder();

            User user =
                    userBuilder
                        .WithFirstname(firstname)
                        .Build();

            Assert.Equal(firstname, user.Firstname);
        }

        [Fact]
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
        }
    }
}
