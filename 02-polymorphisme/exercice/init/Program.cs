using System;
using Xunit;

namespace _02.HelloPolymorphisme
{
    // CODER ICI
  
    public class Enonce
    {
        /*[Fact]
        public void _01_Creer_une_classe_Lesson()
        {
            var lessonStartDateTime = DateTime.Now;
        
            Lesson lesson = new Lesson(lessonStartDateTime);
        
            Assert.NotNull(lesson);
        }*/
        
        /*[Fact]
        public void _02_Creer_une_classe_ClockService_qui_renvoit_la_date_courante()
        {
            ClockService clockService = new ClockService();
    
            Assert.NotNull(clockService);
    
            DateTime now = clockService.Now();
        }*/


        /*[Fact]
        public void _03_Creer_une_classe_MockClockService_pour_controller_le_temps()
        {
            var dateTimeToReturn = DateTime.Now;
    
            MockClockService mockClockService = new MockClockService(dateTimeToReturn);
    
            Assert.NotNull(mockClockService);
    
            DateTime now = mockClockService.Now();
    
            Assert.Equal(dateTimeToReturn, now);
        }*/

        /*[Fact]
        public void _04_Creer_une_interface_IClockService_pour_unifier_MockClockService_et_ClockService()
        {
            IClockService clockService;
            DateTime? now;
    
            clockService = new ClockService();
    
            Assert.NotNull(clockService);
    
            now = clockService.Now();
    
            Assert.NotNull(now);
    
            clockService = new MockClockService(DateTime.Now);
    
            Assert.NotNull(clockService);
    
            now = clockService.Now();
    
            Assert.NotNull(now);
        }*/

        /*[Fact]
        public void _05_Creer_une_methode_isBreakTime_qui_utilise_IClockService_pour_renvoyer_true_si_le_cours_a_debute_depuis_plus_de_1h30()
        {
            var lessonStartDateTime = DateTime.Now;
    
            Lesson lesson = new Lesson(lessonStartDateTime);
    
            var dateTimeToReturn = lessonStartDateTime.AddHours(1).AddMinutes(31);
    
            IClockService mockClockService = new MockClockService(dateTimeToReturn);
    
            bool isBreakTime = lesson.IsBreakTime(mockClockService);
    
            Assert.True(isBreakTime);
        }*/

        /*[Fact]
        public void _06_Renvoyer_false_si_le_cours_a_debute_depuis_moins_de_1h30()
        {
            var lessonStartDateTime = DateTime.Now;
    
            Lesson lesson = new Lesson(lessonStartDateTime);
    
            var dateTimeToReturn = lessonStartDateTime.AddHours(1).AddMinutes(29);
    
            IClockService mockClockService = new MockClockService(dateTimeToReturn);
    
            bool isBreakTime = lesson.IsBreakTime(mockClockService);
    
            Assert.False(isBreakTime);
        }*/
    }
}