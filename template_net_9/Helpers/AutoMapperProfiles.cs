using AutoMapper;
using template_net_9.DTOs;
using template_net_9.DTOs.Updates;
using template_net_9.DTOs.Updates.GET;
using template_net_9.DTOs.Updates.POST;
using template_net_9.DTOs.Updates.PATCH;
using template_net_9.Entities;
using System.Globalization;
using Newtonsoft.Json;
using template_net_9.DTOs.Timetrack;
using template_net_9.DTOs.Auth;
using template_net_9.DTOs.Currencies;
using template_net_9.DTOs.IndirectCosts;
using template_net_9.Extensions;
using template_net_9.DTOs.Account;
using template_net_9.DTOs.BusinessUnit;
using template_net_9.DTOs.Companies;
using template_net_9.DTOs.Permissions;
using template_net_9.DTOs.Projects;
using template_net_9.DTOs.Proposals;
using template_net_9.DTOs.Contracts;
using template_net_9.DTOs.Trainings;
using template_net_9.DTOs.Providers;
using template_net_9.DTOs.Employees;
using template_net_9.Entities.Updates;
using template_net_9.Entities.Employees;
using template_net_9.Entities.Timetrack;
using template_net_9.Entities.Permissions;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Projects;
using template_net_9.DTOs.Tickets;
using template_net_9.Entities.Tickets;
using template_net_9.Entities.Users;

