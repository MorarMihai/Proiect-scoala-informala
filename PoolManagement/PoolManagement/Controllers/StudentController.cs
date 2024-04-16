using Microsoft.AspNetCore.Mvc;
using PoolManagement.Database;
using PoolManagement.Database.DbModels;
using PoolManagement.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace PoolManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly PoolManagementDbContext _dbContext;
        public StudentController(PoolManagementDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentDTO newstudentDTO)
        {
            var answer = CheckTrainersForEmptySlots();
            if (answer == true)
            {

                Student student = new Student();
                student.Name = newstudentDTO.Name;
                student.Email = newstudentDTO.Email;
                student.PhoneNumber = newstudentDTO.PhoneNumber;
                student.Category = newstudentDTO.Category;
                student.Trainer_ID = newstudentDTO.Trainer_ID;  

                _dbContext.Students.Add(student);

                _dbContext.SaveChanges();
                return Ok();
            }

            return BadRequest("Ne pare rău.Toți antrenorii noștri sunt ocupați.Lăsați - ne date de contact și vă vom contacta deîndată de apare o poziție liberă!");
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            var categories = new List<string>()
            {
                "copil",
                "student",
                "adult",
                "pensionar"
             };    

            return Ok(categories);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var students = _dbContext.Students;      
            
               var  student = students.FirstOrDefault(x => x.ID_Student == id);

                if (student == null)
                {
                    return NotFound($"Studentul cu id-ul {id} nu exista");
                }

                students.Remove(student);

                _dbContext.SaveChanges();

                return Ok("Studentul a fost sters cu succes");
            
        }

        private bool CheckTrainersForEmptySlots()
        {
            var trainers = _dbContext.Trainers;
            var students = _dbContext.Students;
            bool answer = false;

            foreach (var trainer in trainers)   // trebuie sa verific la cati studenti am ID-ul trainerului curent
            {
                var studentsForTrainer = _dbContext.Students.Where(s => s.Trainer_ID == trainer.ID_Trainer);  // la fiecare iteratie,programul ia un ID_trainer,si il compara
                 
                if(studentsForTrainer.Count() < 10)
                {
                    answer = true;
                }                                                                                         // cu toate Trainer_ID din tabela Students,si creeaza o lista cu acele obiecte                                                                                               //apoi itereaza din nou,si face din nou o lista
            }

            return answer;
        }
        

    }
}
