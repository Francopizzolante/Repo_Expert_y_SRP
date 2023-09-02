using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        public DateTime Date { get; set; }
        public Patient Patient { get; set; }
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
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (appointment.IsValid())
            {
                stringBuilder.Append("Appointment scheduled");
            }
            else
            {
                stringBuilder.Append("Unable to schedule appointment, some required fields are missing");
            }

            return stringBuilder.ToString();
        }
    }

}
