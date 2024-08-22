﻿using ClinicManager.Api.Enums;


namespace ClinicManager.Api.Entities
{
    public class CustomerService : BaseEntity
    {
        public CustomerService() { }
        public CustomerService(int patientId, int serviceId, int doctorId, string agreement,  ServiceType typeService)
        {
            PatientId = patientId;
            ServiceId = serviceId;
            DoctorId = doctorId;
            Agreement = agreement;
            TypeService = typeService;
            Start = DateTime.Now;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int ServiceId { get; set; }
        public int DoctorId { get; set; }
        public string Agreement { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }
        public ServiceType TypeService { get; set; } 
    }
}
