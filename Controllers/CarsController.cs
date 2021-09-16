using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_API_Car.Model;
using Web_API_Car.Models;

namespace Web_API_Car.Controllers
{
    //The API controller to manage the car information table
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly Web_API_CarContext _context;

        
        public CarsController(Web_API_CarContext context)
        {
            _context = context;
        }

        // GET: api/Cars
        //Gets all the cars 
        [HttpGet]
        public IEnumerable<Car> GetCar()
        {
            return _context.Car;
        }

        // GET: api/Cars/5
        //Gets a car with specific Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Car.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        // PUT: api/Cars/5
        //Update a car 
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar([FromRoute] string id, [FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cars
        //Adds a new car to the database.
        [HttpPost]
        public async Task<IActionResult> PostCar([FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Car.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { id = car.Id }, car);
        }

        // DELETE: api/Cars/5
        //Delets the car from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }

            _context.Car.Remove(car);
            await _context.SaveChangesAsync();

            return Ok(car);
        }

        //Check whether the car exists.
        private bool CarExists(string id)
        {
            return _context.Car.Any(e => e.Id == id);
        }
    }
}