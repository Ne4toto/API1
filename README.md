        [Route("api/GetStudentName")]
        public IHttpActionResult GetStudentName(int StudentId)
        {
            var studentName = db.Student.ToList().Where(p => p.Id_Student == StudentId).ToList();
            return Ok(studentName);
        }
