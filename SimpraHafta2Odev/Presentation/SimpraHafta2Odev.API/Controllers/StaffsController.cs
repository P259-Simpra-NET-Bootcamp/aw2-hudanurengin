using SimpraHafta2Odev.Application.Repositories.Staffs;
using SimpraHafta2Odev.Application.ViewModels.Staff;
using SimpraHafta2Odev.Domain.Entity;
using SimpraHafta2Odev.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using SimpraHafta2Odev.Application.Repositories;
using System.Xml;

namespace SimpraHafta2Odev.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        readonly private IStaffWriteRepository _staffWriteRepository;
        readonly private IStaffReadRepository _staffReadRepository;

        public StaffsController(IStaffWriteRepository staffWriteRepository, IStaffReadRepository staffReadRepository)
        {
            _staffWriteRepository = staffWriteRepository;
            _staffReadRepository = staffReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_staffReadRepository.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Staff staff = await _staffReadRepository.GetByIdAsync(id);
            return Ok(staff);
        }

        [HttpGet("filters")]
        public IQueryable<Staff> GetWithFilters(string name, string city)
        {
            return _staffReadRepository.GetWhere(e => e.FirstName == name && e.City == city);
        }



        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Staff model)
        {
            await _staffWriteRepository.AddAsync(new()
            {
                CreatedBy = model.CreatedBy,
                CreatedAt = DateTime.UtcNow,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                DateOfBirth = model.DateOfBirth,
                AddressLine1 = model.AddressLine1,
                City = model.City,
                Country = model.Country,
                Province = model.Province,

            });
            await _staffWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Staff model)
        {
            Staff staff = await _staffReadRepository.GetByIdAsync(model.Id);
            staff.CreatedBy = model.CreatedBy;
            staff.FirstName = model.FirstName;
            staff.LastName = model.LastName;
            staff.Email = model.Email;
            staff.Phone = model.Phone;
            staff.DateOfBirth = model.DateOfBirth;
            staff.AddressLine1 = model.AddressLine1;
            staff.City = model.City;
            staff.Country = model.Country;
            staff.Province = model.Province;
            await _staffWriteRepository.SaveAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _staffWriteRepository.RemoveAsync(id);
            await _staffWriteRepository.SaveAsync();
            return Ok();
        }

    }


}