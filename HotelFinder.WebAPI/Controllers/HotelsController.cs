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
    /// <summary>
    /// API for Hotels
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        
        /// <summary>
        /// Takes hotels from hotel service.
        /// </summary>
        /// <param name="hotelService"></param>
        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService; // dependency injection
        }

        /// <summary>
        /// Gets all hotels.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var hotels = _hotelService.GetAllHotels();
            return Ok(hotels); // 200 + data
        }

        /// <summary>
        /// Gets the hotel by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]
        public IActionResult GetHotelById(int id)
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel != null) 
            {
                return Ok(hotel); // 200 + data
            }
            return NotFound(); // 404
        }

        /// <summary>
        /// Creates a hotel.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public IActionResult CreateHotel([FromBody]Hotel hotel)
        {
            // [ApiController] annotation already controls validation
            // We can remove this control from here
            //if (ModelState.IsValid)
            //{
                var createdHotel = _hotelService.CreateHotel(hotel);
                return CreatedAtAction("Get", new { id = createdHotel.Id }, createdHotel ); // 201 + data
            //}
            //return BadRequest(ModelState); // 400 + validation errors
        }

        /// <summary>
        /// Updates the hotel from body.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public IActionResult UpdateHotel([FromBody]Hotel hotel)
        {
            if (_hotelService.GetHotelById(hotel.Id) != null) 
            {
                return Ok(_hotelService.UpdateHotel(hotel)); // 200 + data
            }
            return NotFound(); // 404
        }

        /// <summary>
        /// Deletes the hotel by id.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult DeleteHotel(int id)
        {
            if (_hotelService.GetHotelById(id) != null)
            {
                _hotelService.DeleteHotel(id);
                return Ok(); // 200
            }
            return NotFound(); // 404
        }
    }
}
