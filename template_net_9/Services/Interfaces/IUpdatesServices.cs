using template_net_9.DTOs;
using template_net_9.DTOs.Updates;
using template_net_9.DTOs.Updates.PATCH;
using template_net_9.DTOs.Updates.POST;
using template_net_9.DTOs.Updates.GET;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using template_net_9.Entities.Updates;
using template_net_9.Entities.Users;

namespace template_net_9.Services.Interfaces
{
    public interface IUpdatesServices
    {
        Task<ActionResult<List<UpdateDTO>>> GetUpdatesJoined(UpdatesFilter filter, ApplicationUser applicationUser);

        Task<ActionResult<List<TDTO>>> GetUpdates<TEntity, TDTO>(BaseFilter baseFilter, ApplicationUser applicationUser)
            where TEntity : class, IUpdatesBase, new()
            where TDTO : class, IUpdatesBaseDTO;

        Task<ActionResult> PatchUpdate<TEntity, TDTO>(int id, JsonPatchDocument<TDTO> patchDocument)
            where TEntity : class, IUpdatesBase, new()
            where TDTO : class, IUpdatesBasePatchDTO;

        Task<ActionResult<string>> GetUpdatesReport(UpdatesFilter filter, ApplicationUser applicationUser);
        Task<ActionResult<List<UpdateTypeDTO>>> GetUpdateTypes(ApplicationUser applicationUser);
        Task<ActionResult> CreateUpdate<TCreation, TEntity>(TCreation creationDTO)
            where TCreation : class, IUpdateCreationDTO, new()
            where TEntity : class, IUpdatesBase, new();

        Task<ActionResult> MonetaryBulkCreation(List<MonetaryUpdateBulkCreationDTO> bulkCreationDTOS, ApplicationUser applicationUser);
        Task<ActionResult> StructureBulkCreation(List<StructureUpdateBulkCreationDTO> bulkCreationDTOS, ApplicationUser applicationUser);
        Task<ActionResult<string>> GetUpdatesByDateReport(BaseFilter filter, ApplicationUser applicationUser);

        Task<ActionResult> DeleteUpdate<TEntity>(int id)
            where TEntity : class, IUpdatesBase, new();
    }
}
