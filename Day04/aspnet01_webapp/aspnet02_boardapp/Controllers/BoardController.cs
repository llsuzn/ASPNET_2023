using aspnet02_boardapp.Data;
using aspnet02_boardapp.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet02_boardapp.Controllers
{
    // https://localhost:7181/Board/Index
    public class BoardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BoardController(ApplicationDbContext db)
        {
            _db = db;       // 알아서 DB가 연결 됨
        }


        // 게시판 최초화면 리스트
        public IActionResult Index()
        {
            IEnumerable<Board> objBoardList = _db.Boards.ToList();      // SELECT 쿼리
            return View(objBoardList);
        }

        // https://localhost:7181/Board/Create
        // GetMethod로 화면을 URL로 부를 때 액션

        // 게시판 글쓰기
        public IActionResult Create()
        {
            return View();
        }

        // Submit이 발생해서 내부로 데이터를 전달하는 액션
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Board board)
        {
            _db.Boards.Add(board);
            _db.SaveChanges();

            return RedirectToAction("Index","Board");
        }
    }
}
