using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ProtectedApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<object> Get()
        {
            var user = HttpContext.User.Identity.Name;
            var userSection = "32E2";
            var userCourse = "Bachelor of Science in Information Technology";

            var funFacts = new List<string>
            {
                "This Creator Loves to Play video games,
                "My name is Xzander James F. Nollora",
                "I'm the most energetic, especially with my friends, making sure they feel so happy that they won't even touch their phones when they're with me."
                "My favorite hobby is playing video games, mostly FPS and MOBA games like League of Legends."
                "I love spending time with dogs, cats, and almost all animals."
                "I have the most beautiful girlfriend in the world."
                "In the future, I want to travel to different places and countries."
                "Sometimes, I wonder what the future holds for me."
                "I often find myself lost in thoughts about the mysteries of the universe."

            };

            // Random generator
            var random = new Random();
            var selectedFacts = new List<string>();
            for (int i = 0; i < 3; i++)
            {
                var index = random.Next(funFacts.Count);
                selectedFacts.Add(funFacts[index]);
                funFacts.RemoveAt(index);
            }

            return new
            {
                UserName = user,
                Section = userSection,
                Course = userCourse,
                FunFacts = selectedFacts
            };
        }
    }
}