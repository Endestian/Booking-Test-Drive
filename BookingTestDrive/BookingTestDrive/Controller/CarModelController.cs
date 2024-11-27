using BookingTestDrive.Model;
using BookingTestDrive.Repository;

namespace BookingTestDrive.Controller;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class CarModelController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public CarModelController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/carmodel
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarModel>>> GetCarModels()
    {
        return await _context.CarModels.ToListAsync();
    }

    // POST: api/carmodel
    [HttpPost]
    public async Task<ActionResult<CarModel>> PostCarModel(CarModel carModel)
    {
        _context.CarModels.Add(carModel);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetCarModels), new { id = carModel.Id }, carModel);
    }

    // PUT: api/carmodel/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> PutCarModel(int id, CarModel carModel)
    {
        if (id != carModel.Id)
        {
            return BadRequest();
        }

        _context.Entry(carModel).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!CarModelExists(id))
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

    // DELETE: api/carmodel/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCarModel(int id)
    {
        var carModel = await _context.CarModels.FindAsync(id);
        if (carModel == null)
        {
            return NotFound();
        }

        _context.CarModels.Remove(carModel);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool CarModelExists(int id)
    {
        return _context.CarModels.Any(e => e.Id == id);
    }
}