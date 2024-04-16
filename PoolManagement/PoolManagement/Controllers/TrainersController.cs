using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PoolManagement.Database;
using PoolManagement.Database.DbModels;
using PoolManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        private readonly PoolManagementDbContext _dbContext;


        public TrainersController(PoolManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<TrainerDTO> GetTrainers()
        {

            // tabel baza de date
            var trainersTable = _dbContext.Trainers;

            // tabel baza de date transformat in lista de obiecte TrainerDTO

            List<TrainerDTO> result = new List<TrainerDTO>();

            foreach (var t in trainersTable)
            {
                var trainerDto = new TrainerDTO();

                trainerDto.ID = t.ID_Trainer;
                trainerDto.Name = t.Name;

                var studentsForTrainer = _dbContext.Students.Where(s => s.Trainer_ID == t.ID_Trainer);

                if (studentsForTrainer.Count() < 10)
                {
                    result.Add(trainerDto);
                }
            }


            // la fel ca si mai sus, scrisa altfel

            //var result = trainersTable.Select(r => new TrainerDTO()
            //{
            //    ID = r.ID_Trainer,
            //    Name = r.Name,
            //});

            return result;
        }

        [HttpGet("TrainerStudents/{id}")]
        public ActionResult<List<StudentDTO>> GetTrainerStudents(int id)
        {
            var studentsTable = _dbContext.Students;

            List<StudentDTO> result = new List<StudentDTO>();    // functia asta seamana foarte mult cu Get cea de sus

            var students = studentsTable.Where((x => x.Trainer_ID == id));

            return Ok(students);
        }

        [HttpPost]
        public IActionResult CreateTrainer(TrainerDTO newTrainerDto)
        {
            var trainersTable = _dbContext.Trainers;

            Trainer trainer = new Trainer();
            trainer.Name = newTrainerDto.Name;
            trainersTable.Add(trainer);

            _dbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]

        public IActionResult ModifyTrainer(TrainerDTO trainerDto)
        {
            var trainersTable = _dbContext.Trainers;
            var trainer = trainersTable.FirstOrDefault(x => x.ID_Trainer == trainerDto.ID);
            trainer.Name = trainerDto.Name;

            // in functia asta PUT,eu trebuie sa preiau ceva de la front-end
            //si sa modific lista mea cu cea am preluat de la front-end!!
            //primesc ca parametru un obiect trainerDto,care contine si id si nume,exact ca si clasa mea TrainerDTO

            _dbContext.SaveChanges();

            return Ok();

        }

        [HttpDelete("{id}")]

        public IActionResult DeleteTrainer(int id)
        {
            var trainersTable = _dbContext.Trainers;
            var trainer = trainersTable.FirstOrDefault(x => x.ID_Trainer == id);

            if (trainer == null)
            {
                return NotFound($"Trainer-ul cu id-ul {id} nu exista");
            }

            trainersTable.Remove(trainer);

            _dbContext.SaveChanges();

            return Ok("Trainer-ul a fost sters cu succes");
        }

    }
}
