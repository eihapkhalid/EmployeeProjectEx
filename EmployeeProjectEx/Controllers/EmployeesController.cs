using Microsoft.AspNetCore.Mvc;
using EmployeeProjectEx.Models;

namespace EmployeeProjectEx.Controllers
{
	public class EmployeesController : Controller
	{
        List<EmployeeModel> LstEmployees;
		 void CreateListEmployees() 
		{
            LstEmployees= new List<EmployeeModel>();

            EmployeeModel oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 1;
            oEmployeeModel.Title = "Branding & Logo Design";
            oEmployeeModel.Name = "Amar Eisa";
            oEmployeeModel.ImgeName = "11.jpg";
            oEmployeeModel.Description = "....... سأظل أمشي ،،،،،،،،،،،، لا كما الطرقات تُمشِي ............ بل كما خَطْوي يُريد";
            LstEmployees.Add(oEmployeeModel);


             oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 2;
            oEmployeeModel.Title = "IT-Developer";
            oEmployeeModel.Name = "Musab Khunaijir";
            oEmployeeModel.ImgeName = "22.jpg";
            oEmployeeModel.Description = "....... أشارككم ما أعرفه من معلومات وإن كانت بسيطة، فلعلها تمس فيكم شيئاً فتنفعكم";
            LstEmployees.Add(oEmployeeModel);

            oEmployeeModel = new EmployeeModel();
            oEmployeeModel.Id = 3;
            oEmployeeModel.Title = "ASP.NET Developer";
            oEmployeeModel.Name = "Eihap Khalid";
            oEmployeeModel.ImgeName = "33.jpg";
            oEmployeeModel.Description = "اهتم بتنمية الاشياء الصغيره فالبذره تتحول الى شجره كبيره وتثمر بعد ان يتم رعايتها";
            LstEmployees.Add(oEmployeeModel);
        }
		public IActionResult Create()
		{
			return View();
		}

		public IActionResult List()
		{

            CreateListEmployees();
            return View(LstEmployees);
		}

        public IActionResult Details(int id,string name)
        {
            CreateListEmployees();
            var myEmployees =LstEmployees.Where(a=>a.Id == id).FirstOrDefault();
            return View(myEmployees);
        }
    }
}
