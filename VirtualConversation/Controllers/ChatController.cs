using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualConversation.Controllers
{
    public class ChatController : Controller
    {

        public static Dictionary<int, string> Rooms = new Dictionary<int, string>()
        {
            {1,"Sala General"},
            {2,"Sala De Estudios 01"},
            {3,"Sala De Proyecciones 01"}
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Room(int idRoom)
        {
            return View("Room", idRoom);
        }
    }
}
