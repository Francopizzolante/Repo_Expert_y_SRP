using System;
using System.Text;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var patient = new Paciente
            {
                Name = "John Doe",
                Id = "123456",
                PhoneNumber = "555-555-5555",
                AppointmentPlace = "Hospital A"
            };

            var doctor = new Doctor
            {
                Name = "Dr. Smith"
            };

            var appointment = new Appointment
            {
                Date = DateTime.Now.AddDays(7),
                Patient = patient,
                Doctor = doctor
            };

            string result = AppointmentService.CreateAppointment(appointment);

            Console.WriteLine(result);
        }
    }
}
