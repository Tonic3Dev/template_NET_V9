using AutoMapper;
using ClosedXML.Excel;
using template_net_9.DTOs.Timetrack;
using template_net_9.Entities.Timetrack;
using template_net_9.Entities.Users;
using template_net_9.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

namespace template_net_9.Services
{
    public class TimetrackServices
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IActionContextAccessor _actionContextAccessor;

        public TimetrackServices(ApplicationDbContext context, IMapper mapper, IActionContextAccessor actionContextAccessor)
        {
            this._context = context;
            this._mapper = mapper;
            this._actionContextAccessor = actionContextAccessor;
        }

        public async Task<List<TimetrackItemDTO>> GetTimetrackItems()
        {
            var timetrackItems = await _context.TimetrackItems
                .AsNoTracking()
                .Include(t => t.LegacyUser)
                .ThenInclude(u => u.BusinessUnit)
                .Include(t => t.Project)
                .ThenInclude(p => p.BusinessUnit)
                .Include(t => t.Project)
                .ThenInclude(p => p.Proposal)
                .ThenInclude(pp => pp.Account)
                .Include(t => t.Tasktype)
                .Take(20000)
                .ToListAsync();

            //timetrackItems = ApplyTimetrackItemsCustomFilters(timetrackItems, timetrackItemsFilterDTO);

            //var dtos = await timetrackItems.FilterSortPaginate<TimetrackItem, TimetrackItemDTO>(timetrackItemsFilterDTO, _mapper, _actionContextAccessor);
            var dtos = _mapper.Map<List<TimetrackItemDTO>>(timetrackItems);

            var usersIds = timetrackItems.Select(t => t.LegacyUserId).Distinct().ToList();
            var employees = await _context.Employees
                .Where(e => usersIds.Contains(e.LegacyUserId))
                .ToListAsync();

            var providers = await _context.Providers
                .Where(p => usersIds.Contains((int)p.LegacyUserId))
                .ToListAsync();

            Parallel.ForEach(dtos, dto =>
            {
                dto.LegacyUser.InjectFileNumber(employees);
                dto.LegacyUser.InjectFileNumberForProviders(providers);
            });
            return dtos;
        }
    }
}
