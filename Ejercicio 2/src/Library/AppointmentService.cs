using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public DateTime Date { get; set; }
        public Paciente Patient { get; set; }
        public Doctor Doctor { get; set; }

        public bool IsValid()
        {
            return Patient != null &&
                   !string.IsNullOrEmpty(Patient.Name) &&
                   !string.IsNullOrEmpty(Patient.Id) &&
                   !string.IsNullOrEmpty(Patient.PhoneNumber) &&
                   !string.IsNullOrEmpty(Patient.AppointmentPlace) &&
                   Doctor != null &&
                   !string.IsNullOrEmpty(Doctor.Name);
        }
    }
    public class AppointmentService
    {
        public static string CreateAppointment(Appointment appointment)
        {
            StringBuilder stringBuilder = new StringBuilder("Agendando cita...\n");

            if (appointment.IsValid())
            {
                stringBuilder.Append("Cita programada");
            }
            else
            {
                stringBuilder.Append("No se puede programar la cita, faltan algunos campos obligatorios");
            }

            return stringBuilder.ToString();
        }
    }

}
