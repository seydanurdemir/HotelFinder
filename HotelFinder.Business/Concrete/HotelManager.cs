using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelManager()
        {
            // add business rules
            _hotelRepository = new HotelRepository(); // will be changed when adding dependency injection
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            // add business rules
            return _hotelRepository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            // add business rules
            // sample business rule addition
            if (id < 1)
            {
                throw new Exception("id can not be less than 1");
            }
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            // add business rules
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetHotelById(int id)
        {
            // add business rules
            // sample business rule addition
            if (id < 1)
            {
                throw new Exception("id can not be less than 1");
            }
            return _hotelRepository.GetHotelById(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            // add business rules
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
