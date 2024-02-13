using FlightSimulatorControlCenter.Service;
using FlightSimulatorControlCenter.Service.Int;

namespace FlightSimulatorControlCenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Sono singleton
            IValidationUserInputService validationService = new ValidationUserInputService();

            Application.Run(new Step1Init(validationService));
        }
    }
}