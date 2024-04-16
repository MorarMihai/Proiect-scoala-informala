namespace PoolManagement.Database.DbModels
{
    public class Student
    {
        public long ID_Student { get; set; } 
        public string Name { get; set; } 
        public string Email { get; set; }   
        public int PhoneNumber { get; set; }  
        public long Trainer_ID { get; set; }    
        public string Category { get; set; }
       
    }
}
