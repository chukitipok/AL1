using System;
using Xunit;

namespace _04.Factory
{
    // CODER ICI
    
    public class Enonce
    {
        /*[Fact]
        public void _01_Creer_une_classe_XmlLogger_avec_une_methode_Log()
        {
            XmlLogger xmlLogger = new XmlLogger();

            string log = xmlLogger.Log("mon log");

            Assert.Equal("<log>mon log</log>", log);
        }*/

        /*[Fact]
        public void _02_Creer_une_classe_JsonLogger_avec_une_methode_Log()
        {
            JsonLogger jsonLogger = new JsonLogger();

            string log = jsonLogger.Log("mon log");

            Assert.Equal("{Log:'mon log'}", log);
        }*/

        /*[Fact]
        public void _03_Creer_une_interface_ILogger_avec_une_methode_Log_pour_unifier_XmlLogger_et_JsonLogger()
        {
            ILogger xmlLogger = new XmlLogger();

            string xmlLog = xmlLogger.Log("mon log");

            ILogger jsonLogger = new JsonLogger();

            string jsonLog = jsonLogger.Log("mon log");

            Assert.Equal("<log>mon log</log>", xmlLog);

            Assert.Equal("{Log:'mon log'}", jsonLog);
        }*/

        /*[Fact]
        public void _04_Creer_une_classe_Logger_avec_une_methode_statique_Create()
        {
            ILogger logger = Logger.Create(Logger.Format.Xml);

            string log = logger.Log("mon log");

            Assert.Equal("<log>mon log</log>", log);

            logger = Logger.Create(Logger.Format.Json);

            log = logger.Log("mon log");

            Assert.Equal("{Log:'mon log'}", log);
        }*/
    }
}
