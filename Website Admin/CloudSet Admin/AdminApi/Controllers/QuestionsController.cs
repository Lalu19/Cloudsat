using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using AdminApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using AdminApi.Models.App;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Questions> _QuestionsRepo;
        public QuestionsController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Questions> QuestionsRepo)

        {
            _config = config;
            _context = context;
            _QuestionsRepo = QuestionsRepo;

        }
        [HttpPost]
        public IActionResult QuestionsCreate(QuestionsDTO questionsDTO)
        {
            try
            {
                Questions questions = new Questions();
                questions.question = questionsDTO.question;
                questions.answer = questionsDTO.answer;
                questions.CreatedBy = questionsDTO.CreatedBy;
                questions.CreatedOn = System.DateTime.Now;
                var obj = _QuestionsRepo.Insert(questions);
                return Ok(obj);


            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetQuestionsList()
        {
            try
            {
                var list = (from u in _context.Questions


                            select new { u.QuestionsId, u.question, u.answer, u.IsDeleted }).Where(x => x.IsDeleted == false).ToList();


                int totalRecords = list.Count();


                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //single list
        [HttpGet("{QuestionsId}")]
        public ActionResult GetSingleQuestions(int QuestionsId)
        {
            try
            {
                var singleQuestions = _QuestionsRepo.SelectById(QuestionsId);
                return Ok(singleQuestions);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //update
        [HttpPost]
        public ActionResult updateQuestions(UpdateQuestionsDTO updateQuestionsDTO)
        {
            try
            {
                var obj = _context.Questions.SingleOrDefault(opt => opt.QuestionsId == updateQuestionsDTO.QuestionsId);
                obj.question = updateQuestionsDTO.question;
                obj.answer = updateQuestionsDTO.answer;
                obj.UpdatedBy = updateQuestionsDTO.CreatedBy;
                obj.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteQuestions(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Questions.SingleOrDefault(opt => opt.QuestionsId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}