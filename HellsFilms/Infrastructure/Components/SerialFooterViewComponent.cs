using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HellsFilms.Infrastructure.Components
{
    public class SerialFooterViewComponent : ViewComponent
    {
            private readonly DataContext _context;

            public SerialFooterViewComponent(DataContext context)
            {
                _context = context;
            }

            public async Task<IViewComponentResult> InvokeAsync() => View(await _context.HellsFilmsSerials.ToListAsync());
    }
}
