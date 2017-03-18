namespace MySharedBudget.Web.Controllers
{
    using System.Web.Mvc;

    using Data;

    public abstract class BaseController : Controller
    {
        protected MySharedBudgetDbContext data = MySharedBudgetDbContext.Create();
    }
}