namespace template_net_9.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TimetrackItem, TimetrackItemDTO>()
                // For legacy purposes, hours is a string in the DB, so we parse it as float when working with the DTO
                .ForMember(dto => dto.Hours,
                    options => options.MapFrom(origin =>
                        float.Parse(origin.Hours, CultureInfo.InvariantCulture.NumberFormat)));

            CreateMap<TimetrackItemCreationDTO, TimetrackItem>()
                .ForMember(target => target.Hours, options => options.MapFrom(origin => origin.Hours.ToString(CultureInfo.InvariantCulture.NumberFormat)))
                .ForMember(target => target.Task, options => options.MapFrom(origin => origin.Task.ToTitleCase()));

            CreateMap<TimetrackItemPutDTO, TimetrackItem>()
                .ForMember(target => target.Hours, options => options.MapFrom(origin => origin.Hours.ToString(CultureInfo.InvariantCulture.NumberFormat)))
                .ForMember(target => target.Task, options => options.MapFrom(origin => origin.Task.ToTitleCase()));

            CreateMap<LegacyUser, LegacyUserPublicDTO>();

            CreateMap<Project, ProjectDTO>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => $"{src.Name} ({src.Id})"));

            CreateMap<BusinessUnit, BusinessUnitDTO>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => $"{src.Name} ({src.Id})"));
            CreateMap<BusinessUnitCreationDTO, BusinessUnit>().ReverseMap();
            CreateMap<BusinessUnit, BusinessUnitPatchDTO>().ReverseMap();

            CreateMap<Tasktype, TasktypeDTO>();

            CreateMap<Proposal, ProposalDTO>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => $"{src.Name} ({src.Id})"));

            CreateMap<ApplicationUser, ApplicationUserPublicDTO>();
            CreateMap<ApplicationUser, ApplicationUserPrivateDTO>();

            CreateMap<Account, AccountDTO>()
                .ForMember(dto => dto.Name, options => options.MapFrom(src => $"{src.Name} ({src.Id})"));

            CreateMap<Currency, CurrencyDTO>();
            CreateMap<CurrencyExchange, CurrencyExchangeDTO>();
            CreateMap<CurrencyExchangeCreationDTO, CurrencyExchange>();

            CreateMap<UpdateType, UpdateTypeDTO>();

            CreateMap<LegacyUpdate, LegacyUpdateDTO>();

            CreateMap<BasicUpdate, UpdatesBaseDTO>();
            CreateMap<PeriodUpdate, PeriodUpdateDTO>();
            CreateMap<MonetaryUpdate, MonetaryUpdateDTO>();
            CreateMap<StructureUpdate, StructureUpdateDTO>();
            CreateMap<DateChangeUpdate, DateChangeUpdateDTO>();
            CreateMap<ResignationUpdate, ResignationUpdateDTO>();
            CreateMap<WorkAccidentUpdate, WorkAccidentUpdateDTO>();

            CreateMap<BasicUpdate, UpdatesBasePatchDTO>().ReverseMap();
            CreateMap<PeriodUpdate, PeriodUpdatePatchDTO>().ReverseMap();
            CreateMap<MonetaryUpdate, MonetaryUpdatePatchDTO>().ReverseMap();
            CreateMap<StructureUpdate, StructureUpdatePatchDTO>().ReverseMap();
            CreateMap<DateChangeUpdate, DateChangeUpdatePatchDTO>().ReverseMap();
            CreateMap<ResignationUpdate, ResignationUpdatePatchDTO>().ReverseMap();
            CreateMap<WorkAccidentUpdate, WorkAccidentUpdatePatchDTO>().ReverseMap();

            CreateMap<UpdateCreationDTO, BasicUpdate>();
            CreateMap<PeriodUpdateCreationDTO, PeriodUpdate>();
            CreateMap<MonetaryUpdateCreationDTO, MonetaryUpdate>();
            CreateMap<StructureUpdateCreationDTO, StructureUpdate>();
            CreateMap<DateChangeUpdateCreationDTO, DateChangeUpdate>();
            CreateMap<ResignationUpdateCreationDTO, ResignationUpdate>();
            CreateMap<WorkAccidentUpdateCreationDTO, WorkAccidentUpdate>();

            CreateMap<BasicUpdate, UpdateDTO>();
            CreateMap<PeriodUpdate, UpdateDTO>();
            CreateMap<MonetaryUpdate, UpdateDTO>();
            CreateMap<StructureUpdate, UpdateDTO>();
            CreateMap<DateChangeUpdate, UpdateDTO>();
            CreateMap<ResignationUpdate, UpdateDTO>();
            CreateMap<WorkAccidentUpdate, UpdateDTO>();

            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dto => dto.Contact, opt => opt.MapFrom(src => JsonConvert.DeserializeObject<List<ContactDTO>>(src.Contact)));
            CreateMap<EmployeeCreationDTO, Employee>()
                .ForMember(target => target.AddressStore, op => op.MapFrom(src => JsonConvert.SerializeObject(new AddressDTO()
                { Street = src.Street, Department = src.Department, Floor = src.Floor, Number = src.Number })))
                .ForMember(e => e.BirthDate,
                bd => bd.MapFrom(dto => DateTime.SpecifyKind(dto.BirthDate, DateTimeKind.Utc)))
                  .ForMember(e => e.EntryDate,
                bd => bd.MapFrom(dto => DateTime.SpecifyKind(dto.EntryDate, DateTimeKind.Utc)));
            CreateMap<Employee, EmployeePatchDTO>().ReverseMap()
                .ForMember(e => e.BirthDate,
                bd => bd.MapFrom(dto => DateTime.SpecifyKind((DateTime)dto.BirthDate, DateTimeKind.Utc)))
                .ForMember(e => e.EntryDate,
                bd => bd.MapFrom(dto => DateTime.SpecifyKind((DateTime)dto.EntryDate, DateTimeKind.Utc)));

            CreateMap<Provider, ProviderDTO>();

            CreateMap<City, CityDTO>();

            CreateMap<Group, GroupDTO>();

            CreateMap<GroupLegacyUser, GroupLegacyUserDTO>();

            CreateMap<GroupLegacyUser, GroupLegacyUserPatchDTO>().ReverseMap();

            CreateMap<GroupLegacyUserCreationDTO, GroupLegacyUser>();

            CreateMap<Country, CountryDTO>();

            CreateMap<MedicalCoverage, MedicalCoverageDTO>();

            CreateMap<Position, PositionDTO>();

            CreateMap<Company, CompanyDTO>();

            CreateMap<ProjectLegacyUser, ProjectLegacyUserDTO>();

            CreateMap<Project, ProjectPatchDTO>().ReverseMap()
                .ForMember(p => p.StartDate,
                    o => o.MapFrom(dto => DateTime.SpecifyKind(dto.StartDate, DateTimeKind.Utc)))
                .ForMember(p => p.EndDate, o => o.MapFrom(dto => DateTime.SpecifyKind(dto.EndDate, DateTimeKind.Utc)));

            CreateMap<Proposal, ProposalPatchDTO>().ReverseMap();

            CreateMap<Account, AccountPatchDTO>().ReverseMap();

            CreateMap<Company, CompanyPatchDTO>().ReverseMap();

            CreateMap<Project, ProjectCreationDTO>()
                .ForMember(dto => dto.AccountId, options => options.MapFrom(src => src.Proposal.AccountId));

            CreateMap<ProjectCreationDTO, Project>()
                .ForMember(p => p.StartDate,
                    o => o.MapFrom(dto => DateTime.SpecifyKind(dto.StartDate, DateTimeKind.Utc)))
                .ForMember(p => p.EndDate, o => o.MapFrom(dto => dto.EndDate.HasValue ? DateTime.SpecifyKind(dto.EndDate.Value, DateTimeKind.Utc) : (DateTime?)null));

            CreateMap<ProposalCreationDTO, Proposal>().ReverseMap();

            CreateMap<AccountCreationDTO, Account>().ReverseMap()
                .ForMember(dto => dto.CompanyId, options => options.MapFrom(src => src.Company.Id));

            CreateMap<CompanyCreationDTO, Company>().ReverseMap();

            CreateMap<ProviderPatchDTO, Provider>().ReverseMap();
            CreateMap<ProviderCreationDTO, Provider>();

            CreateMap<IndirectCost, IndirectCostDTO>();
            CreateMap<IndirectCostCreationDTO, IndirectCost>();
            
            CreateMap<Position, PositionDTO>();

            CreateMap<Child, ChildDTO>();
            CreateMap<Child, ChildCreationDTO>()
                .ForMember(p => p.BirthDate, o => o.MapFrom(dto => DateTime.SpecifyKind(dto.BirthDate, DateTimeKind.Utc))).ReverseMap();

            CreateMap<ProjectIncomes, ProjectIncomesCreationDTO>()
                .ForMember(p => p.IncomeDate, o => o.MapFrom(dto => DateTime.SpecifyKind(dto.IncomeDate, DateTimeKind.Utc))).ReverseMap();

            CreateMap<Training, TrainingDTO>();
            CreateMap<TrainingCreationDTO, Training>()
                   .ForMember(dto => dto.StartDate, s => s.MapFrom(t => t.StartDate.ToUniversalTime()))
                    .ForMember(dto => dto.EndDate, s => s.MapFrom(t => t.EndDate.HasValue ? t.EndDate.Value.ToUniversalTime() : (DateTime?)null))
                    .ReverseMap();
            CreateMap<TrainingPatchDTO, Training>().ReverseMap();

            CreateMap<SOWContract, SOWContractDTO>();
            CreateMap<SOWContractPatchDTO, SOWContract>().ReverseMap();
            CreateMap<SOWContractCreationDTO, SOWContract>();

            CreateMap<Ticket, TicketDTO>();
            CreateMap<TicketCreationDTO, Ticket>();
            CreateMap<TicketPatchDTO, Ticket>().ReverseMap();

            CreateMap<Message, MessageDTO>();
            CreateMap<MessageCreationDTO, Message>();
        }
    }
}
