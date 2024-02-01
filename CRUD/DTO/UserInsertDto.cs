namespace CRUD.DTO
{
    public class UserInsertDto
    {
        //no necesito el id porque no lo conozco a la hora de insertarlo.
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
