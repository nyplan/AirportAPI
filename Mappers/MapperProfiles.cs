using AirportAPI.DTOs.AirportDTOs;
using AirportAPI.DTOs.BaggageDTOs;
using AirportAPI.DTOs.BookingDTOs;
using AirportAPI.DTOs.FeedbackDTOs;
using AirportAPI.DTOs.FlightDTOs;
using AirportAPI.DTOs.PassengerDTOs;
using AirportAPI.DTOs.PaymentDTOs;
using AirportAPI.DTOs.TicketDTOs;
using AirportAPI.Entities;
using AutoMapper;

namespace AirportAPI.Mappers
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<Airport, AirportToListDto>()
                .ForMember(dest => dest.City, src => src.MapFrom(c => c.City.Name))
                .ForMember(dest => dest.Country, src => src.MapFrom(c => c.City.Country));
            CreateMap<Airport, AirportByIdDto>()
                .ForMember(dest => dest.City, src => src.MapFrom(c => c.City.Name))
                .ForMember(dest => dest.Country, src => src.MapFrom(c => c.City.Country));
            CreateMap<AirportToAddDto, Airport>();
            CreateMap<AirportToUpdateDto, Airport>();

            CreateMap<Baggage, BaggageToListDto>()
                .ForMember(dest => dest.Passenger, src => src.MapFrom(c => c.Booking.Passenger.Fullname));
            CreateMap<Baggage, BaggageByIdDto>()
                .ForMember(dest => dest.Passenger, src => src.MapFrom(c => c.Booking.Passenger.Fullname));
            CreateMap<BaggageToAddDto, Baggage>();
            CreateMap<BaggageToUpdateDto, Baggage>();

            CreateMap<Booking, BookingToListDto>();
            CreateMap<Booking, BookingByIdDto>();
            CreateMap<BookingToAddDto, Booking>();
            CreateMap<BookingToUpdateDto, Booking>();

            CreateMap<Feedback, FeedbackToListDto>()
                .ForMember(dest => dest.Passenger, src => src.MapFrom(c => c.Passenger.Fullname))
                .ForMember(dest => dest.Rating, src => src.MapFrom(c => c.Rating.Value));
            CreateMap<Feedback, FeedbackByIdDto>()
                .ForMember(dest => dest.Passenger, src => src.MapFrom(c => c.Passenger.Fullname))
                .ForMember(dest => dest.Rating, src => src.MapFrom(c => c.Rating.Value));

            CreateMap<Flight, FlightToListDto>();
            CreateMap<Flight, FlightByIdDto>();
            CreateMap<FlightToAddDto, Flight>();
            CreateMap<FlightToUpdateDto, Flight>();

            CreateMap<Passenger, PassengerToListDto>();
            CreateMap<Passenger, PassengerByIdDto>();
            CreateMap<PassengerToAddDto, Passenger>();
            CreateMap<PassengerToUpdateDto, Passenger>();

            CreateMap<Payment, PaymentToListDto>();
            CreateMap<Payment, PaymentByIdDto>();
            CreateMap<PaymentToAddDto, Payment>();
            CreateMap<PaymentToUpdateDto, Payment>();

            CreateMap<Ticket, TicketToListDto>();
            CreateMap<Ticket, TicketByIdDto>();
            CreateMap<TicketToAddDto, Ticket>();
            CreateMap<TicketToUpdateDto, Ticket>();
        }
    }
}
