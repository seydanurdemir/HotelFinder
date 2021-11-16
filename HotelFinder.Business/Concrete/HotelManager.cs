using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            // add business rules
            _hotelRepository = hotelRepository; // dependency injection
        }
        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            // add business rules
            return await _hotelRepository.CreateHotel(hotel);
        }

        public async Task DeleteHotel(int id)
        {
            // add business rules
            // sample business rule addition
            //if (id < 1)
            //{
            //    throw new Exception("id can not be less than 1");
            //}
            await _hotelRepository.DeleteHotel(id);
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            // add business rules
            return await _hotelRepository.GetAllHotels();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            // add business rules
            // sample business rule addition
            //if (id < 1)
            //{
            //    throw new Exception("id can not be less than 1");
            //}
            return await _hotelRepository.GetHotelById(id);
        }

        public async Task<Hotel> UpdateHotel(Hotel hotel)
        {
            // add business rules
            return await _hotelRepository.UpdateHotel(hotel);
        }
    }
}
