using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        
        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService; // dependency injection
        }

        /// <summary>
        /// Gets all hotels.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels();
        }

        /// <summary>
        /// Gets hotel by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Hotel GetById(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        /// <summary>
        /// Create hotel.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        /// <summary>
        /// Update the hotel from body.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        public Hotel Put([FromBody]Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }

        /// <summary>
        /// Delete the hotel by id.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
